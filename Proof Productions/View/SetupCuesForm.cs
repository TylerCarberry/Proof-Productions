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
        public SetupCueForm()
        {
            InitializeComponent();
        }

        /* Inserts a new row after the currently selected row in the motorDataGridView.
         * @param sender
         * @param e 
         * */
        private void InsertRowButton_Click(object sender, EventArgs e)
        {
            int rowCount = motorDataGridView.RowCount;
            //rowCount of 1 counts NewRow -> CurrentRow is null because no selected row 
            if (rowCount == 1 || motorDataGridView.CurrentRow.Index == rowCount - 1)
                motorDataGridView.Rows.Add(new DataGridViewRow());
            else
                motorDataGridView.Rows.Insert((motorDataGridView.CurrentCell.RowIndex + 1), new DataGridViewRow());
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

        private void SaveCueButton_Click(object sender, EventArgs e)
        {
            Cue cue = new Cue();

            foreach(DataGridViewRow row in motorDataGridView.Rows)
            {

                try
                {
                    String name = row.Cells[0].Value.ToString();
                    String motorStr = row.Cells[1].Value.ToString();
                    String startDelayStr = row.Cells[2].Value.ToString();
                    String durationStr = row.Cells[3].Value.ToString();
                    Boolean clockwise = row.Cells[4].Value.ToString().Equals("true");
                    String speedStr = row.Cells[5].Value.ToString();
                    String accelerationStr = row.Cells[6].Value.ToString();
                    String decelerationStr = row.Cells[7].Value.ToString();

                    int speed = 0;
                    int accel = 0;
                    int decel = 0;

                    if (InputValidator.IsValidVelocity(speedStr))
                    {
                        speed = int.Parse(speedStr);
                    }
                    else{
                        MessageBox.Show("Invalid Velocity entered.");
                    }

                    if(InputValidator.IsValidAcceleration(accelerationStr))
                    {
                        accel = int.Parse(accelerationStr);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Acceleration entered.");
                    }

                    if(InputValidator.IsValidAcceleration(decelerationStr))
                    {
                        decel = int.Parse(decelerationStr);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Deceleration entered.");
                    }

                    int startDelay = int.Parse(startDelayStr);
                    int duration = int.Parse(durationStr);

                    // TODO: Don't hardcode the IP address or description
                    Motor motor = new Motor("192.168.10.4", name, "This is the main motor for controlling the curtain", new PLC());

                    CueItem cueItem = new CueItem(startDelay, duration, motor, speed, accel, decel, clockwise, 0);
                    cue.Add(cueItem);
                }
                catch (NullReferenceException exception)
                {
                    // TODO For Tom, show a dialog
                    return;
                }

               
                

                

            }

            // TODO Save cueItems to the database
        }

        /** Prompt user if they want to remove a row. If yes, Removes the currently selected row,
         *  or does nothing if there is no row to remove.
         *  @param sender
         *  @param e
         * */
        private void deleteCueItemButton_Click(object sender, EventArgs e)
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
                    {
                        motorDataGridView.Rows.RemoveAt(rowIndex);
                        // TODO: Also remove the CueItem from the Cue
                    }  
                }

            }
        }
    }
}
