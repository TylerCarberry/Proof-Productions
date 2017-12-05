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
            //TODO-ON THIS - works but adds columns to current table
            dataGridView1.DataSource = Controller.fetchAllMotors();
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

        private void AddMotorButton_Click(object sender, EventArgs e)
        {
            NewMotorForm NewMotor = new NewMotorForm();
            NewMotor.ShowDialog();
            if(NewMotor.IsSubmitted())
            {
                DataRow row = AddNewRow();
                row["Name"] = NewMotor.getMotorName();
                row["IPAddress"] = NewMotor.getIPAddress();
                row["Description"] = NewMotor.getDesc();
                row["PLCName"] = NewMotor.getPLCName();
                row["LimitMaxVelocity"] = NewMotor.getMaxVel();
                row["LimitMaxAcceleration"] = NewMotor.getMaxAccel();
                row["LimitMaxDeceleration"] = NewMotor.getMaxDecel();
                row["LimitMaxNegPosition"] = NewMotor.getMaxNegPos();
                row["LimitMaxPosPosition"] = NewMotor.getMaxPosPos();
            }
        }

        private DataRow AddNewRow()
        {
            int rowCount = dataGridView1.RowCount;
            //when table is bound to a data source we can't add explicitly to datagridview
            DataTable dt = (DataTable)dataGridView1.DataSource;
            DataRow row = dt.NewRow();
            //rowCount of 1 counts NewRow -> CurrentRow is null because no selected row 
            if (rowCount == 1 || dataGridView1.CurrentRow.Index == rowCount - 1)
                dt.Rows.Add(row);
            else
                dt.Rows.InsertAt(row, dataGridView1.CurrentCell.RowIndex + 1);
            return row;
        }

        private void RemoveRow()
        {
            DialogResult answer = MessageBox.Show("Are you sure?", "Remove Motor",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                //if nothing has ever been added to table - CurrentRow is null
                if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                    return;
                else
                {
                    int rowIndex = dataGridView1.CurrentRow.Index;
                    if (rowIndex < dataGridView1.Rows.Count)
                    {
                        dataGridView1.Rows.RemoveAt(rowIndex);
                    }
                }
            }
        }

        private void UpdateMotorButton_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;
            Controller.update(row, (DataTable)dataGridView1.DataSource);
            MessageBox.Show(row["Name"] + " has been updated");
        }

        private void RemoveMotorButton_Click(object sender, EventArgs e)
        {
            RemoveRow();
        }
    }
}
