using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proof_Productions
{
    public partial class ManualControlForm : Form
    {
        Timer timer = new Timer();


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

        private void motor1Dir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor1Spd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor1Accel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        PacketController p;

        private void motor1Play_Click(object sender, EventArgs e)
        {
            /*
            if (p == null)
            {
                p = new PacketController();
                p.ConnectMotor();
            }
            */

            String speedStr = motor1Spd.Text;
            String accelStr = motor1Accel.Text;

            if (speedStr == null || speedStr.Equals("") || accelStr == null || speedStr.Equals(""))
            {
                // TODO Show a dialog
            } else {
                int speed = Convert.ToInt32(motor1Spd.Text);
                int acceleration = Convert.ToInt32(motor1Accel.Text);

                writeToMotor(speed, acceleration, true, 5000);
                
                //p.WriteMotor(speed, acceleration, true);
            }

            
            
            //p.Test();
        }

        public void writeToMotor(int speed, int acceleration, bool foward, int durationMilliseconds)
        {
            // 200 ms seems good for
            timer.Interval = 100;
            timer.Tick += new EventHandler(timerTick);
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            Console.Out.WriteLine("TICK");
            writeToMotorOnce(300, 100, true);
        }

        private void timerTick2(object sender, EventArgs e)
        {
            Console.Out.WriteLine("TICK");
            writeToMotorOnce(10);
        }

        private void writeToMotorOnce(int deceleration)
        {
            p.TestDecel(deceleration);
        }

        private void writeToMotorOnce(int speed, int acceleration, bool foward)
        {
            p.WriteMotor(speed, acceleration, foward);
        }

        private void motor1Stop_Click(object sender, EventArgs e)
        {
            timer.Tick -= timerTick;
            timer.Tick += new EventHandler(timerTick2);
        }

        private void motor1Clear_Click(object sender, EventArgs e)
        {
            motorBox1.Text = "";
            motor1Desc.Text = "";
            motor1Spd.Text = "";
            motor1Accel.Text = "";
            motor1Decel.Text = "";
            motor1Dir.Text = "";
        }

        private void motor2Desc_TextChanged(object sender, EventArgs e)
        {

        }
 

        private void motorBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor2Dir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor2Spd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor2Accel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor2Play_Click(object sender, EventArgs e)
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
            motor2Dir.Text = "";
        }

        private void motor3Desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void motorBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor3Dir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor3Spd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor3Accel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motor3Play_Click(object sender, EventArgs e)
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
        
        private void dirLabel1_Click(object sender, EventArgs e)
        {

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
    }
}
