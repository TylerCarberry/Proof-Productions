using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proof_Productions.Model;

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
            if (!validateName())
            {
                Message.Append("Motor Name \n");
                valid = false;
            }
            if(! validateIP())
            {
                Message.Append("IP Address \n");
                valid = false;
            }
            if(! validateVelocity())
            {
                Message.Append("Max Velocity \n");
                valid = false;
            }
            if(! validateAcceleration())
            {
                Message.Append("Max Acceleration \n");
                valid = false;
            }
            if (!validateDeceleration())
            {
                Message.Append("Max Deceleration \n");
                valid = false;
            }
            if (!validateNegPosition())
            {
                Message.Append("Max Negative Position \n");
                valid = false;
            }
            if (!validatePosPosition())
            {
                Message.Append("Max Positive Position \n");
                valid = false;
            }

            if (!valid) MessageBox.Show(Message.ToString());
            return valid;
        }

        public bool validateName()
        {
            return NameTextBox.TextLength > 0;
        }

        public bool validateIP()
        {
            return IPAddressTextBox.TextLength > 0;
        }

        public bool validateVelocity()
        {
            if (MaxVelTextBox.TextLength == 0 || Int32.Parse(MaxVelTextBox.Text) > 1750)
                return false;
            return true;
        }

        public bool validateAcceleration()
        {
            if (MaxAccelTextBox.TextLength == 0 || Int32.Parse(MaxAccelTextBox.Text) > Int32.MaxValue)
                return false;
            return true;
        }

        public bool validateDeceleration()
        {
            if (MaxDecelTextBox.TextLength == 0 || Int32.Parse(MaxDecelTextBox.Text) > Int32.MaxValue)
                return false;
            return true;
        }

        public bool validateNegPosition()
        {
            if (MaxNegPosTextBox.TextLength == 0 || Int32.Parse(MaxNegPosTextBox.Text) > Int32.MaxValue)
                return false;
            return true;
        }

        public bool validatePosPosition()
        {
            if (MaxPosPosTextBox.TextLength == 0 || Int32.Parse(MaxPosPosTextBox.Text) > Int32.MaxValue)
                return false;
            return true;
        }
    }
}
