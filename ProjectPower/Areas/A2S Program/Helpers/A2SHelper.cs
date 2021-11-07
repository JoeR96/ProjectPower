using ProjectPowerData.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.A2S_Program.Helpers
{
    public static class A2SHelper
    {
        public static decimal WorkingWeight(this A2SHyperTrophy model)
        {
            var workingWeight = model.Intensity * model.TrainingMax;
            var newWeight = Math.Ceiling(workingWeight / model.RoundingValue);
            var newNumber = newWeight * model.RoundingValue;
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
