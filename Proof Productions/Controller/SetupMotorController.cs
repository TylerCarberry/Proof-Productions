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
    public class SetupMotorController
    {
        private DataAccess data;

        public SetupMotorController()
        {
            data = new DataAccess();
        }

        //Get all of the motors
        public DataTable fetchAllMotors()
        {
            DataTable motortable = null; //null is placeholder - May cause null exception
                                         //if somehow reaches bottom of method w/o going into trycatch
            try
            {
                data.connect();
                motortable = data.getMotors();
                data.disconnect();
            }
            catch(Exception e)
            {
                MessageBox.Show("Could not fetch motors due to : \n " + e.ToString());
            }
            return motortable;
        }

        public void updateMotor(DataRow row, DataTable table)
        {
            try
            {
                data.connect();
                data.updateMotor(row, table);
                data.disconnect();
            }
            catch(Exception e)
            {
                MessageBox.Show(row["Name"] + " could not be added due to : /n " + e.ToString());
            }
        }

        public void insertMotor(DataRow row)
        {
            try
            {
                data.connect();
                data.insertMotor(row);
                data.disconnect();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void deleteMotor(DataRow row, DataTable table)
        {
            try
            {
                data.connect();
                data.deleteMotor(row, table);
                data.disconnect();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
