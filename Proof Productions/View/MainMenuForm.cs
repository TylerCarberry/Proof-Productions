using System;
using System.Collections.Generic;
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
            PopulateView();
        }

        public void PopulateView()
        {
            foreach(Cue c in playCueController1.GetCueList())
            {
                cueManager.Items.Add((c.Name));
            }
        }

        /// <summary>
        /// If the form is closed while the motor is running, show a warning dialog
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (playCueController1 != null && playCueController1.IsCueRunning())
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

        private void editCueButton_Click(object sender, EventArgs e)
        {
            SwitchToForm(new SetupCueForm());
        }

        private void removeCueButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?", "Remove Cue",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        
        private void PlayCueButton_Click(object sender, EventArgs e)
        {
            playCueController1.PlayCurrentCue();
        }

        private void PauseCueButton_Click(object sender, EventArgs e)
        {
            // Not implemented yet
        }

        private void NextCueButton_Click(object sender, EventArgs e)
        {
            if (cueManager.SelectedIndex < cueManager.Items.Count - 1)
            {
                cueManager.SelectedIndex += 1;
            }
        }

        private void PreviousCueButton_Click(object sender, EventArgs e)
        {
            if (cueManager.SelectedIndex > 0)
            {
                cueManager.SelectedIndex -= 1;
            }
        }

        private void StopCueButton_Click(object sender, EventArgs e)
        {
            playCueController1.StopCurrentCue();
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
            if (cueManager.SelectedIndex < 0)
            {
                return;
            }

            motorList.Items.Clear();
            HashSet<String> motors = new HashSet<String>();
            Cue CurrentCue = playCueController1.GetCueList()[cueManager.SelectedIndex];
            
            //populate motor list with only UNIQUE motors
            foreach (CueItem Item in CurrentCue.GetList())
            {
                String CueMotorName = Item.CueMotor.Name;
                if (!(motors.Contains(CueMotorName)))
                {
                    motors.Add(CueMotorName);
                    motorList.Items.Add(CueMotorName);
                }
            }
            playCueController1.ChangeCurrentCueWithIndex(cueManager.SelectedIndex);

            //populate description text box
            cueDescription.Text = CurrentCue.Description;
        }
    
    }
}