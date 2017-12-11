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
            submitted = true;
            this.Close();
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
    }
}
