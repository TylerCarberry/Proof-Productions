using System;
using System.Drawing;
using System.Text;
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
            if(!ValidateDelay())
            {
                Message.Append("Start Delay\n");
                valid = false;
            }
            if(!ValidateDuration())
            {
                Message.Append("Duration\n");
                valid = false;
            }
            if(!ValidateVelocity())
            {
                Message.Append("Velocity\n");
                valid = false;
            }
            if(!ValidateAcceleration())
            {
                Message.Append("Acceleration\n");
                valid = false;
            }
            if(!ValidateDeceleration())
            {
                Message.Append("Deceleration\n");
                valid = false;
            }
            if(!ValidatePosition())
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

        public bool ValidateDelay()
        {
            double output;
            return DelayTextbox.TextLength > 0 || 
                   (double.TryParse(GetStartDelay(), out output) && output < Double.MaxValue);
        }

        public bool ValidateDuration()
        {
            double output;
            return DurationTextBox.TextLength > 0 || 
                   (double.TryParse(GetDuration(), out output) && output < Double.MaxValue);
        }

        public bool ValidateVelocity()
        {
            if (VelocityTextBox.TextLength == 0 || Int32.Parse(GetVelocity()) > 1750)
                return false;
            return true;
        }

        public bool ValidateAcceleration()
        {
            if (AccelTextBox.TextLength == 0 || Int32.Parse(AccelTextBox.Text) > Int32.MaxValue)
                return false;
            return true;
        }

        public bool ValidateDeceleration()
        {
            if (DecelTextBox.TextLength == 0 || Int32.Parse(DecelTextBox.Text) > Int32.MaxValue)
                return false;
            return true;
        }

        public bool ValidatePosition()
        {
            if (PositionTextBox.TextLength == 0 || Int32.Parse(PositionTextBox.Text) > Int32.MaxValue)
                return false;
            return true;
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

        private void cueItemInputCheck(object sender, EventArgs e)
        {
            foreach (Control tb in this.Controls)
            {
                if (tb is TextBox)
                {
                    TextBox tb1 = (TextBox)tb;
                    tb1.KeyPress += EditKeyPress;
                }
            }
        }

        private void EditKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NumberOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumberOnlyInput(e);
        }

        private void HandleNumberOnlyInput(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
