using AutoMapper;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPower.Areas.WorkoutCreation.Weekly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Mapping
{
    public class UpdateExerciseModelToFindWeeklyExerciseProfile : Profile
    {
        public UpdateExerciseModelToFindWeeklyExerciseProfile()
        {
            CreateMap<UpdateWeeklyExerciseModel, FindWeeklyExercise>()
                .ForMember(u => u.ExerciseMasterId, opt => opt.MapFrom(f => f.ExerciseMasterId))
                .ForMember(u => u.Week, opt => opt.MapFrom(f => f.Week));
        }
    }
}
