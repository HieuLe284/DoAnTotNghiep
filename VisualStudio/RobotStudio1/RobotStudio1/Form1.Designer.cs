﻿namespace RobotStudio1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RepeatButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxPaint = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonPosition = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxJob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonJob10 = new System.Windows.Forms.Button();
            this.buttonJob9 = new System.Windows.Forms.Button();
            this.buttonJob8 = new System.Windows.Forms.Button();
            this.buttonJob7 = new System.Windows.Forms.Button();
            this.buttonJob6 = new System.Windows.Forms.Button();
            this.buttonJob5 = new System.Windows.Forms.Button();
            this.buttonJob4 = new System.Windows.Forms.Button();
            this.buttonJob3 = new System.Windows.Forms.Button();
            this.buttonJob2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBoxPaint.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(5, 21);
            this.comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(281, 24);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(293, 22);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(375, 21);
            this.StopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(325, 21);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(188, 468);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 212);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(216, 260);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(5, 260);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RepeatButton
            // 
            this.RepeatButton.Location = new System.Drawing.Point(87, 260);
            this.RepeatButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RepeatButton.Name = "RepeatButton";
            this.RepeatButton.Size = new System.Drawing.Size(75, 23);
            this.RepeatButton.TabIndex = 8;
            this.RepeatButton.Text = "Repeat";
            this.RepeatButton.UseVisualStyleBackColor = true;
            this.RepeatButton.Click += new System.EventHandler(this.RepeatButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(5, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 185);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // groupBoxPaint
            // 
            this.groupBoxPaint.Controls.Add(this.RepeatButton);
            this.groupBoxPaint.Controls.Add(this.richTextBox1);
            this.groupBoxPaint.Controls.Add(this.panel1);
            this.groupBoxPaint.Controls.Add(this.ClearButton);
            this.groupBoxPaint.Controls.Add(this.trackBar1);
            this.groupBoxPaint.Controls.Add(this.progressBar1);
            this.groupBoxPaint.Location = new System.Drawing.Point(537, 12);
            this.groupBoxPaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPaint.Name = "groupBoxPaint";
            this.groupBoxPaint.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPaint.Size = new System.Drawing.Size(524, 490);
            this.groupBoxPaint.TabIndex = 10;
            this.groupBoxPaint.TabStop = false;
            this.groupBoxPaint.Text = "Leonardo da Vinci";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox);
            this.groupBox2.Controls.Add(this.ConnectButton);
            this.groupBox2.Controls.Add(this.StopButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(519, 62);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.buttonPosition);
            this.groupBox3.Controls.Add(this.buttonUpdate);
            this.groupBox3.Controls.Add(this.textBoxPosition);
            this.groupBox3.Controls.Add(this.textBoxSpeed);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxJob);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.buttonJob10);
            this.groupBox3.Controls.Add(this.buttonJob9);
            this.groupBox3.Controls.Add(this.buttonJob8);
            this.groupBox3.Controls.Add(this.buttonJob7);
            this.groupBox3.Controls.Add(this.buttonJob6);
            this.groupBox3.Controls.Add(this.buttonJob5);
            this.groupBox3.Controls.Add(this.buttonJob4);
            this.groupBox3.Controls.Add(this.buttonJob3);
            this.groupBox3.Controls.Add(this.buttonJob2);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(12, 78);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(519, 250);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Work";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(349, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 25);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Real";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(213, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 25);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Simulation";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonPosition
            // 
            this.buttonPosition.Location = new System.Drawing.Point(213, 212);
            this.buttonPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPosition.Name = "buttonPosition";
            this.buttonPosition.Size = new System.Drawing.Size(75, 23);
            this.buttonPosition.TabIndex = 20;
            this.buttonPosition.Text = "Update";
            this.buttonPosition.UseVisualStyleBackColor = true;
            this.buttonPosition.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(213, 172);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(109, 212);
            this.textBoxPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(99, 22);
            this.textBoxPosition.TabIndex = 22;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(109, 172);
            this.textBoxSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(99, 22);
            this.textBoxSpeed.TabIndex = 19;
            this.textBoxSpeed.TextChanged += new System.EventHandler(this.textBoxSpeed_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(25, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Speed Ratio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(5, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 64);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select\r\nJob";
            // 
            // textBoxJob
            // 
            this.textBoxJob.Location = new System.Drawing.Point(79, 25);
            this.textBoxJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxJob.Name = "textBoxJob";
            this.textBoxJob.Size = new System.Drawing.Size(48, 22);
            this.textBoxJob.TabIndex = 17;
            this.textBoxJob.TextChanged += new System.EventHandler(this.textBoxJob_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Job No.";
            // 
            // buttonJob10
            // 
            this.buttonJob10.Location = new System.Drawing.Point(429, 118);
            this.buttonJob10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonJob10.Name = "buttonJob10";
            this.buttonJob10.Size = new System.Drawing.Size(75, 37);
            this.buttonJob10.TabIndex = 15;
            this.buttonJob10.Text = "Job 10";
            this.buttonJob10.UseVisualStyleBackColor = true;
            this.buttonJob10.Click += new System.EventHandler(this.buttonJob10_Click);
            // 
            // buttonJob9
            // 
            this.buttonJob9.Location = new System.Drawing.Point(349, 118);
            this.buttonJob9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonJob9.Name = "buttonJob9";
            this.buttonJob9.Size = new System.Drawing.Size(75, 37);
            this.buttonJob9.TabIndex = 14;
            this.buttonJob9.Text = "Job 9";
            this.buttonJob9.UseVisualStyleBackColor = true;
            this.buttonJob9.Click += new System.EventHandler(this.buttonJob9_Click);
            // 
            // buttonJob8
            // 
            this.buttonJob8.Location = new System.Drawing.Point(268, 118);
            this.buttonJob8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonJob8.Name = "buttonJob8";
            this.buttonJob8.Size = new System.Drawing.Size(75, 37);
            this.buttonJob8.TabIndex = 13;
            this.buttonJob8.Text = "Job 8";
            this.buttonJob8.UseVisualStyleBackColor = true;
            this.buttonJob8.Click += new System.EventHandler(this.buttonJob8_Click);
            // 
            // buttonJob7
            // 
            this.buttonJob7.Location = new System.Drawing.Point(187, 118);
            this.buttonJob7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonJob7.Name = "buttonJob7";
            this.buttonJob7.Size = new System.Drawing.Size(75, 37);
            this.buttonJob7.TabIndex = 12;
            this.buttonJob7.Text = "Job 7";
            this.buttonJob7.UseVisualStyleBackColor = true;
            this.buttonJob7.Click += new System.EventHandler(this.buttonJob7_Click);
            // 
            // buttonJob6
            // 
            this.buttonJob6.Location = new System.Drawing.Point(107, 118);
            this.buttonJob6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonJob6.Name = "buttonJob6";
            this.buttonJob6.Size = new System.Drawing.Size(75, 37);
            this.buttonJob6.TabIndex = 11;
            this.buttonJob6.Text = "Job 6";
            this.buttonJob6.UseVisualStyleBackColor = true;
            this.buttonJob6.Click += new System.EventHandler(this.buttonJob6_Click);
            // 
            // buttonJob5
            // 
            this.buttonJob5.Location = new System.Drawing.Point(429, 73);
            this.buttonJob5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonJob5.Name = "buttonJob5";
            this.buttonJob5.Size = new System.Drawing.Size(75, 39);
            this.buttonJob5.TabIndex = 10;
            this.buttonJob5.Text = "Job 5";
            this.buttonJob5.UseVisualStyleBackColor = true;
            this.buttonJob5.Click += new System.EventHandler(this.buttonJob5_Click);
            // 
            // buttonJob4
            // 
            this.buttonJob4.Location = new System.Drawing.Point(349, 73);
            this.buttonJob4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonJob4.Name = "buttonJob4";
            this.buttonJob4.Size = new System.Drawing.Size(75, 39);
            this.buttonJob4.TabIndex = 9;
            this.buttonJob4.Text = "Job 4";
            this.buttonJob4.UseVisualStyleBackColor = true;
            this.buttonJob4.Click += new System.EventHandler(this.buttonJob4_Click);
            // 
            // buttonJob3
            // 
            this.buttonJob3.Location = new System.Drawing.Point(268, 73);
            this.buttonJob3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonJob3.Name = "buttonJob3";
            this.buttonJob3.Size = new System.Drawing.Size(75, 39);
            this.buttonJob3.TabIndex = 8;
            this.buttonJob3.Text = "Job 3";
            this.buttonJob3.UseVisualStyleBackColor = true;
            this.buttonJob3.Click += new System.EventHandler(this.buttonJob3_Click);
            // 
            // buttonJob2
            // 
            this.buttonJob2.Location = new System.Drawing.Point(187, 73);
            this.buttonJob2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonJob2.Name = "buttonJob2";
            this.buttonJob2.Size = new System.Drawing.Size(75, 39);
            this.buttonJob2.TabIndex = 7;
            this.buttonJob2.Text = "Job 2";
            this.buttonJob2.UseVisualStyleBackColor = true;
            this.buttonJob2.Click += new System.EventHandler(this.buttonJob2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(107, 73);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 39);
            this.button4.TabIndex = 6;
            this.button4.Text = "Job 1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 539);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxPaint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBoxPaint.ResumeLayout(false);
            this.groupBoxPaint.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RepeatButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxPaint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonJob10;
        private System.Windows.Forms.Button buttonJob9;
        private System.Windows.Forms.Button buttonJob8;
        private System.Windows.Forms.Button buttonJob7;
        private System.Windows.Forms.Button buttonJob6;
        private System.Windows.Forms.Button buttonJob5;
        private System.Windows.Forms.Button buttonJob4;
        private System.Windows.Forms.Button buttonJob3;
        private System.Windows.Forms.Button buttonJob2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxJob;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonPosition;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
