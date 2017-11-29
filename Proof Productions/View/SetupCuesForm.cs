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
    public partial class SetupCueForm : Form
    {
        public SetupCueForm()
        {
            InitializeComponent();
        }

        private void cueSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dirComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void spdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void accelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void detailedViewTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int temp = motorDataGridView.CurrentCellAddress.X;

            if (motorDataGridView.CurrentCellAddress.X != 6)
            {
                // Not the delete button
                return;
            }

            DialogResult answer = MessageBox.Show("Are you sure?", "Remove Cue",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                //if nothing has ever been added to table - CurrentRow is null
                if (motorDataGridView.CurrentRow == null || motorDataGridView.CurrentRow.IsNewRow)
                    return;
                else
                {
                    int rowIndex = motorDataGridView.CurrentRow.Index;
                    if (rowIndex < motorDataGridView.Rows.Count)
                        motorDataGridView.Rows.RemoveAt(rowIndex);
                    //TODO - should we remove anything if we're selecting NewRow?
                }
            }
        }

        /* Inserts a new row after the currently selected row in the motorDataGridView.
         * @param sender
         * @param e 
         * */
        private void insertRowButton_Click(object sender, EventArgs e)
        {
            int rowCount = motorDataGridView.RowCount;
            //rowCount of 1 counts NewRow -> CurrentRow is null because no selected row 
            if (rowCount == 1 || motorDataGridView.CurrentRow.Index == rowCount - 1)
                motorDataGridView.Rows.Add(new DataGridViewRow());
            else
                motorDataGridView.Rows.Insert((motorDataGridView.CurrentCell.RowIndex + 1), new DataGridViewRow());
        }

        /** Prompt user if they want to remove a row. If yes, Removes the currently selected row,
         *  or does nothing if there is no row to remove.
         *  @param sender
         *  @param e
         * */
        private void removeRowButton_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            new AboutForm().Show();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e) {
            switchToForm(new MainMenuForm());
        }

        private void manualControlToolStripMenuItem_Click(object sender, EventArgs e) {
            switchToForm(new ManualControlForm());
        }

        private void switchToForm(Form form) {
            form.Show();
            form.Left = this.Left;
            form.Top = this.Top;

            this.Hide();
        }

        private void loggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchToForm(new LoggerForm());
        }

        private void setupMotorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchToForm(new SetupMotorForm());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveCueButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in motorDataGridView.Rows)
            {
                String name = row.Cells[0].Value.ToString();
                String motor = row.Cells[0].Value.ToString();
                Boolean clockwise = row.Cells[0].Value.ToString().Equals("true");
                String speed = row.Cells[0].Value.ToString();
                String acceleratoin = row.Cells[0].Value.ToString();
                String deceleration = row.Cells[0].Value.ToString();

                // TODO For Tom
                /*
                if (InputValidator.IsValid(speed)
                {

                }
                else show a dialog
                */

                // TODO For Tom: Convert string to double

                //CueItem cueItem = new CueItem(0, 1000, null, speed, acceleration, deceleration, clockwise, 0);

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure?", "Remove Cue",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                //if nothing has ever been added to table - CurrentRow is null
                if (motorDataGridView.CurrentRow == null || motorDataGridView.CurrentRow.IsNewRow)
                    return;
                else
                {
                    int rowIndex = motorDataGridView.CurrentRow.Index;
                    if (rowIndex < motorDataGridView.Rows.Count)
                        motorDataGridView.Rows.RemoveAt(rowIndex);
                    //TODO - should we remove anything if we're selecting NewRow?
                }
            }
        }
    }
}
