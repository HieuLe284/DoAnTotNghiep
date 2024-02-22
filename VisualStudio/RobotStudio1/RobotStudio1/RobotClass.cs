using System;
using System.Windows.Forms;

using ABB.Robotics;
using ABB.Robotics.Controllers;
using ABB.Robotics.Controllers.Discovery;
using ABB.Robotics.Controllers.RapidDomain;
using ABB.Robotics.Controllers.IOSystemDomain;
using System.Collections.Generic;
using System.Diagnostics;

namespace RobotStudio1
{
    class RobotClass
    {
        private Controller controller = null;

        private RapidData rd_targets = null;
        private ArrayData targets = null;

        private RapidData rd_repeat = null;
        private Bool repeatBool;

        private RapidData rd_start = null;
        private const int SHUT_DOWN = -1;
        private const int TO_WAIT = 0;
        private const int TO_PAINT = 1;
        private const int TO_INTRODUCE = 2;
        private const int Project1 = 3;
        private const int Project2 = 4;
        private const int Project3 = 5;
        private const int Project4 = 6;
        private const int Project5 = 7;
        private const int Project6 = 8;
        private const int Project7 = 9;
        private const int Project8 = 10;
        private const int Project9 = 11;
        private const int Project10 = 12;
        private const int Paint = 13;

        private const int Rectangle = 14;
        private const int Rectangle1 = 15;
        private const int Rectangle2 = 16;
        private const int Rectangle3 = 17;
        private const int Rectangle4 = 18;
        private const int Rectangle5 = 19;
        private const int Rectangle6 = 20;
        private const int Rectangle7 = 21;
        private const int Rectangle8 = 22;

        private const int Circle = 23;
        private const int Circle1 = 24;
        private const int Circle2 = 25;
        private const int Circle3 = 26;
        private const int Circle4 = 27;
        private const int Circle5 = 28;
        private const int Circle6 = 29;
        private const int Circle7 = 30;
        private const int Circle8 = 31;

        private Num processFlag;

        private RapidData rd_targetsNum;
        private int maxLength;
        private int targetsNum;
        private Num rd_tgNumValue;

        private RapidData rd_speedLevel;
        private RapidData rd_speed;
        private RapidData rd_position;
        private RapidData rd_box;
        private Num speedLevel;
        private Num speedL;
        private Num positionL;
        private Num boxL;

        public RobotClass(Controller controller)
        {
            this.controller = controller;
            this.controller.Logon(UserInfo.DefaultUser);
            InitDataStream();
        }

        public void InitDataStream()
        {
            Task tRob1 = controller.Rapid.GetTask("T_ROB1");
            if (tRob1 != null)
            {
                rd_repeat = tRob1.GetRapidData("Module1", "repeat");
                if (rd_repeat.Value is Bool)
                {
                    repeatBool = (Bool)rd_repeat.Value;
                }

                rd_start = tRob1.GetRapidData("Module1", "flag");
                if (rd_start.Value is Num)
                {
                    processFlag = (Num)rd_start.Value;
                }

                rd_box = tRob1.GetRapidData("Module1", "box");
                if (rd_box.Value is Num)
                {
                    boxL = (Num)rd_box.Value;
                }

                rd_targetsNum = tRob1.GetRapidData("Module1", "targetsNum");
                if (rd_targetsNum.Value is Num)
                {
                    processFlag = (Num)rd_start.Value;
                }

                rd_speed = tRob1.GetRapidData("Module1", "nRB_SpeedRatio");
                if (rd_speed.Value is Num)
                {
                    speedL = (Num)rd_speed.Value;
                }

                rd_position = tRob1.GetRapidData("Module1", "nRB_Position");
                if (rd_position.Value is Num)
                {
                    positionL = (Num)rd_position.Value;
                }

                rd_speedLevel = tRob1.GetRapidData("Module1", "speedLevel");
                if (rd_speedLevel.Value is Num)
                {
                    speedLevel = (Num)rd_speedLevel.Value;
                }

                rd_targets = tRob1.GetRapidData("Module1", "tgPos");
                if (rd_targets.IsArray)
                {
                    targets = (ArrayData)rd_targets.Value;
                    int aRank = targets.Rank;
                    maxLength = targets.GetLength(aRank - 1);
                    ArrayModes am = targets.Mode;
                    Debug.WriteLine("ARRAY MODE! ::: " + am.ToString());
                    targets.Mode = ArrayModes.Dynamic;
                }
                else MessageBox.Show("'targets' data is not array!");
                if (rd_targets == null) MessageBox.Show("'targets' data does not exist!");
            }
        }

        public void StartRapidProgram()
        {
            try
            {
                if (controller.OperatingMode == ControllerOperatingMode.Auto)
                {
                    using (Mastership m = Mastership.Request(controller.Rapid))
                    {
                        //Perform operation
                        Debug.WriteLine("Exec status of the controller ::: " + controller.Rapid.ExecutionStatus);
                        Debug.WriteLine("Controller State ::: " + controller.State);
                        controller.Rapid.Start(true);
                    }
                }
                else
                {
                    MessageBox.Show("Automatic mode is required to start execution from a remote client.");
                }
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("Mastership is held by another client." + ex.Message);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Unexpected error occurred: " + ex.Message);
            }
        }

