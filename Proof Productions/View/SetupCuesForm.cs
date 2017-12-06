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

        public SetupCueForm()
        {
            InitializeComponent();
            Controller = new SetupCueController();
            refreshCueComboBox();
        }

        /* Inserts a new row after the currently selected row in the motorDataGridView.
         * @param sender
         * @param e 
         * */
        private void insertRowButton_Click(object sender, EventArgs e)
        {
            int rowCount = cueDataGridView.RowCount;
            //rowCount of 1 counts NewRow -> CurrentRow is null because no selected row 
            if (rowCount == 1 || cueDataGridView.CurrentRow.Index == rowCount - 1)
                cueDataGridView.Rows.Add(new DataGridViewRow());
            else
                cueDataGridView.Rows.Insert((cueDataGridView.CurrentCell.RowIndex + 1), new DataGridViewRow());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e) {
            SwitchToForm(new MainMenuForm());
        }

        private void manualControlToolStripMenuItem_Click(object sender, EventArgs e) {
            SwitchToForm(new ManualControlForm());
        }
        
        private void loggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToForm(new LoggerForm());
        }

        private void setupMotorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToForm(new SetupMotorForm());
        }

        private void saveCueButton_Click(object sender, EventArgs e)
        {
            Cue cue = new Cue();

            foreach (DataGridViewRow row in cueDataGridView.Rows)
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
                    else
                    {
                        MessageBox.Show("Invalid Velocity entered.");
                    }

                    if (InputValidator.IsValidAcceleration(accelerationStr))
                    {
                        accel = int.Parse(accelerationStr);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Acceleration entered.");
                    }

                    if (InputValidator.IsValidAcceleration(decelerationStr))
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

        public void refreshCueComboBox()
        {
            //reset combobox and refetch
            //from database to show consistent ordering of items
            cueComboBox.Items.Clear(); 
            DataTable table = Controller.getCueNames();
            int column = 0;
            for(int i = 0; i < table.Rows.Count; i++)
            {
                cueComboBox.Items.Add(table.Rows[i][column].ToString());
            }
        }

        public void refresh(String Name)
        {
            cueDataGridView.DataSource = Controller.getCueItems(Name);
        }

        private void cueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-1 is default index - nothing selected
            if(cueComboBox.SelectedIndex > -1)
            {
                refresh(cueComboBox.Text);
            }
        }

        private void newCueButton_Click(object sender, EventArgs e)
        {
            NewCueForm newCue = new NewCueForm();
            newCue.ShowDialog();
            if(newCue.isSubmitted())
            {
                Controller.addNewCue(newCue.getCueName());
                refreshCueComboBox();
            }
        }

        private void deleteCueButton_Click(object sender, EventArgs e)
        {
            //no cue is selected
            if (cueComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid cue to delete");
            }
            else {
                DialogResult answer = MessageBox.Show("Are you sure you want to delete the selected cue?", "Remove Cue",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    String currentCue = cueComboBox.Text;
                    Controller.deleteCue(currentCue);
                    cueComboBox.SelectedIndex = -1; //set selected text to empty
                    refreshCueComboBox();
               
                }
            }
        }
    }
}
