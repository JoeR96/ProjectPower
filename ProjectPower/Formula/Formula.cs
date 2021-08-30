

using ProjectPower.Singleton;
using ProjectPower.Utility;
using System;

namespace ProjectPower.Formula
{
    
    public static class Formula
    {
        

        //=Floor((C2*0.7),2.5) & " x 6"
        public static decimal WaveOneTierOne()
        {
            var y = GlobalLiftInfo.SquatTrainingMax;
            var x = y * GlobalLiftInfo.w1T1;
            x = Toolkit.RoundToNearestIncrement(x);
            return x;
        }
    }


}
