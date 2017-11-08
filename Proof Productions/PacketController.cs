using System;
using System.Net;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using ModbusTCP;
using System.Diagnostics;
using PacketModel;

namespace Proof_Productions
{
    class PacketController
    {
        private ModbusTCP.Master MBmaster;
        private byte[] data;
        private byte[] result;


        private void WriteMotor(int v, int a, int d, Boolean positive)
        {
            FieldbusInputData packet = new FieldbusInputData();
            SetpointVelocity setPointVelocity = new SetpointVelocity();
            Acceleration acceleration = new Acceleration();
            Deceleration deceleration = new Deceleration();
            SetpointPosition setPointPosition = new SetpointPosition();
            ControlWord_I3 wordi3 = new ControlWord_I3();


            packet.Acceleration.setAcceleration(30);
            ushort ID = 8;
            byte unit = 0;
            ushort StartAddress = Convert.ToUInt16(4);
            MBmaster.ReadWriteMultipleRegister(ID, unit, StartAddress, 12, StartAddress, data, ref result);
        }

    }
}
