using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proof_Productions.Model;
using System.Data;
using System.Windows.Forms;

namespace Proof_Productions.Controller
{
    public class SetupCueController
    {
        DataAccess data;

        public SetupCueController()
        {
            data = new DataAccess();
        }

        public DataTable getCueNames()
        {
            DataTable cuenames = null; //placeholder
            try
            {
                data.Connect();
                cuenames = data.getCues();
                data.Disconnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error getting cue names : \n" + e.ToString());
            }
            return cuenames;
        }

        public DataTable getCueItems(String cueName)
        {
            DataTable cueitems = null; //placeholder
            try
            {
                data.Connect();
                cueitems = data.getCueItems(cueName);
                data.Disconnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error getting cue items for cue " + cueName + " : \n " + e.ToString());
            }
            return cueitems;
        }

        public void addCue(String cueName, String Description)
        {
            try
            {
                data.Connect();
                data.insertCue(cueName, Description);
                data.Disconnect();
                MessageBox.Show("Cue '" + cueName + "' has been added");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error adding new cue '" + cueName + "' : \n" + e.ToString());
            }
        }

        public void deleteCue(String cueName)
        {
            //Deleting a cue will delete its cueitems due to foreign key constraints -- ON DELETE
            try
            {
                data.Connect();
                data.deleteCue(cueName);
                data.Disconnect();
                MessageBox.Show("Cue '" + cueName + "' has been deleted");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error deleting cue '" + cueName + "' : \n" + e.ToString());
            }
        }

        public void addCueItem(DataRow row, String cueName)
        {
            String itemName = row["Name"].ToString();
            try
            {
                data.Connect();
                data.insertCueItem(row, cueName);
                data.Disconnect();
                MessageBox.Show("Inserted new cue item '" + itemName + "' into Cue '" + cueName + "'");
            }
            catch (Exception e)
            {
                //add more info
                MessageBox.Show("Error inserting cue item '" + itemName + "' : \n" + e.ToString());
            }
        }

        public void updateCueItem(DataRow row)
        {
            String itemName = row["Name"].ToString();
            try
            {
                data.Connect();
                data.UpdateCueItem(row);
                data.Disconnect();
                MessageBox.Show("Updated cue item '" + itemName + "'");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error updating cue item '" + itemName + "' : \n " + e.ToString());
            }
        }

        public void updateAllCueItem(DataGridView view)
        {
            try
            {
                data.Connect();
                foreach (DataGridViewRow dgvRow in view.Rows)
                {
                    DataRow Row = ((DataRowView)dgvRow.DataBoundItem).Row;
                    data.UpdateCueItem(Row);
                }
                data.Disconnect();
                MessageBox.Show("All cue items have been updated for the current cue");
            }
            catch(Exception e)
            {
                MessageBox.Show("Error updating all cue items : \n" + e.ToString());
            }
        }
    }
}
