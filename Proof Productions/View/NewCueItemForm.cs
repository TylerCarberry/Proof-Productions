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
            if (validInputs())
            {
                submitted = true;
                this.Close();
            }
        }

        private bool validInputs()
        {
            //TODO - changing valid is repetitive - find some way to abstract it to an outer if block
            bool valid = true;
            StringBuilder Message = new StringBuilder("The following inputs are invalid: \n");

            if (!validateName())
            {
                Message.Append("Cue Item Name\n");
                valid = false;
            }
            if(!validateCueItemNumber())
            {
                Message.Append("Cue Item Number\n");
                valid = false;
            }
            if(!validateDelay())
            {
                Message.Append("Start Delay\n");
                valid = false;
            }
            if(!validateDuration())
            {
                Message.Append("Duration\n");
                valid = false;
            }
            if(!validateVelocity())
            {
                Message.Append("Velocity\n");
                valid = false;
            }
            if(!validateAcceleration())
            {
                Message.Append("Acceleration\n");
                valid = false;
            }
            if(!validateDeceleration())
            {
                Message.Append("Deceleration\n");
                valid = false;
            }
            if(!validatePosition())
            {
                Message.Append("Position\n");
                valid = false;
            }

            if (!valid) MessageBox.Show(Message.ToString());
            return valid;
        }

        public bool validateName()
        {
            return NameTextBox.TextLength > 0;
        }

        public bool validateCueItemNumber()
        {
            return CueItemNumberTextBox.TextLength > 0;
        }

        public bool validateDelay()
        {
            double output;
            return DelayTextbox.TextLength > 0 || double.TryParse(GetStartDelay(), out output);
        }

        public bool validateDuration()
        {
            double output;
            return DurationTextBox.TextLength > 0 || double.TryParse(GetDuration(), out output);
        }

        public bool validateVelocity()
        {
            if (VelocityTextBox.TextLength == 0) return false;
            else if (GetVelocity().Equals("") || Int32.Parse(GetVelocity()) > 1750) return false;
            return true;
        }

        public bool validateAcceleration()
        {
            return AccelTextBox.TextLength > 0;
        }

        public bool validateDeceleration()
        {
            return DecelTextBox.TextLength > 0;
        }

        public bool validatePosition()
        {
            return PositionTextBox.TextLength > 0;
        }

        private void CueItemNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            //makes sure that only digits are entered
            //if any non digits are inputted - reset text
            if (System.Text.RegularExpressions.Regex.IsMatch(CueItemNumberTextBox.Text, "[^0-9]"))
            {
                if(CueItemNumberTextBox.TextLength > 0)
                    MessageBox.Show("Please enter only numbers.");
                CueItemNumberTextBox.Clear();
            }
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DelayTextbox_TextChanged(object sender, EventArgs e)
        {
            //Currently only checks integers and periods
            //TODO - Try to check as a double as users are inputting it
            if (System.Text.RegularExpressions.Regex.IsMatch(DelayTextbox.Text, "[^0-9\\.]"))
            {
                if (DelayTextbox.TextLength > 0)
                    MessageBox.Show("Please enter only numbers.");
                DelayTextbox.Clear();
            }
        }
    }
}
