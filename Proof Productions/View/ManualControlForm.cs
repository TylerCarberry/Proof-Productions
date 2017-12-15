using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proof_Productions.Model.Input;
using Proof_Productions.Model.Output;
using Proof_Productions.Controller;

using System.Diagnostics;

namespace Proof_Productions.View
{
    public partial class ManualControlForm : BaseForm
    {
        ManualController Controller1, Controller2;

        public ManualControlForm()
        {
            InitializeComponent();
        }

        private void motor1Desc_TextChanged(object sender, EventArgs e)
        {

        }


        private void motorBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor1Spd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor1Accel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor1Start_Click(object sender, EventArgs e)
        {
            if (Controller1 == null)
            {
                Controller1 = new ManualController();
                Controller1.ConnectMotor();
            }

            String speedStr = motor1Spd.Text;
            String accelStr = motor1Accel.Text;
            String decelStr = motor1Decel.Text;
         /*
            int.TryParse(speedStr, out int Speed);
            int.TryParse(accelStr, out int Acceleration);
            int.TryParse(decelStr, out int Deceleration);
                
            Controller1.WriteMotor(Speed, Acceleration, Deceleration, motor1Forward.Checked); */
        }

        private void motor1Stop_Click(object sender, EventArgs e)
        {
            if(Controller1 != null)
                Controller1.StopMotor();
        }

        private void motor1Clear_Click(object sender, EventArgs e)
        {
            motorBox1.Text = "";
            motor1Desc.Text = "";
            motor1Spd.Text = "";
            motor1Accel.Text = "";
            motor1Decel.Text = "";
            motor1Forward.Checked = true;
        }

        private void motor1Forward_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void motor1Backward_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void motor2Desc_TextChanged(object sender, EventArgs e)
        {

        }


        private void motorBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor2Spd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor2Accel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor2Start_Click(object sender, EventArgs e)
        {
            if (Controller2 == null)
            {
                Controller2 = new ManualController();
                Controller2.ConnectMotor();
            }

            String speedStr = motor2Spd.Text;
            String accelStr = motor2Accel.Text;
            String decelStr = motor2Decel.Text;
            String countStr = motor2Counts.Text;
            String degreeStr = Motor2Degrees.Text;
            /*
            int.TryParse(speedStr, out int Speed);
            int.TryParse(accelStr, out int Acceleration);
            int.TryParse(decelStr, out int Deceleration);
            double.TryParse(countStr, out double Counts);
            double.TryParse(degreeStr, out double Degrees);
            Controller2.WriteMotor(Speed, Acceleration, Deceleration, Counts, Degrees); */
        }

        private void motor2Stop_Click(object sender, EventArgs e)
        {
            if(Controller2 != null)
                Controller2.StopMotor();
        }

        private void motor2Clear_Click(object sender, EventArgs e)
        {
            motorBox2.Text = "";
            motor2Desc.Text = "";
            motor2Spd.Text = "";
            motor2Accel.Text = "";
            motor2Decel.Text = "";
            motor2Counts.Text = "";
            Motor2Degrees.Text = "";
        }

        private void motor2Forward_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void motor2Backward_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void motor3Desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void motorBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor3Spd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor3Accel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor3Start_Click(object sender, EventArgs e)
        {

        }

        private void motor3Pause_Click(object sender, EventArgs e)
        {

        }

        private void motor3Clear_Click(object sender, EventArgs e)
        {
            motorBox3.Text = "";
            motor3Desc.Text = "";
            motor3Spd.Text = "";
            motor3Accel.Text = "";
            motor3Decel.Text = "";
            motor3Forward.Checked = true;
        }

        private void motor3Forward_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void motor3Backward_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        private void setupCuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToForm(new SetupCueForm());
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToForm(new MainMenuForm());
        }

        private void calibrationMotorChecklist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calibrationLabel1(object sender, EventArgs e)
        {

        }

        private void selectMotorCalibrationLabel1(object sender, EventArgs e)
        {

        }

        private void startCalibrationBtn_Click(object sender, EventArgs e)
        {

        }

        private void pauseCalibrationBtn_Click(object sender, EventArgs e)
        {

        }

        private void stopCalibrationBtn_Click(object sender, EventArgs e)
        {

        }

        private void setupMotorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToForm(new SetupMotorForm());
        }

        private void loggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoggerForm().Show();
        }

        private void ManualControlForm_Load(object sender, EventArgs e)
        {

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

        private void estopButton_Click(object sender, EventArgs e)
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
        
        private void motor1Spd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void motor1Accel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void motor1Decel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void motor2Spd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void motor2Accel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void motor2Decel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void motor3Spd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void motor3Accel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void motor3Decel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
