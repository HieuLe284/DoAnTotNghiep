﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ABB.Robotics;
using ABB.Robotics.Controllers;
using ABB.Robotics.Controllers.Discovery;
using ABB.Robotics.Controllers.IOSystemDomain;
using ABB.Robotics.Controllers.RapidDomain;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RobotStudio1
{
    public partial class Form1 : Form
    {
        private bool paint = false;
        private SolidBrush color;
        private List<BrushStatus> posList;

        private NetworkScanner scanner = null;
        private RobotClass myRobot = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ControllerInfoCollection controllers = scanner.Controllers;
            foreach (ControllerInfo info in controllers)
            {
                if (comboBox.Text.Equals(info.ControllerName + " / " + info.IPAddress.ToString()))
                {
                    if (info.Availability == Availability.Available)
                    {
                        if (myRobot != null)
                        {
                            myRobot.Dispose(); // = LogOff
                            myRobot = null;
                        }
                        myRobot = new RobotClass(ControllerFactory.CreateFrom(info));
                        myRobot.StartRapidProgram();
                        myRobot.Controller.ConnectionChanged += new EventHandler<ConnectionChangedEventArgs>(ConnectionChanged);
                        ConnectButton.BackColor = Color.Green;
                        //groupBox3.Visible = true;
                        //groupBoxPaint.Visible = true;
                        break;
                    }
                }
                {
                    MessageBox.Show("Selected controller not available.");
                }
            }
            if (myRobot == null) MessageBox.Show("Selected controller not available. (comboBox String != controller info)");
        }

        public void ConnectionChanged(object sender, EventArgs e)
        {
            if (myRobot.Controller.Connected == true) ConnectButton.BackColor = Color.Green;
            else ConnectButton.BackColor = Color.Red;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (myRobot != null)
            {
                myRobot.StopProcess();
            }
            //myRobot.Dispose();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Graphics g1 = panel1.CreateGraphics();
            g1.Clear(panel1.BackColor);
        }

        private void RepeatButton_Click(object sender, EventArgs e)
        {
            if (myRobot != null)
            {
                myRobot.StartProcess();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (myRobot != null)
            {
                myRobot.SetDrawingSpeed(trackBar1.Value);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (myRobot != null)
            {
                paint = true;
                posList = new List<BrushStatus>();
                posList.Add(new BrushStatus(e.X, e.Y, 0));
                richTextBox1.Text = "";
                if (myRobot.Controller.Rapid.ExecutionStatus == ABB.Robotics.Controllers.RapidDomain.ExecutionStatus.Stopped)
                {
                    myRobot.StartRapidProgram();
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (myRobot != null)
            {
                paint = false;
                posList.Add(new BrushStatus(e.X, e.Y, -10));
                var index = 0;
                foreach (var item in posList)
                {
                    richTextBox1.Text += (index++) + ".     " + item.ToString();
                }
                progressBar1.Maximum = posList.Count;
                myRobot.MoveAlong(posList, progressBar1);
                posList.Clear();
                posList = null;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                color = new SolidBrush(Color.Black);
                Graphics g = panel1.CreateGraphics();
                g.FillEllipse(color, e.X, e.Y, 10, 10);
                posList.Add(new BrushStatus(e.X, e.Y, 0));
                g.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.scanner = new NetworkScanner();
            this.scanner.Scan();
            ControllerInfoCollection controllers = scanner.Controllers;
            foreach (ControllerInfo info in controllers)
            {
                comboBox.Items.Add(info.ControllerName + " / " + info.IPAddress.ToString());
            }
           // groupBox3.Visible = false;
            //groupBoxPaint.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myRobot != null)
            {
                myRobot.Dispose(); // = LogOff
                myRobot = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (myRobot != null)
            {
                myRobot.PROJECT1();
            }
            textBoxJob.Text = "1";
        }

        private void textBoxJob_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxSpeed_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (myRobot != null)
            {
                int Speed;
                Speed = int.Parse(textBoxSpeed.Text);
                myRobot.SPEED(Speed);
            }
            
        }

        private void buttonJob2_Click(object sender, EventArgs e)
        {
            if (myRobot != null)
            {
                myRobot.PROJECT2();
            }
            textBoxJob.Text = "2";
        }

        private void buttonJob3_Click(object sender, EventArgs e)
        {
            if (myRobot != null)
            {
                myRobot.PROJECT3();
            }
            textBoxJob.Text = "3";
        }

        private void buttonJob4_Click(object sender, EventArgs e)
        {
            if (myRobot != null)
            {
                myRobot.PROJECT4();
            }
            textBoxJob.Text = "4";
        }

        private void buttonJob5_Click(object sender, EventArgs e)
        {
            if (myRobot != null)
            {
                myRobot.PROJECT5();
            }
            textBoxJob.Text = "5";
        }

        private void buttonJob6_Click(object sender, EventArgs e)
        {
            if (myRobot != null)
            {
                myRobot.PROJECT6();
            }
            textBoxJob.Text = "6";
        }

        private void buttonJob7_Click(object sender, EventArgs e)
        {
            if (myRobot != null)
            {
                myRobot.PROJECT7();
            }
            textBoxJob.Text = "7";
        }

        private void buttonJob8_Click(object sender, EventArgs e)
        {
            if (myRobot != null)
            {
                myRobot.PROJECT8();
            }
            textBoxJob.Text = "8";
        }

        private void buttonJob9_Click(object sender, EventArgs e)
        {
            if (myRobot != null)
            {
                myRobot.PROJECT9();
            }
            textBoxJob.Text = "9";
        }

        private void buttonJob10_Click(object sender, EventArgs e)
        {
            if (myRobot != null)
            {
                myRobot.PROJECT10();
            }
            textBoxJob.Text = "10";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void buttonPosition_Click(object sender, EventArgs e)
        {
            if (myRobot != null)
            {
                int Position;
                Position = int.Parse(textBoxPosition.Text);
                myRobot.POSITION(Position);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myRobot != null)
            {
                myRobot.EX_PAINT();
            }
        }
    }
}