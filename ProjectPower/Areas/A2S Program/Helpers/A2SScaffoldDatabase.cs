using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.UserAccounts.Services;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.A2S_Program.Helpers
{
    public class A2SScaffoldDatabase
    {

        StrengthBlockAuxillaryLift strengthBlockAuxillaryLift = new StrengthBlockAuxillaryLift();
        HyperTrophyBlockAuxillaryLift hyperTrophyBlockAuxillaryLift = new HyperTrophyBlockAuxillaryLift();
        PeakingBlockAuxillaryLift peakingBlockAuxillaryLift = new PeakingBlockAuxillaryLift();

        StrengthBlockPrimaryLift strengthBlockPrimaryLift = new StrengthBlockPrimaryLift();
        HyperTrophyBlockPrimaryLift hyperTrophyBlockPrimaryLift = new HyperTrophyBlockPrimaryLift();
        PeakingBlockPrimaryLift peakingBlockPrimaryLift = new PeakingBlockPrimaryLift();

        private readonly DataContext _dc;

        public A2SScaffoldDatabase(DataContext context)
        {
            _dc = context;
        }

        public void PopulateDb(CreateA2SWorkoutModel model)
        {

            
            Guid g = Guid.NewGuid();
            if(model.AuxillaryLift)
            {
                for (int i = 0; i < hyperTrophyBlockPrimaryLift.amrapRepTarget.Length; i++)
                {
                    var dbEntity = new A2SHyperTrophyModel();

                    dbEntity.Name = model.Name;
                    dbEntity.TrainingMax = model.TrainingMax;
                    dbEntity.AuxillaryLift = true;
                    dbEntity.Block = "HyperTrophy";
                    dbEntity.AmrapRepTarget = hyperTrophyBlockPrimaryLift.amrapRepTarget[i];
                    dbEntity.AmrapRepResult = 0;
                    dbEntity.Week = i + 1;
                    dbEntity.Intensity = hyperTrophyBlockPrimaryLift.intensity[i];
                    dbEntity.Sets = hyperTrophyBlockPrimaryLift.sets;
                    dbEntity.RepsPerSet = hyperTrophyBlockPrimaryLift.repsPerSet[i];
                    dbEntity.UniqueId = g.ToString();
                    dbEntity.Username = "user";
                    _dc.A2SWorkoutExercises.Add(dbEntity);
                }
                for (int i = 0; i < hyperTrophyBlockPrimaryLift.amrapRepTarget.Length; i++)
                {
                    var dbEntity = new A2SHyperTrophyModel();

                    dbEntity.Name = model.Name;
                    dbEntity.TrainingMax = model.TrainingMax;
                    dbEntity.AuxillaryLift = true;
                    dbEntity.Block = "StrengthBlock";
                    dbEntity.AmrapRepTarget = strengthBlockPrimaryLift.amrapRepTarget[i];
                    dbEntity.AmrapRepResult = 0;
                    dbEntity.Week = i + 1;
                    dbEntity.Intensity = strengthBlockPrimaryLift.intensity[i];
                    dbEntity.Sets = strengthBlockPrimaryLift.sets;
                    dbEntity.RepsPerSet = strengthBlockPrimaryLift.repsPerSet[i];
                    _dc.A2SWorkoutExercises.Add(dbEntity);
                }
                for (int i = 0; i < hyperTrophyBlockPrimaryLift.amrapRepTarget.Length; i++)
                {
                    var dbEntity = new A2SHyperTrophyModel();

                    dbEntity.Name = model.Name;
                    dbEntity.TrainingMax = model.TrainingMax;
                    dbEntity.AuxillaryLift = true;
                    dbEntity.Block = "PeakingBlock";
                    dbEntity.AmrapRepTarget = peakingBlockPrimaryLift.amrapRepTarget[i];
                    dbEntity.AmrapRepResult = 0;
                    dbEntity.Week = i + 1;
                    dbEntity.Intensity = peakingBlockPrimaryLift.intensity[i];
                    dbEntity.Sets = peakingBlockPrimaryLift.sets;
                    dbEntity.RepsPerSet = peakingBlockPrimaryLift.repsPerSet[i];
                    _dc.A2SWorkoutExercises.Add(dbEntity);
                }
            }
            else
            {
                for (int i = 0; i < hyperTrophyBlockPrimaryLift.amrapRepTarget.Length; i++)
                {
                    var dbEntity = new A2SHyperTrophyModel();

                    dbEntity.Name = model.Name;
                    dbEntity.TrainingMax = model.TrainingMax;
                    dbEntity.AuxillaryLift = true;
                    dbEntity.Block = "HyperTrophy";
                    dbEntity.AmrapRepTarget = hyperTrophyBlockAuxillaryLift.amrapRepTarget[i];
                    dbEntity.AmrapRepResult = 0;
                    dbEntity.Week = i + 1;
                    dbEntity.Intensity = hyperTrophyBlockAuxillaryLift.intensity[i];
                    dbEntity.Sets = hyperTrophyBlockAuxillaryLift.sets;
                    dbEntity.RepsPerSet = hyperTrophyBlockAuxillaryLift.repsPerSet[i];
                    _dc.A2SWorkoutExercises.Add(dbEntity);
                }
                for (int i = 0; i < hyperTrophyBlockPrimaryLift.amrapRepTarget.Length; i++)
                {
                    var dbEntity = new A2SHyperTrophyModel();

                    dbEntity.Name = model.Name;
                    dbEntity.TrainingMax = model.TrainingMax;
                    dbEntity.AuxillaryLift = true;
                    dbEntity.Block = "StrengthBlock";
                    dbEntity.AmrapRepTarget = strengthBlockAuxillaryLift.amrapRepTarget[i];
                    dbEntity.AmrapRepResult = 0;
                    dbEntity.Week = i + 1;
                    dbEntity.Intensity = strengthBlockAuxillaryLift.intensity[i];
                    dbEntity.Sets = strengthBlockAuxillaryLift.sets;
                    dbEntity.RepsPerSet = strengthBlockAuxillaryLift.repsPerSet[i];
                    _dc.A2SWorkoutExercises.Add(dbEntity);
                }
                for (int i = 0; i < hyperTrophyBlockPrimaryLift.amrapRepTarget.Length; i++)
                {
                    var dbEntity = new A2SHyperTrophyModel();

                    dbEntity.Name = model.Name;
                    dbEntity.TrainingMax = model.TrainingMax;
                    dbEntity.AuxillaryLift = true;
                    dbEntity.Block = "PeakingBlock";
                    dbEntity.AmrapRepTarget = peakingBlockAuxillaryLift.amrapRepTarget[i];
                    dbEntity.AmrapRepResult = 0;
                    dbEntity.Week = i + 1;
                    dbEntity.Intensity = peakingBlockAuxillaryLift.intensity[i];
                    dbEntity.Sets = peakingBlockAuxillaryLift.sets;
                    dbEntity.RepsPerSet = peakingBlockAuxillaryLift.repsPerSet[i];
                    _dc.A2SWorkoutExercises.Add(dbEntity);
                }
            }
           

            _dc.SaveChanges();
        }
    }
}
