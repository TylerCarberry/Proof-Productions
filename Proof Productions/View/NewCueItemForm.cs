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

        public bool IsSubmitted()
        {
            return submitted;
        }

        public String GetCueItemName()
        {
            return NameTextBox.Text;
        }

        public String GetCueItemNumber()
        {
            return CueItemNumberTextBox.Text;

        }

        public String GetStartDelay()
        {
            return DelayTextbox.Text;
        }

        public String GetDuration()
        {
            return DurationTextBox.Text;
        }

        public String GetVelocity()
        {
            return VelocityTextBox.Text;
        }

        public String GetAccel()
        {
            return AccelTextBox.Text;
        }

        public String GetDecel()
        {
            return DecelTextBox.Text;
        }

        public Boolean GetCCW()
        {
            return CCWRadioButton.Checked;
        }

        public Boolean GetCW()
        {
            return CWRadioButton.Checked;
        }

        public String GetCue()
        {
            return CueTextBox.Text;
        }

        public String GetMotor()
        {
            return MotorTextBox.Text;
        }

        public String GetPosition()
        {
            return PositionTextBox.Text;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            submitted = true;
            this.Close();
        }
    }
}
