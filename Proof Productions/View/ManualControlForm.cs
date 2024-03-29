﻿using System;
using System.Windows.Forms;
using Proof_Productions.Controller;
using System.Data;

namespace Proof_Productions.View
{
    public partial class ManualControlForm : BaseForm
    {
        ManualController Controller1, Controller2;

        public ManualControlForm()
        {
            InitializeComponent();
            Controller1 = new ManualController();
            Controller2 = new ManualController();
            populateComboBox(motorBox1, Controller1);
            populateComboBox(motorBox2, Controller2);
        }

        private void Motor1Start_Click(object sender, EventArgs e)
        {
            Controller1.ConnectMotor();

            String speedStr = motor1Spd.Text;
            String accelStr = motor1Accel.Text;
            String decelStr = motor1Decel.Text;

            int Speed, Acceleration, Deceleration;
            int.TryParse(speedStr, out Speed);
            int.TryParse(accelStr, out Acceleration);
            int.TryParse(decelStr, out Deceleration);

            Controller1.WriteMotor(Speed, Acceleration, Deceleration, motor1Forward.Checked); 
        }

        private void Motor1Stop_Click(object sender, EventArgs e)
        {
            if(Controller1 != null)
                Controller1.StopMotor();
        }

        private void Motor1Clear_Click(object sender, EventArgs e)
        {
            motorBox1.Text = "";
            motor1Desc.Text = "";
            motor1Spd.Text = "";
            motor1Accel.Text = "";
            motor1Decel.Text = "";
            motor1Forward.Checked = true;
        }

        private void Motor2Start_Click(object sender, EventArgs e)
        {
            Controller2.ConnectMotor();

            String speedStr = motor2Spd.Text;
            String accelStr = motor2Accel.Text;
            String decelStr = motor2Decel.Text;
            String countStr = motor2Counts.Text;
            String degreeStr = Motor2Degrees.Text;

            int Speed, Acceleration, Deceleration;
            double Counts, Degrees;
            int.TryParse(speedStr, out Speed);
            int.TryParse(accelStr, out Acceleration);
            int.TryParse(decelStr, out Deceleration);
            double.TryParse(countStr, out Counts);
            double.TryParse(degreeStr, out Degrees);

            Controller2.WriteMotor(Speed, Acceleration, Deceleration, Counts, Degrees);
        }

        private void Motor2Stop_Click(object sender, EventArgs e)
        {
            if(Controller2 != null)
                Controller2.StopMotor();
        }

        private void Motor2Clear_Click(object sender, EventArgs e)
        {
            motorBox2.Text = "";
            motor2Desc.Text = "";
            motor2Spd.Text = "";
            motor2Accel.Text = "";
            motor2Decel.Text = "";
            motor2Counts.Text = "";
            Motor2Degrees.Text = "";
        }

        private void Motor3Clear_Click(object sender, EventArgs e)
        {
            motorBox3.Text = "";
            motor3Desc.Text = "";
            motor3Spd.Text = "";
            motor3Accel.Text = "";
            motor3Decel.Text = "";
            motor3Forward.Checked = true;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        private void SetupCuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToForm(new SetupCueForm());
        }

        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToForm(new MainMenuForm());
        }

        private void SetupMotorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToForm(new SetupMotorForm());
        }

        private void LoggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoggerForm().Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((Controller1 != null && Controller1.TimerIsRunning()) || (Controller2 != null && Controller2.TimerIsRunning()))
            {
                DialogResult answer = MessageBox.Show("The motor is running. Closing this form will stop the cue.", "Are you sure?",
                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (answer != DialogResult.OK)
                {
                    e.Cancel = true;
                    FormToOpenNext = null;
                }
                else
                {
                    Estop();
                }
            }
        }

        private void EstopButton_Click(object sender, EventArgs e)
        {
            Estop();
        }

        private void Estop()
        {
            if(Controller1 != null)
                Controller1.Estop();
            if(Controller2 != null)
                Controller2.Estop();
        }
        
        private void NumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void motorBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (motorBox1.SelectedIndex != -1) {
                if (motorBox2.Text.Equals(motorBox1.Text))
                {
                    MessageBox.Show("Motor is already in use");
                    motorBox1.SelectedIndex = -1;
                    motor1Desc.Clear();
                }
                else
                {
                    DataTable table = Controller1.GetMotorInfo(motorBox1.Text);
                    DataRow row = table.Rows[0];
                    motor1Desc.Text = row["Description"].ToString();
                }
            }
        }

        private void motorBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (motorBox2.SelectedIndex != -1)
            {
                if (motorBox1.Text.Equals(motorBox2.Text))
                {
                    MessageBox.Show("Motor is already in use");
                    motorBox2.SelectedIndex = -1;
                    motor2Desc.Clear();
                }
                else
                {
                    DataTable table = Controller2.GetMotorInfo(motorBox2.Text);
                    DataRow row = table.Rows[0];
                    motor2Desc.Text = row["Description"].ToString();
                }
            }
        }

        /// <summary>
        /// Populate a specific ComboBox with the names of all the motors
        /// </summary>
        /// <param name="Box"></param>
        /// <param name="Controller"></param>
        public void populateComboBox(ComboBox Box, ManualController Controller)
        {
            Box.Items.Clear();
            DataTable table = Controller.GetMotors();
            foreach (DataRow row in table.Rows)
                Box.Items.Add(row["Name"].ToString());
        }
    }
}
