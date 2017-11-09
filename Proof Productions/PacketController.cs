using System;
using System.Net;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using ModbusTCP;
using System.Diagnostics;
using Proof_Productions.Model.Input;
using Proof_Productions.Model.Output;

namespace Proof_Productions
{
    class PacketController
    {
        private ModbusTCP.Master MBmaster;
        private byte[] data;
        private byte[] result;

        public void ConnectMotor()
        {
            try
            {
                // Create new modbus master and add event functions
                MBmaster = new Master("192.168.10.4", 502);
                
                //Need to figure this out.
                //MBmaster.OnResponseData += new Master.ResponseData(MBmaster_OnResponseData);

                MBmaster.OnException += new ModbusTCP.Master.ExceptionData(MBmaster_OnException);
                // Show additional fields, enable watchdog
            }
            catch (SystemException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        /*
        // ------------------------------------------------------------------------
        // Event for response data
        // ------------------------------------------------------------------------
        private void MBmaster_OnResponseData(ushort ID, byte unit, byte function, byte[] values)
        {

            // ------------------------------------------------------------------
            // Seperate calling threads
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Master.ResponseData(MBmaster_OnResponseData), new object[] { ID, unit, function, values });
                return;
            }

            // ------------------------------------------------------------------------
            // Identify requested data
            switch (ID)
            {
                case 1:
                    grpData.Text = "Read coils";
                    data = values;
                    ShowAs(null, null);
                    break;
                case 2:
                    grpData.Text = "Read discrete inputs";
                    data = values;
                    ShowAs(null, null);
                    break;
                case 3:
                    grpData.Text = "Read holding register";
                    data = values;
                    ShowAs(null, null);
                    break;
                case 4:
                    grpData.Text = "Read input register";
                    data = values;
                    ShowAs(null, null);
                    break;
                case 5:
                    grpData.Text = "Write single coil";
                    break;
                case 6:
                    grpData.Text = "Write multiple coils";
                    break;
                case 7:
                    grpData.Text = "Write single register";
                    break;
                case 8:
                    grpData.Text = "Write multiple register";
                    break;
            }
        }
        */

        // ------------------------------------------------------------------------
        // Modbus TCP slave exception
        // ------------------------------------------------------------------------
        private void MBmaster_OnException(ushort id, byte unit, byte function, byte exception)
        {
            string exc = "Modbus says error: ";
            switch (exception)
            {
                case Master.excIllegalFunction: exc += "Illegal function!"; break;
                case Master.excIllegalDataAdr: exc += "Illegal data adress!"; break;
                case Master.excIllegalDataVal: exc += "Illegal data value!"; break;
                case Master.excSlaveDeviceFailure: exc += "Slave device failure!"; break;
                case Master.excAck: exc += "Acknoledge!"; break;
                case Master.excGatePathUnavailable: exc += "Gateway path unavailbale!"; break;
                case Master.excExceptionTimeout: exc += "Slave timed out!"; break;
                case Master.excExceptionConnectionLost: exc += "Connection is lost!"; break;
                case Master.excExceptionNotConnected: exc += "Not connected!"; break;
            }

            MessageBox.Show(exc, "Modbus slave exception");
        }
        
        
        public void WriteMotor(int v, int a, Boolean positive)
        {
            ushort ID = 8;
            ushort StartAddress = 4;
            byte unit = 0;


            FieldbusInputData packet = new FieldbusInputData();
            packet.SetpointVelocity.Set(v);
            packet.Acceleration.Set(a);
            if (positive)
                packet.Control_I3.Set(2566);
            else
                packet.Control_I3.Set(‭3078‬);
            
            //(positive ? packet.Control_I3.Set(2566) : packet.Control_I3.Set(‭3078‬));


            MBmaster.ReadWriteMultipleRegister(ID, unit, StartAddress, 12, StartAddress, packet.GetValue, ref result);
        }
        
        /* 
        //No longer functional test code
        public void Test()
        {
            // TODO Can we hardcode this?
            String size = "12";
            int startAddress = 4;
            data = new byte[24];
            SetpointVelocity setPointVelocity = new SetpointVelocity();

            int acceleration = Convert.ToInt16(80);


            setPointVelocity.GetSetValue = Convert.ToInt16(300);



            ushort ID = 8;
            byte unit = 0;
            ushort StartAddress = Convert.ToUInt16(startAddress); //ReadStartAdr();

            data[0] = 0; //byte 0 of Control 1
            data[1] = 0; //byte 1 of Control 1
            data[2] = 0; //byte 0 of Binary Outputs
            data[3] = 0;  //byte 1 of Binary Outputs
            data[4] = 10;  //byte 0 of Control 3
            data[5] = 6;   //byte 1 of Control 3
            data[6] = BitConverter.GetBytes(setPointVelocity.GetSetValue)[1];  // byte 1 of Velocity
            data[7] = BitConverter.GetBytes(setPointVelocity.GetSetValue)[0];  // byte 0 of velocity
            data[8] = BitConverter.GetBytes(acceleration)[1];  // byte 1 of Velocity
            data[9] = BitConverter.GetBytes(acceleration)[0];  // byte 0 of velocity
            data[10] = 0;

            //ModifyBit(data[5],1);


            //MBmaster.WriteMultipleRegister(ID, unit, StartAddress, data);

            //result is null when clicking the button, but not null when debugging through it
            //Doesn't throw NullReferenceException when putting breakpoint on line 927 - throws otherwise

            MBmaster.ReadWriteMultipleRegister(ID, unit, StartAddress, 12, StartAddress, data, ref result);
            Console.WriteLine("result 6 and 7 " + result[6] + "" + result[7]);// + result[7]);
            Console.WriteLine("result 12 to 15 " + result[12] + "" + result[13] + "" + result[14] + "" + result[15]);
            long position = result[12] * 256 * 256 * 256 + result[13] * 256 * 256 + result[14] * 256 + result[15];
            Console.WriteLine("Position is: " + position);
            //         bytes
            // word 1  00 01
            // word 2  02 03
            // word 3  04 05
            // word 4  06 07 <-  Actual Velocity    
            // word 5  08 09
            // word 6  10 11
            // word 7  12 13 14 15 <- actual position (long word)
        }
        */
    }
}