        public void StopRapidProgram()
        {
            try
            {
                if (controller.OperatingMode == ControllerOperatingMode.Auto)
                {
                    using (Mastership m = Mastership.Request(controller.Rapid))
                    {
                        controller.Rapid.Stop();
                    }
                }
                else
                {
                    MessageBox.Show("Automatic mode is required to start execution from a remote client.");
                }
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("Mastership is held by another client." + ex.Message);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Unexpected error occurred: " + ex.Message);
            }
        }

        public void MoveAlong(List<BrushStatus> nativTargets, ProgressBar pb)
        {
            SetPath(nativTargets, pb);
            StartProcess();
        }

        public void StopProcess()
        {
            //repeatBool.FillFromString2("FALSE");
            processFlag.FillFromString2(SHUT_DOWN.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                //rd_repeat.Value = repeatBool;
                rd_start.Value = processFlag;
            }
        }

        public void StartProcess()
        {
            processFlag.FillFromString2(TO_PAINT.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_start.Value = processFlag;
            }
        }

        public void PROJECT1()
        {
            processFlag.FillFromString2(Project1.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_start.Value = processFlag;
            }
        }

        public void PROJECT2()
        {
            processFlag.FillFromString2(Project2.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_start.Value = processFlag;
            }
        }

        public void PROJECT3()
        {
            processFlag.FillFromString2(Project3.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_start.Value = processFlag;
            }
        }

        public void PROJECT4()
        {
            processFlag.FillFromString2(Project4.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_start.Value = processFlag;
            }
        }

        public void PROJECT5()
        {
            processFlag.FillFromString2(Project5.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_start.Value = processFlag;
            }
        }

        public void PROJECT6()
        {
            processFlag.FillFromString2(Project6.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_start.Value = processFlag;
            }
        }

        public void PROJECT7()
        {
            processFlag.FillFromString2(Project7.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_start.Value = processFlag;
            }
        }
        public void PROJECT8()
        {
            processFlag.FillFromString2(Project8.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_start.Value = processFlag;
            }
        }

        public void PROJECT9()
        {
            processFlag.FillFromString2(Project9.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_start.Value = processFlag;
            }
        }

        public void PROJECT10()
        {
            processFlag.FillFromString2(Project10.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_start.Value = processFlag;
            }
        }

        public void RECTANGLE()
        {
            boxL.FillFromString2(Rectangle.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void RECTANGLE1()
        {
            boxL.FillFromString2(Rectangle1.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void RECTANGLE2()
        {
            boxL.FillFromString2(Rectangle2.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void RECTANGLE3()
        {
            boxL.FillFromString2(Rectangle3.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void RECTANGLE4()
        {
            boxL.FillFromString2(Rectangle4.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void RECTANGLE5()
        {
            boxL.FillFromString2(Rectangle5.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void RECTANGLE6()
        {
            boxL.FillFromString2(Rectangle6.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void RECTANGLE7()
        {
            boxL.FillFromString2(Rectangle7.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void RECTANGLE8()
        {
            boxL.FillFromString2(Rectangle8.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void CIRCLE()
        {
            boxL.FillFromString2(Circle.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void CIRCLE1()
        {
            boxL.FillFromString2(Circle1.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void CIRCLE2()
        {
            boxL.FillFromString2(Circle2.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void CIRCLE3()
        {
            boxL.FillFromString2(Circle3.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void CIRCLE4()
        {
            boxL.FillFromString2(Circle4.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void CIRCLE5()
        {
            boxL.FillFromString2(Circle5.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void CIRCLE6()
        {
            boxL.FillFromString2(Circle6.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void CIRCLE7()
        {
            boxL.FillFromString2(Circle7.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void CIRCLE8()
        {
            boxL.FillFromString2(Circle8.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_box.Value = boxL;
            }
        }

        public void EX_PAINT()
        {
            processFlag.FillFromString2(Paint.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_start.Value = processFlag;
            }
        }

        public void SPEED(int Speed)
        {
            speedL.FillFromString2(Speed.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_speed.Value = speedL;
            }
        }

        public void POSITION(int Position)
        {
            positionL.FillFromString2(Position.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_position.Value = positionL;
            }
        }

        public void SetDrawingSpeed(int level)
        {
            speedLevel.FillFromString2(level.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_speedLevel.Value = speedLevel;
            }
        }

        public void SetPath(List<BrushStatus> nativTargets, ProgressBar pb)
        {
            if (nativTargets.Count > maxLength) targetsNum = maxLength;
            else targetsNum = nativTargets.Count;

            rd_tgNumValue.FillFromString2(targetsNum.ToString());
            using (Mastership m = Mastership.Request(controller.Rapid))
            {
                rd_targetsNum.Value = rd_tgNumValue;
            }

            Pos rt;
            for (int i = 0; i < targetsNum; i++)
            {
                rt = new Pos();
                rt.FillFromString2("[" + nativTargets[i].X + "," + nativTargets[i].Y + "," + nativTargets[i].Z + "]");
                Debug.WriteLine(rt.ToString());
                using (Mastership m = Mastership.Request(controller.Rapid))
                {
                    rd_targets.WriteItem(rt, i);
                }
                pb.Increment(1);
            }
            pb.Value = 0;
        }

        public void Dispose()
        {
            if (controller.Rapid.ExecutionStatus == ExecutionStatus.Running)
            {
                StopProcess();
            }
            this.controller.Logoff();
            this.controller.Dispose();
            this.controller = null;
        }

        public Controller Controller
        {
            get
            {
                return controller;
            }
        }
    }
}
