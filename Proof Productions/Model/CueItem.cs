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
        public String Name;
        public double DelayBefore, RunTime;
        public int SetVelocity, SetAcceleration, SetDeceleration, SetPosition;
        public Motor CueMotor;
 
        public CueItem(double DelayBefore, double Runtime, Motor CueMotor, int SetVelocity, int SetAcceleration, int SetDeceleration, int SetPosition)
        {
            this.DelayBefore = DelayBefore;
            this.RunTime = Runtime;
            this.CueMotor = CueMotor;
            this.SetVelocity = SetVelocity;
            this.SetAcceleration = SetAcceleration;
            this.SetDeceleration = SetDeceleration;
            this.SetPosition = SetPosition;
        }
    }
}
