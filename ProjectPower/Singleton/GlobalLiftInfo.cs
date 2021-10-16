using static ProjectPower.Utility.Enums;

namespace ProjectPower.Singleton
{

    public class GlobalLiftInfo
    {
        private GlobalLiftInfo()
        { 
        }

        private static GlobalLiftInfo _instance;

        private static readonly object _lock = new object();

        public static GlobalLiftInfo GetInstance()
        {   
            if (_instance == null)
            {

                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new GlobalLiftInfo();
                    }
                }
            }
            return _instance;
        }


        public static decimal SquatTrainingMax = 125;
        public static decimal BenchTrainingMax = 90;
        public static decimal OhpTrainingMax = 50;
        public static decimal DeadliftTrainingMax = 190;
      
        public static int WeekOneTierOneRepsPerSet = 6;
        public static int WeekOneTierTwoRepsPerSet = 12;
        public static int WeekOneTierThreeRepsPerSet = 10;
        public static int WeekOneTierFourRepsPerSet = 15;

        public static readonly decimal w1T1 = 0.7M;
        public static readonly decimal w1T2 = 0.6M;
        public static readonly decimal w1T3 = 0.7M;
        public static readonly decimal w1T4 = 0.7M;

        public static readonly decimal w2T1 = 0.94M;

        public static readonly decimal w3T1 = 0.94M;

        public static readonly decimal w4T1 = 0.75M;

        public static readonly decimal w5T1 = 1.05m;

        public static readonly decimal w6T1 = 0.75m;
        public static decimal ReturnTrainingMax(TargetGroup targetGroup)
        {
            decimal trainingMax = 0.0m;
 
            if (targetGroup == TargetGroup.Legs)
            {
                trainingMax = BenchTrainingMax;
            }
            else if (targetGroup == TargetGroup.Chest)
            {
                trainingMax = SquatTrainingMax;
            }
            else if (targetGroup == TargetGroup.Back)
            {
                trainingMax =  DeadliftTrainingMax;
            }
            else if (targetGroup == TargetGroup.Shoulders)
            {
                trainingMax =  OhpTrainingMax;
            }

            return trainingMax;

        }

        public static decimal ReturnTierModifier(Tier targetTier, int week)
        {
            decimal waveModifierValue = 0.0m;

            if (week == 1)
            {
                if (targetTier == Tier.One)
                {
                    waveModifierValue = w1T1;
                }
                if (targetTier == Tier.Two)
                {
                    waveModifierValue = w1T2;
                }
                else if (targetTier == Tier.ThreeA || targetTier == Tier.ThreeB)
                {
                    waveModifierValue = w1T3;
                }
                else if (targetTier == Tier.FourA || targetTier == Tier.FourB)
                {
                    waveModifierValue = w1T4;
                }
            }
      
            if (week == 2)
            {
                if(targetTier == Tier.One)
                {
                    waveModifierValue = w2T1;
                }
            }

            if (week == 3)
            {
                if (targetTier == Tier.One)
                {
                    waveModifierValue = w3T1;
                }
            }

            if (week == 4)
            {
                if (targetTier == Tier.One)
                {
                    waveModifierValue = w4T1;
                }
            }

            if (week == 5)
            {
                if(targetTier == Tier.One)
                {
                    waveModifierValue = w5T1;
                }
            }

            return waveModifierValue;

        }
    }
}