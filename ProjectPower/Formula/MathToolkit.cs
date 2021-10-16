using ProjectPower.Singleton;
using ProjectPower.Utility;
using System;
using static ProjectPower.Utility.Enums;

namespace ProjectPower.Formula
{
    public static class MathToolkit
    {
        public static decimal ReturnIntensityExerciseWeight(decimal trainingMax, decimal intensity)
        {
            var weight = trainingMax * intensity;
            return RoundToNearestMultiple(weight);
        }

        public static decimal RoundToNearestMultiple(decimal weight, decimal roundingValue = 2.5m)
        {
            return roundingValue * Math.Ceiling(weight / roundingValue);
        }
    }  
}
