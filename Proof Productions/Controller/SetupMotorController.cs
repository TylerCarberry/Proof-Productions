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
                data.Connect();
                motortable = data.getMotors();
                data.Disconnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error getting motors due to : \n " + e.ToString());
            }
            return motortable;
        }

        public void updateAllMotor(DataGridView view)
        {
            try
            {
                data.Connect();
                foreach (DataGridViewRow dgvRow in view.Rows)
                {
                    DataRow Row = ((DataRowView)dgvRow.DataBoundItem).Row;
                    data.updateMotor(Row);
                }
                data.Disconnect();
                MessageBox.Show("All motors have been updated");
            }
            catch(Exception e)
            {
                MessageBox.Show("Error updating motors : \n" + e.ToString());
            }
         }
         

        public void updateMotor(DataRow row)
        {
            String motorName = row["Name"].ToString();
            try
            {
                data.Connect();
                data.updateMotor(row);
                data.Disconnect(); 
                MessageBox.Show(motorName + " has been updated");
            }
            catch(Exception e)
            {
                MessageBox.Show("Error updating " +motorName + " due to : /n " + e.ToString());
            }
        }

        public void insertMotor(DataRow row)
        {
            String motorName = row["Name"].ToString();
            try
            {
                data.Connect();
                data.insertMotor(row);
                data.Disconnect();
                MessageBox.Show(motorName + " has been added");
            }
            catch(Exception e)
            {
                MessageBox.Show("Error adding " + motorName + " due to : \n " + e.ToString());
            }
        }

        public void deleteMotor(DataRow row, DataTable table)
        {
            String motorName = row["Name"].ToString();
            try
            {
                data.Connect();
                data.deleteMotor(row, table);
                data.Disconnect();
                MessageBox.Show(motorName + " has been deleted");
            }
            catch(Exception e)
            {
                MessageBox.Show("Error deleting " + motorName + " due to : \n " + e.ToString());
            }
        }
    }
}
