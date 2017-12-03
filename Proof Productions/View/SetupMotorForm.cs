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
using Proof_Productions.Controller;
namespace Proof_Productions.View
{
    public partial class SetupMotorForm : Form
    {

        private SetupMotorController Controller;
        public SetupMotorForm()
        {
            InitializeComponent();
            Controller = new SetupMotorController();
            Controller.fetchAllMotors();
            refresh();
        }

        public void refresh()
        {
            //TODO-ON THIS
            DataTable dt = new DataTable();
            foreach (Motor m in Controller.motors.Values)
            {
                foreach(DataGridViewTextBoxColumn Column in dataGridView1.Columns)
                {
                    dt.Columns.Add(Column.ToString());
                }
                DataRow row = dt.NewRow();
                for(int i = 0; i < m.dataRow().Length; i++)
                {
                    row[0] = m.dataRow()[i]; //row starts at index 1
                }
                dt.Rows.Add(row);
            }
            dataGridView1.DataSource = dt;
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
