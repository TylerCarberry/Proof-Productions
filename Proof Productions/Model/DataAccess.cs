﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Proof_Productions.Model
{
    /* Manages database access for the application, including connections, insert, update, select, and delete functions */
    public class DataAccess
    {
        private readonly Boolean testing = true; //testing purposes only for print statements
        protected static readonly String CONNECTION_STRING = "";
        protected static readonly String SCHEMA_NAME = "caow2";

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;

        /// <summary>
        /// Constructor
        /// </summary>
        public DataAccess()
        {
            adapter = new MySqlDataAdapter();

        }

        /// <summary>
        /// Connects to the database using the set connection string
        /// </summary>
        public void connect()
        {
            con = new MySqlConnection(CONNECTION_STRING);
            con.Open();
            if (testing) Console.WriteLine("Connected to database");
        }

        /// <summary>
        /// Terminates connection to the database
        /// </summary>
        public void disconnect()
        {
            con.Close();
            if (testing) Console.WriteLine("Closed database connection");
        }

        /** TODO - play is unimplemented
        public Boolean insertPlay(Play play)
        {
            try
            {
                
                cmd.CommandText = "INSERT INTO " + SCHEMA_NAME + ".play (Name) VALUES ( @Name )";
                //TODO - once Play is implemented
                //cmd.Parameters.AddWithValue("@Name", play.name);
                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();
                if (testing) Console.WriteLine("Inserted Play");
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
                cmd.CommandText = "INSERT INTO " + SCHEMA_NAME + ".cueitem (CueItemName, DelayBefore, RunTime, SetVelocity, SetAcceleration, SetDeceleration, " +
                                  "SetPosition, PositiveDirection, Running, Stopping, CueID, MotorID)" +
                                  "VALUES (@CueItemName, @DelayBefore, @RunTime, @SetVelocity, @SetAcceleration, @SetDeceleration, @SetPosition, " +
                                  "@PositiveDirection, @Running, @Stopping, @CueID, @MotorID)";
                cmd.Parameters.AddWithValue("@CueItemName", item.Number);
                cmd.Parameters.AddWithValue("@DelayBefore", item.DelayBefore);
                cmd.Parameters.AddWithValue("@RunTime", item.RunTime);
                cmd.Parameters.AddWithValue("@SetVelocity", item.SetVelocity);
                cmd.Parameters.AddWithValue("@SetAcceleration", item.SetAcceleration);
                cmd.Parameters.AddWithValue("@SetDeceleration", item.SetDeceleration);
                cmd.Parameters.AddWithValue("@SetPosition", item.SetPosition);
                cmd.Parameters.AddWithValue("@PositiveDirection", item.PositiveDirection);
                cmd.Parameters.AddWithValue("@Running", item.Running);
                cmd.Parameters.AddWithValue("@Stopping", item.Stopping);
                cmd.Parameters.AddWithValue("@CueName", getCueID(cue));
                cmd.Parameters.AddWithValue("@MotorID", getMotorID(item.CueMotor));
                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();
                if (testing) Console.WriteLine("Inserted CueItem");
            }
            catch (Exception e)
            {
                if (testing) Console.WriteLine("Insert CueItem Failed :" + e.ToString());
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
                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();
                if (testing) Console.WriteLine("Inserted PLC");
            }
            catch (Exception e)
            {
                if (testing) Console.WriteLine("Insert PLC failed: " + e.ToString());
                return false;
            }
            return true;
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

        public int getCueID(Cue cue)
        {
            cmd.CommandText = "SELECT CueID FROM " + SCHEMA_NAME + ".cue WHERE Name = @Name";
            cmd.Parameters.AddWithValue("@Name", cue.Name);
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return (int)table.Rows[0]["CueID"];
        }

        public int getMotorID(Motor motor)
        {
            cmd.CommandText = "SELECT MotorID FROM " + SCHEMA_NAME + ".motor WHERE Name = @Name";
            cmd.Parameters.AddWithValue("@Name", motor.Name);
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return (int)table.Rows[0]["MotorID"];
        }

        public int getPLCID(PLC plc)
        {
            cmd.CommandText = "SELECT PLCID FROM " + SCHEMA_NAME + ".plc WHERE Name = @Name";
            cmd.Parameters.AddWithValue("@Name", plc.Name);
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return (int)table.Rows[0]["PLCID"];
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

        // --------------------------------------------------------------------------------------------------------------------------------------------
        // Functions for SetupMotor Form
        // --------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Get all of the motors from the database
        /// </summary>
        /// <returns> Return all the motors in a DataTable </returns>
        public DataTable getMotors()
        {
            cmd = new MySqlCommand("SELECT Name, IPAddress, Description, PLCName, LimitMaxVelocity, LimitMaxAcceleration, " +
                              "LimitMaxDeceleration, LimitMaxNegPosition, LimitMaxPosPosition FROM " + SCHEMA_NAME + ".motor", con);
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Insert's a Motor's information into the database
        /// </summary>
        /// <param name="motor"> The Motor to be added </param>
        /// <returns> True if Motor information is added successfully, false otherwise</returns>
        public void insertMotor(DataRow row)
        {
            cmd = new MySqlCommand("INSERT INTO " + SCHEMA_NAME + ".motor (IPAddress, Name, Description, PLCName, " +
                              "LimitMaxVelocity, LimitMaxAcceleration, LimitMaxDeceleration, LimitMaxNegPosition, LimitMaxPosPosition) " +
                              "VALUES (@IPAddress, @Name, @Description, @PLCName, " +
                              "@LimitMaxVelocity, @LimitMaxAcceleration, @LimitMaxDeceleration, @LimitMaxNegPosition, @LimitMaxPosPosition)", con);
            cmd.Parameters.AddWithValue("@IPAddress", row["IPAddress"]);
            cmd.Parameters.AddWithValue("@Name", row["Name"]);
            cmd.Parameters.AddWithValue("@Description", row["Description"]);
            cmd.Parameters.AddWithValue("@PLCName", row["PLCName"]);
            cmd.Parameters.AddWithValue("@LimitMaxVelocity", row["LimitMaxVelocity"]);
            cmd.Parameters.AddWithValue("@LimitMaxAcceleration", row["LimitMaxAcceleration"]);
            cmd.Parameters.AddWithValue("@LimitMaxDeceleration", row["LimitMaxDeceleration"]);
            cmd.Parameters.AddWithValue("@LimitMaxNegPosition", row["LimitMaxNegPosition"]);
            cmd.Parameters.AddWithValue("@LimitMaxPosPosition", row["LimitMaxPosPosition"]);
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.ExecuteNonQuery();
            if (testing) Console.WriteLine("Inserted Motor");
        }

        public void updateMotor(DataRow row, DataTable table)
        {
            cmd = new MySqlCommand("UPDATE " + SCHEMA_NAME + ".motor " +
                                "SET IPAddress = @IPAddress, Description = @Description, " +
                                "LimitMaxVelocity = @LimitMaxVelocity, LimitMaxAcceleration = @LimitMaxAcceleration, " +
                                "LimitMaxDeceleration = @LimitMaxDeceleration, LimitMaxNegPosition = @LimitMaxNegPosition, " +
                                "LimitMaxPosPosition = @LimitMaxPosPosition " +
                                "WHERE Name = @Name", con);
            cmd.Parameters.AddWithValue("@IPAddress", row["IPAddress"]);
            cmd.Parameters.AddWithValue("@Description", row["Description"]);
            cmd.Parameters.AddWithValue("@LimitMaxVelocity", row["LimitMaxVelocity"]);
            cmd.Parameters.AddWithValue("@LimitMaxAcceleration", row["LimitMaxAcceleration"]);
            cmd.Parameters.AddWithValue("@LimitMaxDeceleration", row["LimitMaxDeceleration"]);
            cmd.Parameters.AddWithValue("@LimitMaxNegPosition", row["LimitMaxNegPosition"]);
            cmd.Parameters.AddWithValue("@LimitMaxPosPosition", row["LimitMaxPosPosition"]);
            cmd.Parameters.AddWithValue("@Name", row["Name"]);
            adapter.UpdateCommand = cmd;
            adapter.Update(table);
            if (testing) Console.WriteLine("Motor updated");
        }

        public void deleteMotor(DataRow row, DataTable table)
        {
            cmd = new MySqlCommand("DELETE FROM " + SCHEMA_NAME + ".motor " +
                                    "WHERE Name = @Name", con);
            cmd.Parameters.AddWithValue("@Name", row["Name"]);
            adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.ExecuteNonQuery();
            if (testing) Console.WriteLine("Motor Deleted");
        }

        // --------------------------------------------------------------------------------------------------------------------------------------------
        // Database cue table functions
        // --------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable getCueNames()
        {
            cmd = new MySqlCommand("SELECT Name FROM " + SCHEMA_NAME + ".cue", con);
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getCueItems(String CueName)
        {
            cmd = new MySqlCommand("SELECT Number, MotorName 'Motor', DelayBefore 'Start Delay', " +
                                   "Runtime 'Duration', Clockwise, CounterClockwise, " +
                                   "SetVelocity 'Speed', SetAcceleration 'Acceleration', SetDeceleration 'Deceleration' " +
                                   "FROM " + SCHEMA_NAME + ".cueitem WHERE CueName = @CueName", con);
            cmd.Parameters.AddWithValue("@CueName", CueName);
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Inserts a Cue's information into the database 
        /// </summary>
        /// <param name="PlayName"> The name of the play that this cue is associated with </param>
        /// <param name="cue"> The name of this cue </param>
        /// <returns> True if the cue is added into the database, false otherwise </returns>
        public void insertCue(String CueName)
        {
            cmd = new MySqlCommand("INSERT INTO " + SCHEMA_NAME + ".cue (Name) VALUES (@Name )", con);
            cmd.Parameters.AddWithValue("@Name", CueName);
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.ExecuteNonQuery();
            if (testing) Console.WriteLine("Inserted Cue :" + CueName);
        }
    }
}