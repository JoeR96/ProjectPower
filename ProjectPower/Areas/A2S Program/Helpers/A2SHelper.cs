using ProjectPowerData;
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


    }
    #region scaffoldData
    public class HyperTrophyBlockPrimaryLift 
    {
        public int[] amrapRepTarget = { 10, 8, 6, 9, 7, 5 };
        public int[] repsPerSet = { 5, 4, 3, 5, 4, 3 };
        public decimal[] intensity = { 0.70m, 0.75m, 0.80m, 0.725m, 0.775m, 0.825m };
        public int sets = 5;
    }
    public class HyperTrophyBlockAuxillaryLift
    {
        public int[] amrapRepTarget = {14, 12, 10, 13, 11, 9};
        public int[] repsPerSet = {7, 6, 5, 7, 6, 5};
        public decimal[] intensity = { 0.60m, 0.65m, 0.70m, 0.625m, 0.675m, 0.725m };
        public int sets = 3;
    }

    public class StrengthBlockPrimaryLift
    {
        public int[] amrapRepTarget = { 8, 6, 4, 7, 5, 3 };
        public int[] repsPerSet = { 4, 3, 2, 4, 3, 2 };
        public decimal[] intensity = { 0.75m, 0.80m, 0.85m, 0.775m, 0.825m, 0.875m };
        public int sets = 5;
    }

    public class StrengthBlockAuxillaryLift
    {
        public int[] amrapRepTarget = { 12, 10, 8, 11, 9, 7 };
        public int[] repsPerSet = { 6, 5, 4, 6, 5, 4 };
        public decimal[] intensity = { 0.65m, 0.70m, 0.75m, 0.675m, 0.725m, 0.775m };
        public int sets = 3;
    }

    public class PeakingBlockPrimaryLift
    {
        public int[] amrapRepTarget = { 6, 4, 2, 4, 2, 2 };
        public int[] repsPerSet = { 3, 2, 1, 2, 1, 1 };
        public decimal[] intensity = { 0.80m, 0.85m, 0.90m, 0.85m, 0.90m, 0.95m };
        public int sets = 5;
    }

    public class PeakingBlockAuxillaryLift
    {
        public int[] amrapRepTarget = { 10, 8, 6, 8, 3, 2 };
        public int[] repsPerSet = { 5, 4, 3, 4, 6, 4 };
        public decimal[] intensity = { 0.70m, 0.75m, 0.80m, 0.75m, 0.80m, 0.85m };
        public int sets = 3;
    }
    #endregion
}
