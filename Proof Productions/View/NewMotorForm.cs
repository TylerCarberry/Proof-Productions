using System;
using System.Text;
using System.Windows.Forms;

namespace Proof_Productions.View
{
    public partial class NewMotorForm : Form
    {
        protected bool submitted = false;

        public NewMotorForm()
        {
            InitializeComponent();
        }

        public void SubmitButton_Click(object sender, EventArgs e)
        {
            if (validInputs())
            {
                submitted = true;
                this.Close();
            }
        }

        public bool IsSubmitted()
        {
            return submitted;
        }

        public String GetMotorName()
        {
            return NameTextBox.Text;
        }

        public String GetIPAddress()
        {
            return IPAddressTextBox.Text;
        }

        public String GetDesc()
        {
            return DescTextBox.Text;
        }

        public String GetPLCName()
        {
            return PLCNameTextBox.Text;
        }

        public String GetMaxVel()
        {
            return MaxVelTextBox.Text;
        }

        public String GetMaxAccel()
        {
            return MaxAccelTextBox.Text;
        }

        public String GetMaxDecel()
        {
            return MaxDecelTextBox.Text;
        }

        public String GetMaxNegPos()
        {
            return MaxNegPosTextBox.Text;
        }

        public String GetMaxPosPos()
        {
            return MaxPosPosTextBox.Text;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaxVelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MaxAccelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MaxDecelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool validInputs()
        {
            bool valid = true;
            StringBuilder Message = new StringBuilder("The following inputs are invalid: \n");
            if (!ValidateName())
            {
                Message.Append("Motor Name \n");
                valid = false;
            }
            if(! ValidateIP())
            {
                Message.Append("IP Address \n");
                valid = false;
            }
            if(! ValidateVelocity())
            {
                Message.Append("Max Velocity \n");
                valid = false;
            }
            if(! ValidateAcceleration())
            {
                Message.Append("Max Acceleration \n");
                valid = false;
            }
            if (!ValidateDeceleration())
            {
                Message.Append("Max Deceleration \n");
                valid = false;
            }
            if (!ValidateNegPosition())
            {
                Message.Append("Max Negative Position \n");
                valid = false;
            }
            if (!ValidatePosPosition())
            {
                Message.Append("Max Positive Position \n");
                valid = false;
            }

            if (!valid) MessageBox.Show(Message.ToString());
            return valid;
        }

        public bool ValidateName()
        {
            return NameTextBox.TextLength > 0;
        }

        public bool ValidateIP()
        {
            return IPAddressTextBox.TextLength > 0;
        }

        public bool ValidateVelocity()
        {
            if (MaxVelTextBox.TextLength == 0 || Int32.Parse(MaxVelTextBox.Text) > 1750)
                return false;
            return true;
        }

        public bool ValidateAcceleration()
        {
            if (MaxAccelTextBox.TextLength == 0 || Int32.Parse(MaxAccelTextBox.Text) > Int32.MaxValue)
                return false;
            return true;
        }

        public bool ValidateDeceleration()
        {
            if (MaxDecelTextBox.TextLength == 0 || Int32.Parse(MaxDecelTextBox.Text) > Int32.MaxValue)
                return false;
            return true;
        }

        public bool ValidateNegPosition()
        {
            if (MaxNegPosTextBox.TextLength == 0 || Int32.Parse(MaxNegPosTextBox.Text) > Int32.MaxValue)
                return false;
            return true;
        }

        public bool ValidatePosPosition()
        {
            if (MaxPosPosTextBox.TextLength == 0 || Int32.Parse(MaxPosPosTextBox.Text) > Int32.MaxValue)
                return false;
            return true;
        }
    }
}
