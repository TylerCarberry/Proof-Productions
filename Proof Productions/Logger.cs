using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proof_Productions
{
    public partial class LoggerForm : Form
    {
        public LoggerForm()
        {
            InitializeComponent();
        }

        private void displayErrorButton_Click(object sender, EventArgs e)
        {

        }

        private void displayLogButton_Click(object sender, EventArgs e)
        {

        }

        private void logLocationButton_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void switchToForm(Form form)
        {
            form.Show();
            form.Left = this.Left;
            form.Top = this.Top;

            this.Hide();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchToForm(new MainMenuForm());
        }

        private void setupMotorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchToForm(new SetupMotorForm());
        }

        private void manualControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchToForm(new ManualControlForm());
        }

        private void setupCuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchToForm(new SetupCueForm());
        }

        private void loggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO - Do we even need this? Already at Logger page
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }
    }
}
