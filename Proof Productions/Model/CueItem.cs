using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proof_Productions.Model.Input;

namespace Proof_Productions.Model
{
    public class CueItem
    {
        public double DelayBefore, RunTime; //In Seconds
        public int SetVelocity, SetAcceleration, SetDeceleration, SetPosition;
        public int Number; 
        public bool PositiveDirection, Running, Stopping;
        public Motor CueMotor;
 
        public CueItem(double DelayBefore, double Runtime, Motor CueMotor, int SetVelocity, int SetAcceleration, int SetDeceleration, bool PositiveDirection, int SetPosition)
        {
            this.DelayBefore = DelayBefore;
            this.RunTime = Runtime;
            this.CueMotor = CueMotor;
            this.SetVelocity = SetVelocity;
            this.SetAcceleration = SetAcceleration;
            this.SetDeceleration = SetDeceleration;
            this.PositiveDirection = PositiveDirection;
            this.SetPosition = SetPosition;
            Stopping = false;
        }

        public void UpdateInputFields()
        {
            CueMotor.InputData.SetpointVelocity.Set(SetVelocity);
            CueMotor.InputData.Acceleration.Set(SetAcceleration);
            CueMotor.InputData.Deceleration.Set(SetDeceleration);
            CueMotor.InputData.Control_I3.Positive = PositiveDirection;
            CueMotor.InputData.Control_I3.Negative = !PositiveDirection;
            CueMotor.InputData.Setpoint_Position.Set(SetPosition);
        }

        private Boolean ValidDuration()
        {
            return ((SetVelocity/SetAcceleration + SetVelocity/SetDeceleration) >= RunTime);
        }


    }
}
