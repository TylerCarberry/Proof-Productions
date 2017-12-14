using Proof_Productions.Controller;
using Proof_Productions.Model;
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
    public partial class SetupCueForm : BaseForm
    {
        private SetupCueController Controller;
        private Boolean hasModifiedSinceLastSave;

        public SetupCueForm()
        {
            InitializeComponent();
            Controller = new SetupCueController();
            RefreshCueComboBox();
        }

        public string getCurrentCue()
        {
            return cueComboBox.Text;
        }

        /* Inserts a new row after the currently selected row in the motorDataGridView.
         * @param sender
         * @param e 
         * */
        private void InsertRowButton_Click(object sender, EventArgs e)
        {
            int rowCount = cueDataGridView.RowCount;
            //rowCount of 1 counts NewRow -> CurrentRow is null because no selected row 
            if (rowCount == 1 || cueDataGridView.CurrentRow.Index == rowCount - 1)
                cueDataGridView.Rows.Add(new DataGridViewRow());
            else
                cueDataGridView.Rows.Insert((cueDataGridView.CurrentCell.RowIndex + 1), new DataGridViewRow());
        }
        
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) {
            new AboutForm().Show();
        }

        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e) {
            SwitchToForm(new MainMenuForm());
        }

        private void ManualControlToolStripMenuItem_Click(object sender, EventArgs e) {
            SwitchToForm(new ManualControlForm());
        }
        
        private void LoggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoggerForm().Show();
        }

        private void SetupMotorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToForm(new SetupMotorForm());
        }

        /** Prompt user if they want to remove a row. If yes, Removes the currently selected row,
         *  or does nothing if there is no row to remove.
         *  @param sender
         *  @param e
         * */
        private void DeleteCueItemButton_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure?", "Remove Cue",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                //if nothing has ever been added to table - CurrentRow is null
                if (cueDataGridView.CurrentRow == null || cueDataGridView.CurrentRow.IsNewRow)
                    return;
                else
                {
                    int rowIndex = cueDataGridView.CurrentRow.Index;
                    if (rowIndex < cueDataGridView.Rows.Count)
                    {
                        cueDataGridView.Rows.RemoveAt(rowIndex);
                        // TODO: Also remove the CueItem from the Cue
                    }
                }

            }
        }

        public void RefreshCueComboBox()
        {
            //reset combobox and refetch
            //from database to show consistent ordering of items
            cueComboBox.Items.Clear();
            DataTable table = Controller.getCueNames();
            int column = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cueComboBox.Items.Add(table.Rows[i][column].ToString());
            }
        }

        public void RefreshCueItemGrid(String Name)
        {
            cueDataGridView.DataSource = Controller.getCueItems(Name);
            cueDataGridView.Columns["Name"].ReadOnly = true;
            cueDataGridView.Columns["Name"].DefaultCellStyle.ForeColor = Color.Gray;
        }

        private void CueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-1 is default index - nothing selected
            if (cueComboBox.SelectedIndex > -1)
            {
                RefreshCueItemGrid(this.getCurrentCue());
            }
        }

        private void NewCueButton_Click(object sender, EventArgs e)
        {
            NewCueForm newCue = new NewCueForm();
            newCue.ShowDialog();
            if (newCue.isSubmitted())
            {
                Controller.addCue(newCue.getCueName());
                RefreshCueComboBox();
            }
        }

        private void DeleteCueButton_Click(object sender, EventArgs e)
        {
            //no cue is selected
            if (cueComboBox.SelectedIndex == -1)
                MessageBox.Show("Please select a valid cue to delete");
            else
            {
                DialogResult answer = MessageBox.Show("Are you sure?", "Remove Cue",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    String currentCue = cueComboBox.Text;
                    Controller.deleteCue(currentCue);
                    cueComboBox.SelectedIndex = -1; //set selected text to empty
                    RefreshCueComboBox();

                }
            }
        }

        private void AddCueItemButton_Click(object sender, EventArgs e)
        {
            if (cueComboBox.SelectedIndex == -1)
                MessageBox.Show("Please select or make a new Cue before adding a Cue Item");
            else
            {
                //a cue has been selected already
                NewCueItemForm Item = new NewCueItemForm(this);
                Item.ShowDialog();
                if (Item.IsSubmitted())
                {
                    DataTable dt = (DataTable)cueDataGridView.DataSource;
                    DataRow row = dt.NewRow();
                    row["Name"] = Item.GetCueItemName();
                    row["Number"] = Item.GetCueItemNumber();
                    row["Motor"] = Item.GetMotor();
                    row["Start Delay"] = Item.GetStartDelay();
                    row["Duration"] = Item.GetDuration();
                    row["Clockwise"] = Item.GetCW();
                    row["CounterClockwise"] = Item.GetCCW();
                    row["Speed"] = Item.GetVelocity();
                    row["Acceleration"] = Item.GetAccel();
                    row["Deceleration"] = Item.GetDecel();
                    row["Position"] = Item.GetPosition();
                    Controller.addCueItem(row, this.getCurrentCue());
                    RefreshCueItemGrid(this.getCurrentCue());
                }
            }
        }

        private void UpdateCueItemButton_Click(object sender, EventArgs e)
        {
            if (cueComboBox.SelectedIndex == -1)
                MessageBox.Show("Please select a cue and a cue item to update");
            else
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to update the selected cue item?",
                                    "Remove Cue", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    DataRow row = ((DataRowView)cueDataGridView.CurrentRow.DataBoundItem).Row;
                    Controller.updateCueItem(row);
                    RefreshCueItemGrid(this.getCurrentCue());

                    hasModifiedSinceLastSave = false;
                }
            }
        }

        private void SetupCuesForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cueDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                int rowIndex = e.RowIndex;
                int currentCollumnIndex = e.ColumnIndex;
                int coorespondingIndex = currentCollumnIndex == 5 ? 6 : 5;

                Object value = cueDataGridView.Rows[e.RowIndex].Cells[currentCollumnIndex].Value;

                if (value.Equals(true))
                {
                    cueDataGridView.Rows[rowIndex].Cells[coorespondingIndex].Value = false;
                } else
                {
                    cueDataGridView.Rows[rowIndex].Cells[coorespondingIndex].Value = true;
                }
            }
            hasModifiedSinceLastSave = true;


            hasModifiedSinceLastSave = true;
        }

        private void myDataGrid_OnCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // End of edition on each click on column of checkbox
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                cueDataGridView.EndEdit();
            }
        }

        private void cueDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cueDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void cueDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //only apply character input check to non-name columns
            if (this.cueDataGridView.CurrentCell.ColumnIndex == 3)
            {
                var txtEdit = (TextBox)e.Control;
                txtEdit.KeyPress += EditKeyPress;
            }
        }

        private void EditKeyPress(object sender, KeyPressEventArgs e)
        {
            //only allowed to input numerals
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
