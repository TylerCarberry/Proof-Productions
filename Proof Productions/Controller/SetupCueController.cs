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
                data.connect();
                cuenames = data.getCueNames();
                data.disconnect();
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
                data.connect();
                cueitems = data.getCueItems(cueName);
                data.disconnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error getting cue items for cue " + cueName + " : \n " + e.ToString());
            }
            return cueitems;
        }

        public void addCue(String cueName)
        {
            try
            {
                data.connect();
                data.insertCue(cueName);
                data.disconnect();
                MessageBox.Show("Cue " + cueName + " has been added");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error adding new cue " + cueName + " : \n" + e.ToString());
            }
        }

        public void deleteCue(String cueName)
        {
            //Deleting a cue will delete its cueitems due to foreign key constraints -- ON DELETE
            try
            {
                data.connect();
                data.deleteCue(cueName);
                data.disconnect();
                MessageBox.Show("Cue " + cueName + " has been deleted");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error deleting cue " + cueName + " : \n" + e.ToString());
            }
        }

        public void addCueItem(DataRow row, String cueName)
        {
            String itemName = row["Name"].ToString();
            try
            {
                data.connect();
                data.insertCueItem(row, cueName);
                data.disconnect();
                MessageBox.Show("Inserted new cue item " + itemName + " cueName");
            }
            catch (Exception e)
            {
                //add more info
                MessageBox.Show("Error inserting cue item " + itemName + " : \n" + e.ToString());
            }
        }

        public void updateCueItem(DataRow row)
        {
            String itemName = row["Name"].ToString();
            try
            {
                data.connect();
                data.UpdateCueItem(row);
                data.disconnect();
                MessageBox.Show("Updated cue item " + itemName);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error updating cue item " + itemName + " : \n " + e.ToString());
            }
        }
    }
}
