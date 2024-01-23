using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotStudio1
{
    public partial class RobotStudioGUI : Form
    {
        public RobotStudioGUI()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private Button currentButton;

        private void ChildForm(Form childform)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock= DockStyle.Fill;
            panel1.Controls.Add(childform);
            panel1.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (currentFormChild != null)
                currentFormChild.Close();*/
            ChildForm(new BiaHUST());
        }

        private void workToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form1());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void matlabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Matlab());
        }
    }
}
