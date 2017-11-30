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
    public partial class SetupMotorForm : Form
    {
        public SetupMotorForm()
        {
            InitializeComponent();
            /**TODO - testing purposes
            DataAccess da = new DataAccess();
            da.connect();
            dataGridView1.DataSource = da.getMotors();
            da.disconnect();
            */
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e) {
            switchToForm(new MainMenuForm());
        }

        private void switchToForm(Form form)
        {
            form.Show();
            form.Left = this.Left;
            form.Top = this.Top;

            this.Hide();
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
            switchToForm(new LoggerForm());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }
    }
}
