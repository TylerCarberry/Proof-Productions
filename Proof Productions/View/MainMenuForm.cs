using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proof_Productions.Controller;
using Proof_Productions.Model;

namespace Proof_Productions.View
{
    public partial class MainMenuForm : BaseForm
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EstopButtonClick(object sender, EventArgs e)
        {

        }

        private void addCueButton_Click(object sender, EventArgs e)
        {

        }

        private void editCueButton_Click(object sender, EventArgs e)
        {

        }

        private void removeCueButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?", "Remove Cue",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }


        private void cueManager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motorList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        PlayCueController C1;
        private void playCueButton_Click(object sender, EventArgs e)
        {
            C1 = new PlayCueController();
            C1.PlayCurrentCue();
        }

        private void pauseCueButton_Click(object sender, EventArgs e)
        {

        }

        private void nextCueButton_Click(object sender, EventArgs e)
        {

        }

        private void previousCueButton_Click(object sender, EventArgs e)
        {

        }

        private void stopCueButton_Click(object sender, EventArgs e)
        {
            C1.StopCurrentCue();
        }

        private void moveCueUpButton_Click(object sender, EventArgs e)
        {

        }

        private void moveCueDownButton_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manualControlToolStripMenuItem_Click(object sender, EventArgs e) {
            SwitchToForm(new ManualControlForm());
        }

        private void setupCuesToolStripMenuItem_Click(object sender, EventArgs e) {
            SwitchToForm(new SetupCueForm());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            new AboutForm().Show();
        }

        private void loggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToForm(new LoggerForm());
        }

        private void setupMotorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToForm(new SetupMotorForm());
        }

    }
}