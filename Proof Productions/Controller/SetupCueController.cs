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
            catch(Exception e)
            {
                MessageBox.Show("Error getting cue names : \n" + e.ToString());
            }
            return cuenames;
        }

        public DataTable getCueItems(String CueName)
        {
            DataTable cueitems = null; //placeholder
            try
            {
                data.connect();
                cueitems = data.getCueItems(CueName);
                data.disconnect();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error getting cue items for cue " + CueName + " : \n " + e.ToString());
            }
            return cueitems;
        }

        public void addNewCue(String CueName)
        {
            try
            {
                data.connect();
                data.insertCue(CueName);
                data.disconnect();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error adding new cue " + CueName + " : \n" + e.ToString()); 
            }
            MessageBox.Show("Cue " + CueName + " has been added");
        }

        public void deleteCue(String CueName)
        {
            //TODO - can't just delete cue - must delete cueitems associated with cue too
            try
            {
                data.connect();
                data.deleteCue(CueName);
                data.disconnect();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error deleting cue " + CueName + " : \n" + e.ToString());
            }
            MessageBox.Show("Cue " + CueName + " has been deleted");
        }
    }
}
