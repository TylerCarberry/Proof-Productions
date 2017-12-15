using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Proof_Productions.Model
{
    /// <summary>
    /// Manages database access for the application, including connection, insert, update functions, etc.
    /// </summary>
    public class DataAccess
    {
        private readonly Boolean testing = true; //testing purposes only for print statements

        //Database access Strings
        protected static readonly String CONNECTION_STRING = "server = elvis.rowan.edu; user id = caow2; password = doggbert97";
        protected static readonly String SCHEMA_NAME = "caow2";

        MySqlConnection con;
        MySqlDataAdapter adapter;

        /// <summary>
        /// Initializes a DataAccess object
        /// </summary>
        public DataAccess()
        {
            adapter = new MySqlDataAdapter();

        }

        /// <summary>
        /// Connects to the database using the set connection string
        /// </summary>
        public void Connect()
        {
            con = new MySqlConnection(CONNECTION_STRING);
            con.Open();
            if (testing) Console.WriteLine("Connected to database");
        }

        /// <summary>
        /// Terminates connection to the database
        /// </summary>
        public void Disconnect()
        {
            con.Close();
            if (testing) Console.WriteLine("Closed database connection");
        }

        // --------------------------------------------------------------------------------------------------------------------------------------------
        // Functions for SetupMotor Form
        // --------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Get the MotorID primary key associated with this motor's name
        /// </summary>
        /// <param name="motorName"> The specifed motor name </param>
        /// <returns> The corresponding MotorID </returns>
        public int GetMotorID(String motorName)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT MotorID FROM " + SCHEMA_NAME + ".motor WHERE Name = @Name", con);
            cmd.Parameters.AddWithValue("@Name", motorName);
            return Int32.Parse(cmd.ExecuteScalar().ToString());
        }

        /// <summary>
        /// Get the motor's Name associated with this MotorID from the database
        /// </summary>
        /// <param name="MotorID"> The specified MotorID </param>
        /// <returns> The corresponding MotorName </returns>
        public String GetMotorName(int MotorID)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT Name from " + SCHEMA_NAME + ".motor " +
                                   "WHERE MotorID = @MotorID", con);
            cmd.Parameters.AddWithValue("@MotorID", MotorID);
            return cmd.ExecuteScalar().ToString(); //ExecuteScalar returns first row of first column - hence the motor name
        }

        /// <summary>
        /// Get motor information for all motors
        /// </summary>
        /// <returns> Return all motor information in a DataTable </returns>
        public DataTable GetMotors()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT m.Name, IPAddress, Description, p.Name as PLCName, LimitMaxVelocity, LimitMaxAcceleration, " +
                              "LimitMaxDeceleration, LimitMaxNegPosition, LimitMaxPosPosition FROM " + SCHEMA_NAME + ".motor m " +
                              "JOIN " + SCHEMA_NAME + ".plc p USING (PLCID) " +
                              "ORDER BY m.Name ", con);
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        /// <summary>
        /// Insert's a motor's information into the database
        /// </summary>
        /// <param name="row"> The DataRow that contains the motor information </param>
        public void InsertMotor(DataRow row)
        {
            //The 0 is placeholder for the autoincremented ID column
            MySqlCommand cmd = new MySqlCommand("INSERT INTO " + SCHEMA_NAME + ".motor " +
                              "VALUES (0, @Name, @IPAddress, @Description, @PLCID, " +
                              "@LimitMaxVelocity, @LimitMaxAcceleration, @LimitMaxDeceleration, @LimitMaxNegPosition, @LimitMaxPosPosition)", con);
            cmd.Parameters.AddWithValue("@IPAddress", row["IPAddress"]);
            cmd.Parameters.AddWithValue("@Name", row["Name"]);
            cmd.Parameters.AddWithValue("@Description", row["Description"]);
            cmd.Parameters.AddWithValue("@PLCID", getPLCID(row["PLCName"].ToString()));
            cmd.Parameters.AddWithValue("@LimitMaxVelocity", row["LimitMaxVelocity"]);
            cmd.Parameters.AddWithValue("@LimitMaxAcceleration", row["LimitMaxAcceleration"]);
            cmd.Parameters.AddWithValue("@LimitMaxDeceleration", row["LimitMaxDeceleration"]);
            cmd.Parameters.AddWithValue("@LimitMaxNegPosition", row["LimitMaxNegPosition"]);
            cmd.Parameters.AddWithValue("@LimitMaxPosPosition", row["LimitMaxPosPosition"]);
            cmd.ExecuteNonQuery();
            if (testing) Console.WriteLine("Inserted Motor");
        }

        /// <summary>
        /// Updates a motor in the database
        /// 
        /// Note that the motor name cannot be changed since it is used to access the associated MotorID
        /// Name is essentially a 'second' primary key
        /// </summary>
        /// <param name="row"> The DataRow containing the new motor information </param>
        public void IpdateMotor(DataRow row)
        {
            //TODO - PLC changes have not been accounted into this since not much is known about it
            //Therefore, the motor's PLC is currently not updated in the update query
            MySqlCommand cmd = new MySqlCommand("UPDATE " + SCHEMA_NAME + ".motor " +
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
            cmd.ExecuteNonQuery();
            if (testing) Console.WriteLine("Motor updated");
        }

        /// <summary>
        /// Deletes a motor from the database
        /// 
        /// Deleting a motor will delete all associated cue items
        /// </summary>
        /// <param name="row"> The DataRow containing information about the motor to be deleted </param>
        /// <param name="table"></param>
        public void DeleteMotor(DataRow row)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM " + SCHEMA_NAME + ".motor " +
                                   "WHERE Name = @Name", con);
            cmd.Parameters.AddWithValue("@Name", row["Name"]);
            cmd.ExecuteNonQuery();
            if (testing) Console.WriteLine("Motor Deleted");
        }

        // --------------------------------------------------------------------------------------------------------------------------------------------
        // Functions for SetupCue Form
        // --------------------------------------------------------------------------------------------------------------------------------------------
        
        /// <summary>
        /// Retrieve the name and description of all cues
        /// </summary>
        /// <returns> A DataTable containing all cue name and descriptions </returns>
        public DataTable GetCues()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT Name, Description FROM " + SCHEMA_NAME + ".cue", con);
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Get all of the cue items for a specific cue
        /// </summary>
        /// <param name="CueName"> The name fo the specified cue </param>
        /// <returns> A DataTable containing all associated cue item information </returns>
        public DataTable GetCueItems(String CueName)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT Number, ci.Name , m.Name 'Motor', DelayBefore 'Start Delay', " +
                                   "Runtime 'Duration', Clockwise, CounterClockwise, SetVelocity 'Speed', " +
                                   "SetAcceleration 'Acceleration', SetDeceleration 'Deceleration', SetPosition 'Position' " +
                                   "FROM " + SCHEMA_NAME + ".cueitem ci " +
                                   "JOIN " + SCHEMA_NAME + ".cue c USING (CueID) " +
                                   "JOIN " + SCHEMA_NAME + ".motor m USING (MotorID) " +
                                   "WHERE c.name = @CueName " +
                                   "ORDER BY Number ", con);
            cmd.Parameters.AddWithValue("@CueName", CueName);
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Inserts a cue's information into the database 
        /// </summary>
        /// <param name="CueName"> The name for the cue </param>
        /// <param name="Description"> The description for the cue </param>
        public void InsertCue(String CueName, String Description)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO " + SCHEMA_NAME + ".cue (Name, Description) " +
                                                "VALUES (@Name, @Description)", con);
            cmd.Parameters.AddWithValue("@Name", CueName);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.ExecuteNonQuery();
            if (testing) Console.WriteLine("Inserted Cue : " + CueName);
        }

        /// <summary>
        /// Delete a cue from the database
        /// 
        /// Note that deleting a cue will delete all of its associated cue items
        /// </summary>
        /// <param name="CueName"> The name of the cue to be deleted</param>
        public void DeleteCue(String CueName)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM " + SCHEMA_NAME + ".cue WHERE Name = @Name", con);
            cmd.Parameters.AddWithValue("@Name", CueName);
            cmd.ExecuteNonQuery();
            if (testing) Console.WriteLine("Deleted Cue : " + CueName);
        }

        /// <summary>
        /// Gets the CueID primary key for a specified cue
        /// </summary>
        /// <param name="CueName"> The name of the specific cue </param>
        /// <returns> The associated CueID as an int </returns>
        public int GetCueID(String CueName)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT CueID FROM " + SCHEMA_NAME + ".cue WHERE Name = @Name", con);
            cmd.Parameters.AddWithValue("@Name", CueName);
            return (int)cmd.ExecuteScalar();
        }

        /// <summary>
        /// Insert a new cue item into the database
        /// </summary>
        /// <param name="row"> The DataRow containing the cue item's information </param>
        /// <param name="CueName"> The name of the cue that this cue item belongs to </param>
        public void InsertCueItem(DataRow row, String CueName)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO " + SCHEMA_NAME + ".cueitem " +
                              "(Name, Number, DelayBefore, RunTime, SetVelocity, SetAcceleration, " +
                              "SetDeceleration, SetPosition, CounterClockwise, Clockwise, CueID, MotorID)" +
                              "VALUES (@Name, @Number, @DelayBefore, @RunTime, @SetVelocity, @SetAcceleration, @SetDeceleration, " +
                              "@SetPosition, @CounterClockwise, @Clockwise, @CueID, @MotorID)", con);
            cmd.Parameters.AddWithValue("@Name", row["Name"]);
            cmd.Parameters.AddWithValue("@Number", row["Number"]);
            cmd.Parameters.AddWithValue("@DelayBefore", row["Start Delay"]);
            cmd.Parameters.AddWithValue("@RunTime", row["Duration"]);
            cmd.Parameters.AddWithValue("@SetVelocity", row["Speed"]);
            cmd.Parameters.AddWithValue("@SetAcceleration", row["Acceleration"]);
            cmd.Parameters.AddWithValue("@SetDeceleration", row["Deceleration"]);
            cmd.Parameters.AddWithValue("@Clockwise", row["Clockwise"]);
            cmd.Parameters.AddWithValue("@CounterClockwise", row["CounterClockwise"]);
            cmd.Parameters.AddWithValue("@SetPosition", row["Position"]);
            cmd.Parameters.AddWithValue("@CueID", GetCueID(CueName));
            cmd.Parameters.AddWithValue("@MotorID", GetMotorID(row["Motor"].ToString()));

            cmd.ExecuteNonQuery();
            if (testing) Console.WriteLine("Inserted CueItem");
        }

        /// <summary>
        /// Updates a cue item in the database
        /// 
        /// Note that a cue item's name cannot be changed since it is used to access the CueItemID primary key
        /// </summary>
        /// <param name="row"> The DataRow for the updated cue item </param>
        public void UpdateCueItem(DataRow row)
        {
            //Currently doesn't update number
            //CueItem name shall not change - acts as alternate key for the table aside from CueItemID
            //Note: Does not allow user to change the cue this cueitem belongs to - would have to make a new cue
            MySqlCommand cmd = new MySqlCommand("UPDATE " + SCHEMA_NAME + ".cueitem " +
                               "SET Number = @Number, DelayBefore = @DelayBefore, " +
                               "RunTime = @RunTime, SetVelocity = @SetVelocity, " +
                               "SetAcceleration = @SetAcceleration, SetDeceleration = @SetDeceleration, " +
                               "SetPosition = @SetPosition, CounterClockwise = @CounterClockwise, " +
                               "Clockwise = @Clockwise, MotorID = @MotorID " +
                               "WHERE Name = @Name ", con);
            cmd.Parameters.AddWithValue("@Number", row["Number"]);
            cmd.Parameters.AddWithValue("@DelayBefore", row["Start Delay"]);
            cmd.Parameters.AddWithValue("@RunTime", row["Duration"]);
            cmd.Parameters.AddWithValue("@SetVelocity", row["Speed"]);
            cmd.Parameters.AddWithValue("@SetAcceleration", row["Acceleration"]);
            cmd.Parameters.AddWithValue("@SetDeceleration", row["Deceleration"]);
            cmd.Parameters.AddWithValue("@SetPosition", row["Position"]);
            cmd.Parameters.AddWithValue("@CounterClockwise", row["CounterClockwise"]);
            cmd.Parameters.AddWithValue("@Clockwise", row["Clockwise"]);
            cmd.Parameters.AddWithValue("@MotorID", GetMotorID(row["Motor"].ToString()));
            cmd.Parameters.AddWithValue("@Name", row["Name"]);

            cmd.ExecuteNonQuery();
            if (testing) Console.WriteLine("Updated cue item");
        }

        // --------------------------------------------------------------------------------------------------------------------------------------------
        // Functions for MainMenu Form
        // --------------------------------------------------------------------------------------------------------------------------------------------
        
        /// <summary>
        /// Gets all information of a cue item and its motor for a specified cue
        /// </summary>
        /// <param name="CueName"> The name of the specified cue </param>
        /// <returns> A DataTable containing all cue items and motor information </returns>
        public DataTable GetAllFromCueMotor(String CueName)
        {
            //Clockwise is Negative Direction
            MySqlCommand cmd = new MySqlCommand("SELECT c.Name 'CueName', Number, DelayBefore, RunTime, SetVelocity, " +
                                                "SetAcceleration, SetDeceleration, SetPosition, CounterClockwise, " +
                                                "Running, Stopping, m.Name 'MotorName', IPAddress, Description, " +
                                                "LimitMaxVelocity, LimitMaxAcceleration, LimitMaxDeceleration, LimitMaxNegPosition, LimitMaxPosPosition " + 
                                                "FROM " + SCHEMA_NAME + ".cueitem c " +
                                                "JOIN " + SCHEMA_NAME + ".motor m USING (MotorID) " +
                                                "WHERE CueID = @CueID ", con);
            cmd.Parameters.AddWithValue("@CueID", this.GetCueID(CueName));
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;    
        }


        // --------------------------------------------------------------------------------------------------------------------------------------------
        // Functions for plc table - Does not currently belong to a specific form 
        // --------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Get the PLCID primary key for a PLC using the name of a PLC
        /// </summary>
        /// <param name="PLCName"> The name fo the PLC </param>
        /// <returns> The associated PLCID </returns>
        public int getPLCID(String PLCName)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT PLCID FROM " + SCHEMA_NAME + ".plc WHERE Name = @Name", con);
            cmd.Parameters.AddWithValue("@Name", PLCName);
            return (int)cmd.ExecuteScalar();
        }

        /// <summary>
        /// Inserts a new PLC into the associated database
        /// 
        /// Currently unused due to lack of information about a PLC
        /// </summary>
        /// <param name="plc"> The name of the PLC </param>
        public void InsertPLC(PLC plc)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO " + SCHEMA_NAME + ".plc (PLCName) VALUES (@PLCName)",
                                                con);
            cmd.Parameters.AddWithValue("@PLCName", plc.Name);
            cmd.ExecuteNonQuery();
            if (testing) Console.WriteLine("Inserted PLC");
        }
    }
}