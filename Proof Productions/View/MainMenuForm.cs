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

        private PlayCueController playCueController1;

        public MainMenuForm()
        {
            InitializeComponent();
            playCueController1 = new PlayCueController();
            playCueController1.InitObjects();
            populateView();
            
        }

        public void populateView()
        {
            foreach(Cue c in playCueController1.GetCueList())
            {
                cueManager.Items.Add((c.Name));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (playCueController1 != null && !playCueController1.HasCueFinished())
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
                    Logger.LogError("Main form was closed while the motor is running");
                    playCueController1.Estop();
                }
            }
        }

        private void EstopButtonClick(object sender, EventArgs e)
        {
            Logger.LogInfo("Estop button was pressed");
            if (playCueController1 != null)
            {
                playCueController1.Estop();
            }
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

        private void motorList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void playCueButton_Click(object sender, EventArgs e)
        {
            playCueController1 = new PlayCueController();
            playCueController1.PlayCurrentCue();
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
            playCueController1.StopCurrentCue();
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
            new LoggerForm().Show();
        }

        private void setupMotorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToForm(new SetupMotorForm());
        }

        private void cueManager_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cueDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}