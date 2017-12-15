//using Proof_Productions.Model.input.Proof_Productions.model;

namespace Proof_Productions.Model.Input
{
    public class FieldbusInputData
    {
        // A collection of all of the input for the motor

        public ControlWordI1 Control_I1;
        public BinaryOutputs_I2 BinaryOut_I2;
        public ControlWordI3 Control_I3;
        public SetpointVelocity SetpointVelocity;
        public Acceleration Acceleration;
        public Deceleration Deceleration;
        public SetpointPosition Setpoint_Position;
        public SubcontrolWord Subcontrol;
        public BinaryOutputsI10 BinaryOut_I10;
        public SetpointValue2 SetpointValue;

        public FieldbusInputData()
        {
            Control_I1 = new ControlWordI1();
            BinaryOut_I2 = new BinaryOutputs_I2();
            Control_I3 = new ControlWordI3();
            SetpointVelocity = new SetpointVelocity();
            Acceleration = new Acceleration();
            Deceleration = new Deceleration();
            Setpoint_Position = new SetpointPosition();
            Subcontrol = new SubcontrolWord();
            BinaryOut_I10 = new BinaryOutputsI10();
            SetpointValue = new SetpointValue2();

        }

        /// <summary>
        /// Convert the object to a byte array to be sent to the motor
        /// </summary>
        /// <returns></returns>
        public byte[] GetValues()
        {
            byte[] bytes = new byte[24];

            bytes[0] = Control_I1.EncodeByte1();
            bytes[1] = Control_I1.EncodeByte0();
            bytes[2] = BinaryOut_I2.EncodeByte1();
            bytes[3] = BinaryOut_I2.EncodeByte0();
            bytes[4] = Control_I3.EncodeByte1();
            bytes[5] = Control_I3.EncodeByte0();
            bytes[6] = SetpointVelocity.EncodeByte1();
            bytes[7] = SetpointVelocity.EncodeByte0();
            bytes[8] = Acceleration.EncodeByte1();
            bytes[9] = Acceleration.EncodeByte0();
            bytes[10] = Deceleration.EncodeByte1();
            bytes[11] = Deceleration.EncodeByte0();
            bytes[12] = Setpoint_Position.EncodeByte3();
            bytes[13] = Setpoint_Position.EncodeByte2();
            bytes[14] = Setpoint_Position.EncodeByte1();
            bytes[15] = Setpoint_Position.EncodeByte0();
            bytes[16] = Subcontrol.EncodeByte1();
            bytes[17] = Subcontrol.EncodeByte0();
            bytes[18] = BinaryOut_I10.EncodeByte1();
            bytes[19] = BinaryOut_I10.EncodeByte0();
            bytes[20] = SetpointValue.EncodeByte3();
            bytes[21] = SetpointValue.EncodeByte2();
            bytes[22] = SetpointValue.EncodeByte1();
            bytes[23] = SetpointValue.EncodeByte0();

            return bytes;
        }

    }
}
