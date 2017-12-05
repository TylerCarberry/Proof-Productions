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
            data.connect();
            DataTable motortable = data.getMotors();
            data.disconnect();
            return motortable;
        }

        public void update(DataRow row, DataTable d)
        {
            try
            {
                data.connect();
                data.updateMotor(row, d);
                data.disconnect();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
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
    }
}
