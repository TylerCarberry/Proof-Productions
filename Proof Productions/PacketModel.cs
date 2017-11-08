using System;
using System.Collections.Generic;
using System.Text;
using ModbusTCP;
using static System.Net.Mime.MediaTypeNames;

namespace PacketModel
{

    class FieldbusInputData
    {

        public ControlWord_I1 Control_I1 { get; set; }
        public BinaryOutputs_I2 BinaryOut_I2 { get; set; }
        public ControlWord_I3 Control_I3 { get; set; }
        public SetpointVelocity SetpointVelocity { get; set; }       //Should this be of type SetpointVelocity?
        public Acceleration Acceleration { get; set; }
        public Deceleration Deceleration { get; set; }
        public SetpointPosition Setpoint_Position { get; set; }
        public SubcontrolWord Subcontrol { get; set; }
        public BinaryOutputs_I10 BinaryOut_I10 { get; set; }
        public SetpointValue2 SetpointValue { get; set; }
        //data[0] = 0; //byte 0 of Control 1
        //data[1] = 0; //byte 1 of Control 1
        //data[2] = 0; //byte 0 of Binary Outputs
        //data[3] = 0;  //byte 1 of Binary Outputs
        //data[4] = 10;  //byte 0 of Control 3
        //data[5] = 6;   //byte 1 of Control 3
        //data[6] = BitConverter.GetBytes(velocity)[1];  // byte 1 of Velocity
        //data[7] = BitConverter.GetBytes(velocity)[0];  // byte 0 of velocity
        //data[8] = BitConverter.GetBytes(acceleration)[1];  // byte 1 of Velocity
        //data[9] = BitConverter.GetBytes(acceleration)[0];  // byte 0 of velocity
        //data[10] = 0;

        public byte[] GetValue
        {
            get
            {
                byte[] bytes = new byte[20];
                //when we return the setpoint velocity, acceleration and deceleration
                //make sure you swap the bytes
                bytes[0] = BitConverter.GetBytes(Control_I1.GetSetValue)[0];
                bytes[1] = BitConverter.GetBytes(Control_I1.GetSetValue)[1];
                bytes[2] = BitConverter.GetBytes(BinaryOut_I2.GetSetValue)[0];
                bytes[3] = BitConverter.GetBytes(BinaryOut_I2.GetSetValue)[1];
                bytes[4] = BitConverter.GetBytes(Control_I3.GetSetValue)[0];
                bytes[5] = BitConverter.GetBytes(Control_I3.GetSetValue)[1];
                bytes[6] = BitConverter.GetBytes(SetpointVelocity.GetSetValue)[1];
                bytes[7] = BitConverter.GetBytes(SetpointVelocity.GetSetValue)[0];
                bytes[8] = BitConverter.GetBytes(Acceleration.GetSetValue)[1];
                bytes[9] = BitConverter.GetBytes(Acceleration.GetSetValue)[0];
                bytes[10] = BitConverter.GetBytes(Deceleration.GetSetValue)[1];
                bytes[11] = BitConverter.GetBytes(Deceleration.GetSetValue)[0];
                bytes[12] = BitConverter.GetBytes(Setpoint_Position.GetSetValue)[1];
                bytes[13] = BitConverter.GetBytes(Setpoint_Position.GetSetValue)[0];
                bytes[14] = BitConverter.GetBytes(Subcontrol.GetSetValue)[0];
                bytes[15] = BitConverter.GetBytes(Subcontrol.GetSetValue)[1];
                bytes[16] = BitConverter.GetBytes(BinaryOut_I10.GetSetValue)[0];
                bytes[18] = BitConverter.GetBytes(BinaryOut_I10.GetSetValue)[1];
                bytes[19] = BitConverter.GetBytes(SetpointValue.GetSetValue)[1];
                bytes[20] = BitConverter.GetBytes(SetpointValue.GetSetValue)[0];
                //TODO - Continue this for the remainder of the data
                return bytes;
            }
        }

    }

    class FieldbusOutputData
    {
        public StatusWord_O1 Status_O1 { get; set; }
        public BinaryInputs_O2 Binary_O2 { get; set; }
        public StatusWordO3 Status_O3 { get; set; }
        public ActualVelocity ActualVelocity { get; set; }
        public OutputCurrent OutputCurrent { get; set; }
        public Reversed Reversed { get; set; }
        public Actual_Position Actual_Position { get; set; }
        public SubStatusWord substatusWord { get; set; }
        public BinaryInputs_O10 BinaryInputs_O10 { get; set; }
        public ActualValue_02 actualValue2 { get; set; }

