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

        private void motor1Play_Click(object sender, EventArgs e)
        {

        }

        private void motor1Pause_Click(object sender, EventArgs e)
        {

        }

        private void motor1Stop_Click(object sender, EventArgs e)
        {

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

        private void motor2Pause_Click(object sender, EventArgs e)
        {

        }

        private void motor2Stop_Click(object sender, EventArgs e)
        {

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

        private void motor3Stop_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            new AboutForm().Show();
        }

        private void setupCuesToolStripMenuItem_Click(object sender, EventArgs e) {
            switchToForm(new SetupCueForm());
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e) {
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
    }
}
