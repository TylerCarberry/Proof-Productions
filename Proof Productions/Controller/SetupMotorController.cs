using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proof_Productions.Model;
using System.Data;

namespace Proof_Productions.Controller
{
    public class SetupMotorController
    {
        private DataAccess data;
        public Dictionary<String,Motor> motors;

        public SetupMotorController()
        {
            data = new DataAccess();
            motors = new Dictionary<string, Motor>();
        }

        //Get all of the motors
        public void fetchAllMotors()
        {
            data.connect();
            DataTable motortable = data.getMotors();
            foreach (DataRow row in motortable.Rows)
            {
                //remember to set limits too or pass it into motor from the datarow
                Motor m = new Motor(row["IPAddress"].ToString(), row["Name"].ToString(), 
                                    row["Description"].ToString(), new PLC());
                m.LimitMaxAcceleration = Int32.Parse(row["LimitMaxAcceleration"].ToString());
                m.LimitMaxDeceleration = Int32.Parse(row["LimitMaxDeceleration"].ToString());
                m.LimitMaxNegPosition = Int32.Parse(row["LimitMaxNegPosition"].ToString());
                m.LimitMaxPosPosition = Int32.Parse(row["LimitMaxNegPosition"].ToString());
                m.LimitMaxVelocity = Int32.Parse(row["LimitMaxVelocity"].ToString());
                motors.Add(m.Name, m);
            }
        }
    }
}