        public byte[] GetValue
        {
            get
            {
                byte[] bytes = new byte[12];
                //when we return the setpoint velocity, acceleration and deceleration
                //make sure you swap the bytes
                bytes[0] = BitConverter.GetBytes(Status_O1.GetSetValue)[0];
                bytes[1] = BitConverter.GetBytes(Status_O1.GetSetValue)[1];
                bytes[2] = BitConverter.GetBytes(Binary_O2.GetSetValue)[0];
                bytes[3] = BitConverter.GetBytes(Binary_O2.GetSetValue)[1];
                bytes[4] = BitConverter.GetBytes(Status_O3.GetSetValue)[0];
                bytes[5] = BitConverter.GetBytes(Status_O3.GetSetValue)[1];
                bytes[6] = BitConverter.GetBytes(ActualVelocity.GetSetValue)[1];
                bytes[7] = BitConverter.GetBytes(ActualVelocity.GetSetValue)[0];
                bytes[8] = BitConverter.GetBytes(OutputCurrent.GetSetValue)[1];
                bytes[9] = BitConverter.GetBytes(OutputCurrent.GetSetValue)[0];
                bytes[10] = BitConverter.GetBytes(Reversed.GetSetValue)[1];
                bytes[11] = BitConverter.GetBytes(Reversed.GetSetValue)[0];
                bytes[12] = BitConverter.GetBytes(Actual_Position.GetSetValue)[1];
                bytes[13] = BitConverter.GetBytes(Actual_Position.GetSetValue)[0];
                bytes[14] = BitConverter.GetBytes(substatusWord.GetSetValue)[0];
                bytes[15] = BitConverter.GetBytes(substatusWord.GetSetValue)[1];
                bytes[16] = BitConverter.GetBytes(BinaryInputs_O10.GetSetValue)[0];
                bytes[18] = BitConverter.GetBytes(BinaryInputs_O10.GetSetValue)[1];
                bytes[19] = BitConverter.GetBytes(actualValue2.GetSetValue)[1];
                bytes[20] = BitConverter.GetBytes(actualValue2.GetSetValue)[0];
                //bytes[6] = BitConverter.GetBytes(ActualVelocity.GetSetValue)[0];
                //TODO - Continue this for the remainder of the data
                return bytes;
            }
        }
    }



    //This Class belongs in a separate class file - overarching Control Class 
    
    
    
    

    class StatusWord_O1
    {
        public bool Maintenance_switch { get; set; }
        public bool Toggle { get; set; }
        public bool Bit02 { get; set; }
        public bool UserBit { get; set; }
        public bool Dataset_exists { get; set; }
        public bool Autoreload_config { get; set; }
        public bool Warning { get; set; }
        public bool Error { get; set; }

        public StatusWord_O1()
        {

        }

        public int GetSetValue
        {
            get
            {
                return (2^0 * (Maintenance_switch ? 1 : 0)) | (2^1 * (Toggle ? 1 : 0)
                        | (2^2 * (Bit02 ? 1 : 0)) | (2^3 * (UserBit ? 1 : 0))
                        | (2^4 * (Dataset_exists ? 1 : 0)) | (2^5 * (Autoreload_config ? 1 : 0))
                        | (2^6 * (Warning ? 1 : 0)) | (2^7 * (Error ? 1 : 0)));
            }
            set
            {
                Maintenance_switch = (value & 2^0).Equals(1);
                Toggle = (value & 2^1).Equals(1);
                Bit02 = (value & 2^2).Equals(1);
                UserBit = (value & 2^3).Equals(1);
                Dataset_exists = (value & 2^4).Equals(1);
                Autoreload_config = (value & 2^5).Equals(1);
                Warning = (value & 2^6).Equals(1);
                Error = (value & 2^7).Equals(1);
            }
        }
    }

    class BinaryInputs_O2
    {
        public bool DI00 { get; set; }
        public bool DI01 { get; set; }
        public bool DI02 { get; set; }
        public bool DI03 { get; set; }
        public bool DI04 { get; set; }
        public bool DI05 { get; set; }
        public bool DI06 { get; set; }
        public bool DI07 { get; set; }
        public bool DI08 { get; set; }
        public bool DI09 { get; set; }
        public bool DI10 { get; set; }
        public bool DI11 { get; set; }
        public bool DI12 { get; set; }
        public bool DI13 { get; set; }
        public bool DI14 { get; set; }
        public bool DI15 { get; set; }

        public BinaryInputs_O2()
        {

        }

