using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathWork.MATLAB;
using static MathWork.MATLAB.Connect;
using static MathWork.MATLAB.Waypoint;
using static MathWork.MATLAB.Traj;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;
using static RobotStudio.Services.RobApi.Transport.RWS.RobFileTransferLegacyRWS;
using System.IO;

namespace RobotStudio1
{
    
    public partial class Matlab : Form
    {
        private MLApp.MLApp matlab;
        public Matlab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Traj traj = new Traj();
                Waypoint waypoint = new Waypoint();
                waypoint.createWaypointData();
                traj.plotTrajectory();
                traj.manipTrajCartesian();
                traj.WaitForFiguresToDie();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!");
            } 
        }
    }
}
    