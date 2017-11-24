using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proof_Productions.Model
{
    public class DBHandler
    {
        private readonly Boolean testing = true; //testing purposes only for print statements

        //TODO - need to get corresponding ConnectionString for con
        protected static readonly String CONNECTION_STRING = ""; //constant
        protected static readonly String SCHEMA_NAME = "proof_productions";
        MySqlConnection con;
        MySqlCommand cmd;

        public DBHandler()
        {
            con = new MySqlConnection();
            cmd = con.CreateCommand();
        }

        public Boolean connect()
        {
            try
            {
                con.ConnectionString = CONNECTION_STRING;
                con.Open();
                Console.WriteLine("Connected to database");
            }
            catch (Exception e)
            {
                if (testing) Console.WriteLine("Connection to database failed due to " + e.ToString());
                return false;
            }
            return true;
        }

        //Makeshift for now to show proof of concept
        //TODO - may want to find a way to abstract insert methods?
        public Boolean insertCue(int PlayID)
        {
            try
            {
                cmd.CommandText = "INSERT INTO " + SCHEMA_NAME + ".cue (PlayID) VALUES ( @PlayID )";
                //TODO - once Play is implemented
                //cmd.Parameters.AddWithValue("@PlayID", PlayID);
            }
            catch (Exception e)
            {
                if (testing) Console.WriteLine("Insert Cue Failed: " + e.ToString());
                return false;
            }
            return true;
        }

        /**
        public Boolean insertPlay(Play play)
        {
            try
            {
                cmd.CommandText = "INSERT INTO " + SCHEMA_NAME + ".play (Name) VALUES ( @Name )";
                //TODO - once Play is implemented
                //cmd.Parameters.AddWithValue("@Name", play.name);
            }
            catch (Exception e)
            {
                if(testing) Console.WriteLine("Insert Play Failed: " + e.ToString());
                return false;
            }
            return true;
        }
        */

        public Boolean insertCueItem(CueItem item, int CueID)
        {
            try
            {
                cmd.CommandText = "INSERT INTO " + SCHEMA_NAME + ".cueitem (DelayBefore, RunTime, SetVelocity, SetAcceleration, SetDeceleration, SetPosition, CueID)" +
                                  "VALUES (@DelayBefore, @RunTime, @SetVelocity, @SetAcceleration, @SetDeceleration, @SetPosition, @CueID)";
                cmd.Parameters.AddWithValue("@DelayBefore", item.DelayBefore);
                cmd.Parameters.AddWithValue("@RunTime", item.RunTime);
                cmd.Parameters.AddWithValue("@SetVelocity", item.SetVelocity);
                cmd.Parameters.AddWithValue("@SetAcceleration", item.SetAcceleration);
                cmd.Parameters.AddWithValue("@SetDeceleration", item.SetDeceleration);
                cmd.Parameters.AddWithValue("@SetPosition", item.SetPosition);
                cmd.Parameters.AddWithValue("@CueID", CueID);
            }
            catch (Exception e)
            {
                if (testing) Console.WriteLine("Insert CueItem Failed :" + e.ToString());
                return false;
            }
            return true;
        }

        public Boolean insertMotor(Motor motor)
        {
            try
            {
                cmd.CommandText = "INSERT INTO " + SCHEMA_NAME + ".motor (@IPAddress, @Name, @Description, @PLCID) " +
                                  "VALUES (@IPAddress, @Name, @Description, @PLCID)";
                cmd.Parameters.AddWithValue("@IPAddress", motor.IPAddress);
                cmd.Parameters.AddWithValue("@Name", motor.Name);
                cmd.Parameters.AddWithValue("@Description", motor.Description);
                /**TODO - need query to get PLCID from database to add it in
                   int PLCID = this.getPLC(motor.ConnectedPLC);
                   cmd.Parameters.AddWithValue("@PLCID", motor.ConnectedPLC);
                */
            }
            catch (Exception e)
            {
                if (testing) Console.WriteLine("Insert motor failed: " + e.ToString());
                return false;
            }
            return true;
        }

        public Boolean insertCueItemMotor(CueItem item, Motor motor)
        {
            try
            {
                cmd.CommandText = "INSERT INTO " + SCHEMA_NAME + ".cueitemmotor (CueItemID,MotorID) " +
                                  "VALUES (@CueItemID, @MotorID)";
                /** TODO - need query to get CueItemID and motorID from database
                cmd.Parameters.AddWithValue("@CueItemID", )
                cmd.Parameters.AddWithValue("@MotorID", );
                */
            }
            catch (Exception e)
            {
                if (testing) Console.WriteLine("Insert CueItemMotor failed: " + e.ToString());
                return false;
            }
            return true;
        }

        /**TODO - might need to have a collection of limits so a motor can just pass in and method will loop through all of the motors */
        public Boolean insertLimit(Motor motor)
        {
            try
            {
                cmd.CommandText = "INSERT INTO " + SCHEMA_NAME + ".limit (LimitType, MotorID, LimitValue) " +
                                  "VALUES (@LimitType, MotorID, LimitValue)";
                //Unfinished
            }
            catch (Exception e)
            {
                if (testing) Console.WriteLine("Insert limit failed: " + e.ToString());
                return false;
            }
            return true;
        }

        public Boolean insertPLC(PLC plc)
        {
            try
            {
                //PLC class isn't finished so currently adds just an auto-incremented value
                cmd.CommandText = "INSERT INTO " + SCHEMA_NAME + ".plc VALUES ()";
            }
            catch (Exception e)
            {
                if (testing) Console.WriteLine("Insert PLC failed: " + e.ToString());
                return false;
            }
            return true;
        }

        /** TODO - can't implement this yet as no way to distinguish subclasses
        public Boolean insertRotationalMotor()
        */
    }
}

