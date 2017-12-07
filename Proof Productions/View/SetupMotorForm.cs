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
            refresh();
        }

        public void refresh()
        {

            dataGridView1.DataSource = Controller.fetchAllMotors();
            //Make motor name unchangeable for consistency purposes for now
            //The names should pull from the list of motors
            dataGridView1.Columns["Name"].ReadOnly = true;
            dataGridView1.Columns["Name"].DefaultCellStyle.ForeColor = Color.Gray;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void AddMotorButton_Click(object sender, EventArgs e)
        {
            NewMotorForm NewMotor = new NewMotorForm();
            NewMotor.ShowDialog();
            if (NewMotor.isSubmitted())
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                DataRow row = dt.NewRow(); ;
                row["Name"] = NewMotor.getMotorName();
                row["IPAddress"] = NewMotor.getIPAddress();
                row["Description"] = NewMotor.getDesc();
                row["PLCName"] = NewMotor.getPLCName();
                row["LimitMaxVelocity"] = NewMotor.getMaxVel();
                row["LimitMaxAcceleration"] = NewMotor.getMaxAccel();
                row["LimitMaxDeceleration"] = NewMotor.getMaxDecel();
                row["LimitMaxNegPosition"] = NewMotor.getMaxNegPos();
                row["LimitMaxPosPosition"] = NewMotor.getMaxPosPos();
                Controller.insertMotor(row);
                refresh();
            }
        }

        private void UpdateMotorButton_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure?", "Remove Motor",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                DataRow row = ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;
                Controller.updateMotor(row);
            }
        }

        private void RemoveMotorButton_Click(object sender, EventArgs e)
        {
            //prompt user if they really want to remove the row
            DialogResult answer = MessageBox.Show("Are you sure?", "Remove Motor",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                DataRow row = ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;
                Controller.deleteMotor(row, (DataTable)dataGridView1.DataSource);
                refresh();
            }
        }
    }
}
