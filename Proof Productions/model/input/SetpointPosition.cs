﻿namespace Proof_Productions.Model.Input
{
    class SetpointPosition
    {

        int setpointPosition;

        public SetpointPosition()
        {
            setpointPosition = 0;
        }

        public void Set(int setpointPosition)
        {
            this.setpointPosition = setpointPosition;
        }

        public int Get()
        {
            return setpointPosition;
        }

    }
}
