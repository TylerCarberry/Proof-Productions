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
    public partial class NewCueForm : Form
    {
        //duplicated variable within new forms
        //TODO - consider abstracting to a superclass if time permits
        private bool submitted = false;  

        public NewCueForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            submitted = true;
            this.Close();
        }

        public bool isSubmitted()
        {
            return submitted;
        }
        public String getCueName()
        {
            return cueNameTextBox.Text;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
