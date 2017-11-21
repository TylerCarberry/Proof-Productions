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

namespace Proof_Productions.Controller
{
    class PacketController
    {
        private ModbusTCP.Master MBmaster;
        private byte[] result;

        public void ConnectMotor()
        {
            try
            {
                //Create new modbus master and add event functions
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

        public void WriteMotor(FieldbusInputData input)
        {
            ushort ID = 8;
            ushort StartAddress = 4;
            byte unit = 0;

            byte[] data = input.GetValues();
            MBmaster.ReadWriteMultipleRegister(ID, unit, StartAddress, 12, StartAddress, data, ref result);
            FieldbusOutputData Out = new FieldbusOutputData();
            Out.SetValues(result);
            Console.WriteLine();
        }
    }
}
