using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Proof_Productions.Controller;
namespace Proof_Productions.View
{
    /// <summary>
    /// A form for setting up a new motor
    /// </summary>
    public partial class SetupMotorForm : BaseForm
    {
        private SetupMotorController Controller;
        private Boolean Modified;

        /// <summary>
        /// Default constructor
        /// </summary>
        public SetupMotorForm()
        {
            InitializeComponent();
            Controller = new SetupMotorController();
            RefreshData();
        }

        /// <summary>
        /// Fetch motor information using Controller and repopulate the motor grid view
        /// 
        /// Note that motor name should not be changeable
        /// TODO - PLC should be selectable from a ComboBox
        /// </summary>
        public void RefreshData()
        {
            motorGridView.DataSource = Controller.fetchAllMotors();
            motorGridView.Columns["Name"].ReadOnly = true;
            motorGridView.Columns["Name"].DefaultCellStyle.ForeColor = Color.Gray;
        }

        /* The following methods creates a new form when switching
         * TODO - instantiate each of the forms only once and when switching use show and close
         * */
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

        /// <summary>
        /// Add a new motor
        /// Users will be sent to a NewMotorForm to specify information for the new motor
        /// If adding is successful, refresh the motor grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMotorButton_Click(object sender, EventArgs e)
        {
            NewMotorForm NewMotor = new NewMotorForm();
            NewMotor.ShowDialog();
            if (NewMotor.IsSubmitted())
            {
                DataTable dt = (DataTable)motorGridView.DataSource;
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

        /// <summary>
        /// Update the motor in the selected row of the motor grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateMotorButton_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure?", "Remove Motor",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                DataRow row = ((DataRowView)motorGridView.CurrentRow.DataBoundItem).Row;
                Controller.updateMotor(row);
                this.RefreshData();
            }
            Modified = false;
        }

        /// <summary>
        /// Remove a motor 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveMotorButton_Click(object sender, EventArgs e)
        {
            //prompt user if they really want to remove the row
            DialogResult answer = MessageBox.Show("Are you sure?", "Remove Motor",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                DataRow row = ((DataRowView)motorGridView.CurrentRow.DataBoundItem).Row;
                Controller.deleteMotor(row);
                RefreshData();
            }
        }

        /// <summary>
        /// If any cell has been changed, set Modified to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MotorGridView_CellContentChanged(object sender, DataGridViewCellEventArgs e)
        {
            Modified = true;
        }

        /// <summary>
        /// Check if user wants to leave the form if any data has been modified and unsaved
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetupMotorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Modified)
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

        /// <summary>
        /// Add character input check to the numeric columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void motorGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.motorGridView.CurrentCell.ColumnIndex == 4)
            {
                var txtEdit = (TextBox)e.Control;
                txtEdit.KeyPress += EditKeyPress;
            }
        }

        /// <summary>
        /// Only allow numeric inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditKeyPress(object sender, KeyPressEventArgs e)
        {
            //only allowed to input numerals
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Update all of the motors and refresh the motor grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateAllButton_Click(object sender, EventArgs e)
        {
            Controller.updateAllMotor(motorGridView);
            RefreshData();
        }
    }
}
