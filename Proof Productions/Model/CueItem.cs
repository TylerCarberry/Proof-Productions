using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proof_Productions.Model.Input;

namespace Proof_Productions.Model
{
    class CueItem
    {
        double DelayBefore, RunTime;
        int SetVelocity, SetAcceleration, SetDeceleration, SetPosition;
        Motor CueMotor;
 
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
