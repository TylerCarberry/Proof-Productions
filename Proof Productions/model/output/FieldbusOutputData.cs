using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Model.Output
{
    public class FieldbusOutputData
    {
        public StatusWordO1 Status1;
        public BinaryInputsO2 Binary2;
        public StatusWordO3 Status3;
        public ActualVelocity Velocity;
        public OutputCurrent Current;
        public Reserved Reserve;
        public ActualPosition Position;
        public SubStatusWord SubStatus;
        public BinaryInputsO10 Binary10;
        public ActualValue02 Value2;

        public FieldbusOutputData()
        {
            Status1 = new StatusWordO1();
            Binary2 = new BinaryInputsO2();
            Status3 = new StatusWordO3();
            Velocity = new ActualVelocity();
            Current = new OutputCurrent();
            Reserve = new Reserved();
            Position = new ActualPosition();
            SubStatus = new SubStatusWord();
            Binary10 = new BinaryInputsO10();
            Value2 = new ActualValue02();
        }
        
        public void SetValues(byte[] data)
        {
            Status1.Decode(data[0], data[1]);
            Binary2.Decode(data[2], data[3]);
            Status3.Decode(data[4], data[5]);
            Velocity.Decode(data[6], data[7]);
            Current.Decode(data[8], data[9]);
            Reserve.Decode(data[10], data[11]);
            Position.Decode(data[12], data[13], data[14], data[15]);
            SubStatus.Decode(data[16], data[17]);
            Binary10.Decode(data[18], data[19]);
            Value2.Decode(data[20], data[21], data[22], data[23]);
            DebugTest();
        }
        
        private void DebugTest()
        {
            Console.WriteLine(Status1);
            Console.WriteLine(Binary2);
            Console.WriteLine(Status3);
            Console.WriteLine(Velocity);
            Console.WriteLine(Current);
            Console.WriteLine(Reserve);
            Console.WriteLine(Position);
            Console.WriteLine(SubStatus);
            Console.WriteLine(Binary10);
            Console.WriteLine(Value2);
        }
    }
}
