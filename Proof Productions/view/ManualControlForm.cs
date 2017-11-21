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
using System.Diagnostics;

namespace Proof_Productions
{
    public partial class ManualControlForm : Form
    {
        Timer timer = new Timer();
        Stopwatch sw = new Stopwatch();
        PacketController p1;
        FieldbusInputData input1;
        Boolean stopTimer;
        long Elapsed;

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
            if (p1 == null)
            {
                p1 = new PacketController();          
                p1.ConnectMotor();

                input1 = new FieldbusInputData();
                Console.WriteLine("Created input1");
            }
            
            String speedStr = motor1Spd.Text;
            String accelStr = motor1Accel.Text;
            String decelStr = motor1Decel.Text;

            int speed= 0, acceleration = 0, deceleration = 0;
            if (int.TryParse(speedStr, out speed) && (int.TryParse(accelStr, out acceleration) || int.TryParse(decelStr, out deceleration) ) )
            {

                //writeToMotor();
                input1.SetpointVelocity.Set(speed);
                input1.Acceleration.Set(acceleration);
                input1.Deceleration.Set(deceleration);
                input1.Control_I3.Positive = motor1Backward.Checked;
                input1.Control_I3.Negative = motor1Forward.Checked;

                stopTimer = false;
                timer.Interval = 100;
                timer.Tick += new EventHandler(timerTick);
                sw.Start();
                timer.Start();
                //p.WriteMotor(speed, acceleration, true);
            }

            else
            {
                // TODO Show a dialog

            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            Console.Out.WriteLine("TICK");
            writeToMotorOnce();
            if (stopTimer)
            { 
                Console.WriteLine(Elapsed + " " + sw.ElapsedMilliseconds + " " + sw.Elapsed);
                if (sw.ElapsedMilliseconds >= (Elapsed + 1500))
                {
                    timer.Stop();
                    sw.Stop();
                }
            }
        }

        private void writeToMotorOnce()
        {
            p1.WriteMotor(input1);
            Console.WriteLine("Writing to motor");
        }
        
        private void motor1Stop_Click(object sender, EventArgs e)
        {
            input1.Deceleration.Set(input1.SetpointVelocity.Get()/2);
            input1.SetpointVelocity.Set(0);
            stopTimer = true;
            Elapsed = sw.ElapsedMilliseconds;
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

        }

        private void motor2Stop_Click(object sender, EventArgs e)
        {

        }

        private void motor2Clear_Click(object sender, EventArgs e)
        {
            motorBox2.Text = "";
            motor2Desc.Text = "";
            motor2Spd.Text = "";
            motor2Accel.Text = "";
            motor2Decel.Text = "";
            motor2Forward.Checked = true;
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            new AboutForm().Show();
        }

        private void setupCuesToolStripMenuItem_Click(object sender, EventArgs e) {
            switchToForm(new SetupCueForm());
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e) {
            switchToForm(new MainMenuForm());
        }

        private void switchToForm(Form form) {
            form.Show();
            form.Left = this.Left;
            form.Top = this.Top;
            
            this.Hide();
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
            switchToForm(new SetupMotorForm());
        }

        private void loggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchToForm(new LoggerForm());
        }

        private void ManualControlForm_Load(object sender, EventArgs e)
        {

        }
    }
}
