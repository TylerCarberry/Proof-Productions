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


        public bool isSubmitted()
        {
            return submitted;
        }

        public String getMotorName()
        {
            return NameTextBox.Text;
        }

        public String getIPAddress()
        {
            return IPAddressTextBox.Text;
        }

        public String getDesc()
        {
            return DescTextBox.Text;
        }

        public String getPLCName()
        {
            return PLCNameTextBox.Text;
        }

        public String getMaxVel()
        {
            return MaxVelTextBox.Text;
        }

        public String getMaxAccel()
        {
            return MaxAccelTextBox.Text;
        }

        public String getMaxDecel()
        {
            return MaxDecelTextBox.Text;
        }

        public String getMaxNegPos()
        {
            return MaxNegPosTextBox.Text;
        }

        public String getMaxPosPos()
        {
            return MaxPosPosTextBox.Text;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
