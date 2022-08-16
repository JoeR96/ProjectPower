namespace ProjectPower.Areas.A2S_Program.Helpers
{
    public class A2SHypertrophyTemplateValues
    {
        #region TemplateValues
        public HyperTrophyBlockPrimaryLift HTPL { get; set; } = new HyperTrophyBlockPrimaryLift();
        public HyperTrophyBlockAuxillaryLift HTAL { get; set; } = new HyperTrophyBlockAuxillaryLift();
        public StrengthBlockPrimaryLift SBPL { get; set; } = new StrengthBlockPrimaryLift();
        public StrengthBlockAuxillaryLift SBAL { get; set; } = new StrengthBlockAuxillaryLift();
        public PeakingBlockPrimaryLift PBPL { get; set; } = new PeakingBlockPrimaryLift();
        public PeakingBlockAuxillaryLift PBAL { get; set; } = new PeakingBlockAuxillaryLift();
        public Dictionary<string, A2SLift> A2SPrimaryLifts { get; set; }
        public Dictionary<string, A2SLift> A2SAuxLifts { get; set; }
        public A2SHypertrophyTemplateValues()
        {
            HTPL = new HyperTrophyBlockPrimaryLift();
            HTAL = new HyperTrophyBlockAuxillaryLift();
            SBPL = new StrengthBlockPrimaryLift();
            SBAL = new StrengthBlockAuxillaryLift();
            PBPL = new PeakingBlockPrimaryLift();
            PBAL = new PeakingBlockAuxillaryLift();

            A2SPrimaryLifts = new Dictionary<string, A2SLift>
            {
                {"HypertrophyBlock",HTPL},
                {"StrengthBlock",SBPL},
                {"PeakingBlock",PBPL}
            };

            A2SAuxLifts = new Dictionary<string, A2SLift>
            {
                {"HypertrophyBlock",HTAL},
                {"StrengthBlock",SBAL},
                {"PeakingBlock",PBAL}
            };
        }
        #endregion


    }
    public abstract class A2SLift
    {
        public int[] amrapRepTarget { get; set; }
        public int[] repsPerSet { get; set; }
        public decimal[] intensity { get; set; }
        public int sets { get; set; }
        public bool aux { get; set; }
    }
    #region scaffoldData
    public class HyperTrophyBlockPrimaryLift : A2SLift
    {
        public HyperTrophyBlockPrimaryLift()
        {
            amrapRepTarget = new int[] { 10, 8, 6, 9, 7, 5 };
            repsPerSet = new int[] { 5, 4, 3, 5, 4, 3 };
            intensity = new decimal[] { 0.70m, 0.75m, 0.80m, 0.725m, 0.775m, 0.825m };
            sets = 5;
            aux = false;
        }
    }
    public class HyperTrophyBlockAuxillaryLift : A2SLift
    {
        public HyperTrophyBlockAuxillaryLift()
        {
            amrapRepTarget = new int[] { 14, 12, 10, 13, 11, 9 };
            repsPerSet = new int[] { 7, 6, 5, 7, 6, 5 };
            intensity = new decimal[] { 0.60m, 0.65m, 0.70m, 0.625m, 0.675m, 0.725m };
            sets = 3;
            aux = true;
        }
    }
    public class StrengthBlockPrimaryLift : A2SLift
    {
        public StrengthBlockPrimaryLift()
        {
            amrapRepTarget = new int[] { 8, 6, 4, 7, 5, 3 };
            repsPerSet = new int[] { 4, 3, 2, 4, 3, 2 };
            intensity = new decimal[] { 0.75m, 0.80m, 0.85m, 0.775m, 0.825m, 0.875m };
            sets = 5;
            aux = false;
        }
    }

    public class StrengthBlockAuxillaryLift : A2SLift
    {
        public StrengthBlockAuxillaryLift()
        {
            amrapRepTarget = new int[] { 12, 10, 8, 11, 9, 7 };
            repsPerSet = new int[] { 6, 5, 4, 6, 5, 4 };
            intensity = new decimal[] { 0.65m, 0.70m, 0.75m, 0.675m, 0.725m, 0.775m };
            sets = 3;
            aux = true;
        }
    }

    public class PeakingBlockPrimaryLift : A2SLift
    {
        public PeakingBlockPrimaryLift()
        {
            amrapRepTarget = new int[] { 6, 4, 2, 4, 2, 2 };
            repsPerSet = new int[] { 3, 2, 1, 2, 1, 1 };
            intensity = new decimal[] { 0.80m, 0.85m, 0.90m, 0.85m, 0.90m, 0.95m };
            sets = 5;
            aux = false;
        }
    }

    public class PeakingBlockAuxillaryLift : A2SLift
    {
        public PeakingBlockAuxillaryLift()
        {
            amrapRepTarget = new int[] { 10, 8, 6, 8, 3, 2 };
            repsPerSet = new int[] { 5, 4, 3, 4, 6, 4 };
            intensity = new decimal[] { 0.70m, 0.75m, 0.80m, 0.75m, 0.80m, 0.85m };
            sets = 3;
            aux = true;
        }
    }
    #endregion
}
