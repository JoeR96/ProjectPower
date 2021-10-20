using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.A2S_Program.Helpers
{
    public static class A2SHelper
    {
        public static decimal ReturnWorkingWeight(decimal intensity, decimal trainingMax, decimal roundingValue )
        {
            var workingWeight = intensity * trainingMax;
            var newWeight = Math.Ceiling(workingWeight / roundingValue);
            var newNumber = newWeight * roundingValue;
            return newNumber;
        }
        public static decimal RoundToNearestIncrement(decimal value)
        {
            var divided = value / 2.5m;
            Math.Ceiling(divided);
            var newNumber = divided * 2.5m;
            return newNumber;
        }
    }
}
