using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proof_Productions.View
{
    public partial class NewCueItemForm : Form
    {
        protected bool submitted = false;
        public NewCueItemForm(SetupCueForm SetupCue)
        {
            InitializeComponent();
            //Set the Cue TextBox to the currently selected Cue
            //and make it unchangeable
            CueTextBox.Text = SetupCue.getCurrentCue();
            CueTextBox.ReadOnly = true;
            CueTextBox.ForeColor = Color.Gray;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool isSubmitted()
        {
            return submitted;
        }

        public String getCueItemName()
        {
            return NameTextBox.Text;
        }

        public String getCueItemNumber()
        {
            return CueItemNumberTextBox.Text;

        }

        public String getStartDelay()
        {
            return DelayTextbox.Text;
        }

        public String getDuration()
        {
            return DurationTextBox.Text;
        }

        public String getVelocity()
        {
            return VelocityTextBox.Text;
        }

        public String getAccel()
        {
            return AccelTextBox.Text;
        }

        public String getDecel()
        {
            return DecelTextBox.Text;
        }

        public Boolean getCCW()
        {
            return CCWRadioButton.Checked;
        }

        public Boolean getCW()
        {
            return CWRadioButton.Checked;
        }

        public String getCue()
        {
            return CueTextBox.Text;
        }

        public String getMotor()
        {
            return MotorTextBox.Text;
        }

        public String getPosition()
        {
            return PositionTextBox.Text;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            submitted = true;
            this.Close();
        }

        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            submitted = true;
            this.Close();
        }
    }
}
