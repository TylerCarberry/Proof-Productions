﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proof_Productions.Model
{
    /* Manages database access for the application, including connections, insert, update, select, and delete functions */
    public class DataAccess
    {
        private readonly Boolean testing = true; //testing purposes only for print statements

        //TODO - need to get corresponding ConnectionString for con
        protected static readonly String CONNECTION_STRING = "";
        protected static readonly String SCHEMA_NAME = "proof_productions";

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;

        /// <summary>
        /// Constructor
        /// </summary>
        public DataAccess()
        {
            cmd = new MySqlCommand();
            adapter = new MySqlDataAdapter();
        }

        /// <summary>
        /// Connects to the database using the set connection string
        /// </summary>
        /// <returns> True if the connection is successful, false otherwise </returns>
        public Boolean connect()
        {
            try
            {
                con = new MySqlConnection(CONNECTION_STRING);
                con.Open();
                cmd.Connection = con;
                if (testing) Console.WriteLine("Connected to database");
            }
            catch (Exception e)
            {
                if (testing) Console.WriteLine("Connection to database failed due to " + e.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Terminates the connection with the associated database
        /// </summary>
        /// <returns> True if database disconnects successfully, false otherwise </returns>
        public Boolean disconnect()
        {
            try
            {
                con.Close();
                if (testing) Console.WriteLine("Closed database connection");
            }
            catch (Exception e)
            {
                if (testing) Console.WriteLine("Connection to database could not be close due to " + e.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Inserts a Cue's information into the database 
        /// </summary>
        /// <param name="PlayName"> The name of the play that this cue is associated with </param>
        /// <param name="cue"> The name of this cue </param>
        /// <returns> True if the cue is added into the database, false otherwise </returns>
        public Boolean insertCue(String playName, Cue cue)
        {
            try
            {
                cmd.CommandText = "INSERT INTO " + SCHEMA_NAME + ".cue (PlayName, CueName) VALUES (@PlayName, @CueName )";
                //TODO - once Play is implemented
                //cmd.Parameters.AddWithValue("@PlayName", playName);
                cmd.Parameters.AddWithValue("@CueName", cue.Name);
            }
            catch (Exception e)
            {
                if (testing) Console.WriteLine("Insert Cue Failed: " + e.ToString());
                return false;
            }
            return true;
        }

        /** TODO - play is unimplemented
        public Boolean insertPlay(Play play)
        {
            try
            {
                connect();
                cmd.CommandText = "INSERT INTO " + SCHEMA_NAME + ".play (Name) VALUES ( @Name )";
                //TODO - once Play is implemented
                //cmd.Parameters.AddWithValue("@Name", play.name);
                disconnect();
            }
            catch (Exception e)
            {
                if(testing) Console.WriteLine("Insert Play Failed: " + e.ToString());
                return false;
            }
            return true;
        }
        */



        /// <summary>
        /// Inserts a CueItem's information into the database 
        /// </summary>
        /// <param name="item"> The CueItem to be added </param>
        /// <param name="cue"> The Cue this CueItem is associated with </param>
        /// <returns> True if the CueItem is added into the database, false otherwise </returns>
        public Boolean insertCueItem(CueItem item, Cue cue)
        {
            try
            {
                cmd.CommandText = "INSERT INTO " + SCHEMA_NAME + ".cueitem (CueItemName, DelayBefore, RunTime, SetVelocity, SetAcceleration, SetDeceleration, SetPosition, CueName)" +
                                  "VALUES (@CueItemName, @DelayBefore, @RunTime, @SetVelocity, @SetAcceleration, @SetDeceleration, @SetPosition, @CueName)";
                cmd.Parameters.AddWithValue("@CueItemName", item.Name);
                cmd.Parameters.AddWithValue("@DelayBefore", item.DelayBefore);
                cmd.Parameters.AddWithValue("@RunTime", item.RunTime);
                cmd.Parameters.AddWithValue("@SetVelocity", item.SetVelocity);
                cmd.Parameters.AddWithValue("@SetAcceleration", item.SetAcceleration);
                cmd.Parameters.AddWithValue("@SetDeceleration", item.SetDeceleration);
                cmd.Parameters.AddWithValue("@SetPosition", item.SetPosition);
                cmd.Parameters.AddWithValue("@CueName", cue.Name);
            }
            catch (Exception e)
            {
                if (testing) Console.WriteLine("Insert CueItem Failed :" + e.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Insert's a Motor's information into the database
        /// </summary>
        /// <param name="motor"> The Motor to be added </param>
        /// <returns> True if Motor information is added successfully, false otherwise</returns>
        public Boolean insertMotor(Motor motor)
        {
            try
            {
                cmd.CommandText = "INSERT INTO " + SCHEMA_NAME + ".motor (IPAddress, Name, Description, PLCName, " +
                                   "LimitMaxVelocity, LimitMaxAcceleration, LimitMaxDeceleration, LimitMaxNegPosition, LimitMaxPosPosition) " +
                                  "VALUES (@IPAddress, @Name, @Description, @PLCName, " +
                                  "@LimitMaxVelocity, @LimitMaxAcceleration, @LimitMaxDeceleration, @LimitMaxNegPosition, @LimitMaxPosPosition)";
                cmd.Parameters.AddWithValue("@IPAddress", motor.IPAddress);
                cmd.Parameters.AddWithValue("@Name", motor.Name);
                cmd.Parameters.AddWithValue("@Description", motor.Description);
                cmd.Parameters.AddWithValue("@PLCName", motor.ConnectedPLC.Name);
                cmd.Parameters.AddWithValue("@LimitMaxVelocity", motor.LimitMaxVelocity);
                cmd.Parameters.AddWithValue("@LimitMaxAcceleration", motor.LimitMaxAcceleration);
                cmd.Parameters.AddWithValue("@LimitMaxDeceleration", motor.LimitMaxDeceleration);
                cmd.Parameters.AddWithValue("@LimitMaxNegPosition", motor.LimitMaxNegPosition);
                cmd.Parameters.AddWithValue("@LimitMaxPosPosition", motor.LimitMaxPosPosition);
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
                cmd.CommandText = "INSERT INTO " + SCHEMA_NAME + ".cueitemmotor (CueItemName, MotorName) " +
                                  "VALUES (@CueItemName, @MotorName)";
                cmd.Parameters.AddWithValue("@CueItemName", item.Name);
                cmd.Parameters.AddWithValue("@MotorName", motor.Name);
            }
            catch (Exception e)
            {
                if (testing) Console.WriteLine("Insert CueItemMotor failed: " + e.ToString());
                return false;
            }
            return true;
        }

        public Boolean insertPLC(PLC plc)
        {
            try
            {
                cmd.CommandText = "INSERT INTO " + SCHEMA_NAME + ".plc (PLCName) VALUES (@PLCName)";
                cmd.Parameters.AddWithValue("@PLCName", plc.Name);
            }
            catch (Exception e)
            {
                if (testing) Console.WriteLine("Insert PLC failed: " + e.ToString());
                return false;
            }
            return true;
        }

        public Boolean insertRotationalMotor()
        {
            //TODO - method stub - currently unimplemented
            return true;
        }


        public DataTable getPlays()
        {
            //TODO - method stub 
            return new DataTable();
        }

        public DataTable getCueNames()
        {
            cmd.CommandText = "SELECT CueName FROM " + SCHEMA_NAME + ".cue";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getMotors()
        {
            cmd.CommandText = "SELECT IPAddress, Name, Description, PLCName, LimitMaxVelocity, LimitMaxAcceleration, " +
                              "LimitMaxDeceleration, LimitMaxNegPosition, LimitMaxPosPosition FROM " + SCHEMA_NAME + ".motor";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable selectMotor(Motor motor)
        {
            cmd.CommandText = "SELECT IPAddress, Name, Description, PLCName, LimitMaxVelocity, LimitMaxAcceleration, " +
                                                "LimitMaxDeceleration, LimitMaxNegPosition, LimitMaxPosPosition FROM " + SCHEMA_NAME + ".motor " +
                                                "WHERE Name = @Name";
            cmd.Parameters.AddWithValue("@Name", motor.Name);
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Gets all the CueItems for the specified Cue
        /// </summary>
        /// <param name="cue"> The specified Cue </param>
        /// <returns> A DataTable with all of the CueItems for a Cue</returns>
        public DataTable getCueItemsForCue(Cue cue)
        {
            cmd.CommandText = "SELECT CueItemName, DelayBefore, RunTime, SetVelocity, SetAcceleration, SetDeceleration, SetPosition " +
                              "FROM " + SCHEMA_NAME + ".cueitem JOIN " + SCHEMA_NAME + ".cue USING (@CueName)";
            cmd.Parameters.AddWithValue("@CueName", cue.Name);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}