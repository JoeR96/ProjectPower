using ProjectPowerData.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels
{
    public class ShowA2SWorkoutModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal TrainingMax { get; set; }
        public bool AuxillaryLift { get; set; }
        public string Block { get; set; }
        public int AmrapRepTarget { get; set; }
        public int? AmrapRepResult { get; set; }
        public int Week { get; set; }
        public decimal Intensity { get; set; }
        public int Sets { get; set; }
        public int RepsPerSet { get; set; }
        public int CurrentDay { get; set; }
        public int CurrentWeek { get; set; }
        public string Username { get; set; }
        public ShowA2SWorkoutModel(A2SHyperTrophyModel dbEntity)
        {
            Name = dbEntity.Name;
            TrainingMax = dbEntity.TrainingMax;
            AuxillaryLift = dbEntity.AuxillaryLift;
            Block = dbEntity.Block;
            AmrapRepTarget = dbEntity.AmrapRepTarget;
            AmrapRepResult = dbEntity.AmrapRepResult;
            Week = dbEntity.Week;
            Intensity = dbEntity.Intensity;
            Sets = dbEntity.Sets;
            RepsPerSet = dbEntity.RepsPerSet;
            //CurrentDay = dbEntity.LiftDay;
            CurrentWeek = dbEntity.Week;
        }
    }
}
