using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Proof_Productions.Controller;
namespace Proof_Productions.View
{
    public partial class SetupMotorForm : BaseForm
    {
        private SetupMotorController Controller;
        private Boolean hasModifiedSinceLastSave;

        public SetupMotorForm()
        {
            InitializeComponent();
            Controller = new SetupMotorController();
            RefreshData();
        }

        public void RefreshData()
        {
            dataGridView.DataSource = Controller.fetchAllMotors();
            //Make motor name unchangeable for consistency purposes for now
            //The names should pull from the list of motors
            dataGridView.Columns["Name"].ReadOnly = true;
            dataGridView.Columns["Name"].DefaultCellStyle.ForeColor = Color.Gray;
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
            if (NewMotor.IsSubmitted())
            {
                DataTable dt = (DataTable)dataGridView.DataSource;
                DataRow row = dt.NewRow(); ;
                row["Name"] = NewMotor.GetMotorName();
                row["IPAddress"] = NewMotor.GetIPAddress();
                row["Description"] = NewMotor.GetDesc();
                row["PLCName"] = NewMotor.GetPLCName();
                row["LimitMaxVelocity"] = NewMotor.GetMaxVel();
                row["LimitMaxAcceleration"] = NewMotor.GetMaxAccel();
                row["LimitMaxDeceleration"] = NewMotor.GetMaxDecel();
                row["LimitMaxNegPosition"] = NewMotor.GetMaxNegPos();
                row["LimitMaxPosPosition"] = NewMotor.GetMaxPosPos();
                Controller.insertMotor(row);
                RefreshData();
            }
        }

        private void UpdateMotorButton_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure?", "Remove Motor",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                DataRow row = ((DataRowView)dataGridView.CurrentRow.DataBoundItem).Row;
                Controller.updateMotor(row);
                this.RefreshData();
            }
            hasModifiedSinceLastSave = false;
        }

        private void RemoveMotorButton_Click(object sender, EventArgs e)
        {
            //prompt user if they really want to remove the row
            DialogResult answer = MessageBox.Show("Are you sure?", "Remove Motor",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                DataRow row = ((DataRowView)dataGridView.CurrentRow.DataBoundItem).Row;
                Controller.deleteMotor(row, (DataTable)dataGridView.DataSource);
                MessageBox.Show(row["Name"] + " has been deleted");
                RefreshData();
            }
        }

        private void dataGridView_CellContentChanged(object sender, DataGridViewCellEventArgs e)
        {
            hasModifiedSinceLastSave = true;
        }

        private void SetupMotorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hasModifiedSinceLastSave)
            {
                DialogResult answer = MessageBox.Show("You have unsaved changes. Are you sure you want to leave without saving?", "Are you sure?",
                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (answer != DialogResult.OK)
                {
                    e.Cancel = true;
                    FormToOpenNext = null;
                }
            }
        }
    }
}
