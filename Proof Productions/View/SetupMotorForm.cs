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
    public partial class SetupMotorForm : BaseForm
    {

        private SetupMotorController Controller;

        public SetupMotorForm()
        {
            InitializeComponent();
            Controller = new SetupMotorController();
            RefreshData();
        }

        public void RefreshData()
        {

            dataGridView1.DataSource = Controller.fetchAllMotors();
            //Make motor name unchangeable for consistency purposes for now
            //The names should pull from the list of motors
            dataGridView1.Columns["Name"].ReadOnly = true;
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e) {
            SwitchToForm(new MainMenuForm());
        }

        private void ManualControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToForm(new ManualControlForm());
        }

        private void SetupCuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToForm(new SetupCueForm());
        }

        private void LoggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoggerForm().Show();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        private void AddMotorButton_Click(object sender, EventArgs e)
        {
            NewMotorForm NewMotor = new NewMotorForm();
            NewMotor.ShowDialog();
            if(NewMotor.IsSubmitted())
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
                RefreshData();
            }
        }

        private void UpdateMotorButton_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;
            Controller.updateMotor(row, (DataTable)dataGridView1.DataSource);
            MessageBox.Show(row["Name"] + " has been updated");
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
                MessageBox.Show(row["Name"] + " has been deleted");
                RefreshData();
            }
        }

        private void SetupMotorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
