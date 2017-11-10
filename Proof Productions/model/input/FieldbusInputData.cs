//using Proof_Productions.Model.input.Proof_Productions.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Input
{
    class FieldbusInputData
    {
        public ControlWord_I1 Control_I1 { get; set; }          = new ControlWord_I1();
        public BinaryOutputs_I2 BinaryOut_I2 { get; set; }      = new BinaryOutputs_I2();
        public ControlWord_I3 Control_I3 { get; set; }          = new ControlWord_I3();
        public SetpointVelocity SetpointVelocity { get; set; }  = new SetpointVelocity();
        public Acceleration Acceleration { get; set; }          = new Acceleration();
        public Deceleration Deceleration { get; set; }          = new Deceleration();
        public SetpointPosition Setpoint_Position { get; set; } = new SetpointPosition();
        public SubcontrolWord Subcontrol { get; set; }          = new SubcontrolWord();
        public BinaryOutputs_I10 BinaryOut_I10 { get; set; }    = new BinaryOutputs_I10();
        public SetpointValue2 SetpointValue { get; set; }       = new SetpointValue2();
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

        public byte[] GetValue()
        {
            byte[] bytes = new byte[24];
            /*
                //when we return the setpoint velocity, acceleration and deceleration
                //make sure you swap the bytes
                bytes[0] = BitConverter.GetBytes(Control_I1.Get())[0];
                bytes[1] = BitConverter.GetBytes(Control_I1.Get())[1];
                bytes[2] = BitConverter.GetBytes(BinaryOut_I2.Get())[0];
                bytes[3] = BitConverter.GetBytes(BinaryOut_I2.Get())[1];
                bytes[4] = 10; //BitConverter.GetBytes(Control_I3.Get())[0];
                bytes[5] = 6; //BitConverter.GetBytes(Control_I3.Get())[1];
                bytes[6] = BitConverter.GetBytes(SetpointVelocity.Get())[1];
                bytes[7] = BitConverter.GetBytes(SetpointVelocity.Get())[0];
                bytes[8] = BitConverter.GetBytes(Acceleration.Get())[1];
                bytes[9] = BitConverter.GetBytes(Acceleration.Get())[0];
                bytes[10] = BitConverter.GetBytes(Deceleration.Get())[1];
                bytes[11] = BitConverter.GetBytes(Deceleration.Get())[0];
                bytes[12] = BitConverter.GetBytes(Setpoint_Position.Get())[1];
                bytes[13] = BitConverter.GetBytes(Setpoint_Position.Get())[0];
                bytes[14] = BitConverter.GetBytes(Subcontrol.Get())[0];
                bytes[15] = BitConverter.GetBytes(Subcontrol.Get())[1];
                bytes[16] = BitConverter.GetBytes(BinaryOut_I10.Get())[0];
                bytes[18] = BitConverter.GetBytes(BinaryOut_I10.Get())[1];
                bytes[19] = BitConverter.GetBytes(SetpointValue.Get())[1];
                bytes[20] = BitConverter.GetBytes(SetpointValue.Get())[0];
                //TODO - Continue this for the remainder of the data
                return bytes;
            */
            bytes[0] = 0x0;
            bytes[1] = 0x0;
            bytes[2] = 0x0;
            bytes[3] = 0x0;
            bytes[4] = Control_I3.GetByte1();
            bytes[5] = Control_I3.GetByte0();
            bytes[6] = BitConverter.GetBytes(SetpointVelocity.Get())[1];
            bytes[7] = BitConverter.GetBytes(SetpointVelocity.Get())[0];
            bytes[8] = BitConverter.GetBytes(Acceleration.Get())[1];
            bytes[9] = BitConverter.GetBytes(Acceleration.Get())[0];

            Console.Out.WriteLine(Control_I3.GetByte0() + " " + Control_I3.GetByte1());
            Console.Out.WriteLine(bytes[5] + " " + bytes[4]);
            return bytes;
            
        }

    }
}