        public int GetSetValue
        {
            get
            {
                return (2^0 * (DI00 ? 1 : 0)) | (2^1 * (DI01 ? 1 : 0)
                        | (2^2 * (DI02 ? 1 : 0)) | (2^3 * (DI03 ? 1 : 0))
                        | (2^4 * (DI04 ? 1 : 0)) | (2^5 * (DI05 ? 1 : 0))
                        | (2^6 * (DI06 ? 1 : 0)) | (2^7 * (DI07 ? 1 : 0))
                        | (2^8 * (DI08 ? 1 : 0)) | (2^9 * (DI09 ? 1 : 0))
                        | (2^10 * (DI10 ? 1 : 0)) | (2^11 * (DI11 ? 1 : 0))
                        | (2^12 * (DI12 ? 1 : 0)) | (2^13 * (DI13 ? 1 : 0))
                        | (2^14 * (DI14 ? 1 : 0)) | (2^15 * (DI15 ? 1 : 0)));
            }
            set
            {
                DI00 = (value & 2^0).Equals(1);
                DI01 = (value & 2^1).Equals(1);
                DI02 = (value & 2^2).Equals(1);
                DI03 = (value & 2^3).Equals(1);
                DI04 = (value & 2^4).Equals(1);
                DI05 = (value & 2^5).Equals(1);
                DI06 = (value & 2^6).Equals(1);
                DI07 = (value & 2^7).Equals(1);
                DI08 = (value & 2^8).Equals(1);
                DI09 = (value & 2^9).Equals(1);
                DI10 = (value & 2^10).Equals(1);
                DI11 = (value & 2^11).Equals(1);
                DI12 = (value & 2^12).Equals(1);
                DI13 = (value & 2^13).Equals(1);
                DI14 = (value & 2^14).Equals(1);
                DI15 = (value & 2^15).Equals(1);
            }
        }
    }

    

    
    

    

    class BinaryInputs_O10
    {
        public bool DI00 { get; set; }
        public bool DI01 { get; set; }
        public bool DI02 { get; set; }
        public bool DI03 { get; set; }
        public bool DI04 { get; set; }
        public bool DI05 { get; set; }
        public bool DI06 { get; set; }
        public bool DI07 { get; set; }
        public bool DI10 { get; set; }
        public bool DI11 { get; set; }
        public bool DI12 { get; set; }
        public bool DI13 { get; set; }
        public bool DI14 { get; set; }
        public bool DI15 { get; set; }
        public bool DI16 { get; set; }
        public bool DI17 { get; set; }

        public BinaryInputs_O10()
        {

        }

        public int GetSetValue
        {
            get
            {
                return (2^0 * (DI00 ? 1 : 0)) | (2^1 * (DI01 ? 1 : 0)
                        | (2^2 * (DI02 ? 1 : 0)) | (2^3 * (DI03 ? 1 : 0))
                        | (2^4 * (DI04 ? 1 : 0)) | (2^5 * (DI05 ? 1 : 0))
                        | (2^6 * (DI06 ? 1 : 0)) | (2^7 * (DI07 ? 1 : 0))
                        | (2^8 * (DI10 ? 1 : 0)) | (2^9 * (DI11 ? 1 : 0))
                        | (2^10 * (DI12 ? 1 : 0)) | (2^11 * (DI13 ? 1 : 0))
                        | (2^12 * (DI14 ? 1 : 0)) | (2^13 * (DI15 ? 1 : 0))
                        | (2^14 * (DI16 ? 1 : 0)) | (2^15 * (DI17 ? 1 : 0)));
            }
            set
            {
                DI00 = (value & 2^0).Equals(1);
                DI01 = (value & 2^1).Equals(1);
                DI02 = (value & 2^2).Equals(1);
                DI03 = (value & 2^3).Equals(1);
                DI04 = (value & 2^4).Equals(1);
                DI05 = (value & 2^5).Equals(1);
                DI06 = (value & 2^6).Equals(1);
                DI07 = (value & 2^7).Equals(1);
                DI10 = (value & 2^8).Equals(1);
                DI11 = (value & 2^9).Equals(1);
                DI12 = (value & 2^10).Equals(1);
                DI13 = (value & 2^11).Equals(1);
                DI14 = (value & 2^12).Equals(1);
                DI15 = (value & 2^13).Equals(1);
                DI16 = (value & 2^14).Equals(1);
                DI17 = (value & 2^15).Equals(1);
            }
        }
    }

    class ActualValue_02
    {
        int value;

        public ActualValue_02()
        {

        }

        public int GetSetValue
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

    }

    class Controller
    {
        string name;
        MotorControl motorCtrl;
        ReadBack readback;

        class MotorControl
        {
            //Copy and paste from FieldInput data fields - controlword_i1...etc.
            public ControlWord_I1 Control_I1;
            public BinaryOutputs_I2 BinaryOut_I2;
            public ControlWord_I3 Control_I3;
            public SetpointVelocity SetpointVelocity;       //Should this be of type SetpointVelocity?
            public Acceleration Acceleration;
            public Deceleration Deceleration;
            public SetpointPosition Setpoint_Position;
            public SubcontrolWord Subcontrol;
            public BinaryOutputs_I10 BinaryOut_I10;
            public SetpointValue2 SetpointValue;
        }

        class ReadBack
        {
            public StatusWord_O1 Status_O1 { get; set; }
            public BinaryInputs_O2 Binary_O2 { get; set; }
            public StatusWordO3 Status_O3 { get; set; }
            public ActualVelocity ActualVelocity { get; set; }
            public OutputCurrent OutputCurrent { get; set; }
            public Reversed Reversed { get; set; }
            public Actual_Position Actual_Position { get; set; }
            public SubStatusWord substatusWord { get; set; }
            public BinaryInputs_O10 BinaryInputs_O10 { get; set; }
            public ActualValue_02 actualValue2 { get; set; }
        }
    }
}