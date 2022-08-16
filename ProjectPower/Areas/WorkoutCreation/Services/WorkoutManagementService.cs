using AutoMapper;
using ProjectPower.Areas.A2S_Program.Factories;
using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPower.Areas.WorkoutCreation.Weekly;
using ProjectPower.FactoryPattern;
using ProjectPower.Repositories.Interfaces;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;

namespace ProjectPower.Areas.WorkoutCreation.Services
{
    public class WorkoutManagementService : IWorkoutManagementService
    {
        private readonly IMapper _mapper;
        private readonly IExerciseRepository _exerciseRepository;
        DataContext _dc;
        Dictionary<string, ExerciseFactory> exerciseFactories = null;
        A2SHypertrophyFactory a2SHypertrophyFactory = null;
        A2SRepsThenSetsFactory a2SRepsThenSetsFactory = null;
        public WorkoutManagementService(DataContext context, IExerciseRepository exerciseRepository, IMapper mapper)
        { 
            _exerciseRepository = exerciseRepository;
            _mapper = mapper;
            _dc = context;
            SetupExerciseFactories();
        }

        private void SetupExerciseFactories()
        {
            a2SHypertrophyFactory = new A2SHypertrophyFactory();
            a2SRepsThenSetsFactory = new A2SRepsThenSetsFactory();

            exerciseFactories = new Dictionary<string, ExerciseFactory>
            {
                { "A2SHypertrophy", a2SHypertrophyFactory },

                { "A2SRepsThenSets", a2SRepsThenSetsFactory }
            };
        }

        public void CreateWorkout(CreateWorkoutMasterTemplateModel model)
        {
            model.ExerciseDaysAndOrders.ForEach(e => exerciseFactories[e.Template].CreateExercise(e));

        }

        public List<Exercise> GetDailyWorkout(string username)
        {
            var ua = _dc.UserAccounts.Where(e => e.UserName == username).FirstOrDefault();
            var _ = _dc.Exercises.Where(e => e.UserName == username && e.ExerciseDay == ua.CurrentDay && e.Week == ua.CurrentWeek)
                .OrderBy(exercise => exercise.ExerciseOrder)
                .ToList();

            return _;
        }


        public void UpdateExerciseResult(UpdateWeeklyExerciseModel model)
        {
            var exercise = _mapper.Map<UpdateWeeklyExerciseModel, FindWeeklyExercise>(model);
            var _ = _exerciseRepository.FindWeeklyExercise(exercise);

            exerciseFactories[_.Result.Template]
                .UpdateExercise(model, _.Result);
        }
        public void GetDayAndWeek(string username)
        {
            var user = _dc.UserAccounts
                .Where(u => u.UserName == username)
                .FirstOrDefault();
        }
        public void UpdateDayAndWeek(string username)
        {
            var user = _dc.UserAccounts.Where(u => u.UserName == username)
                .FirstOrDefault();
            if (user.CurrentDay < user.WorkoutDaysInWeek)
            {
                user.CurrentDay++;
            }
            else if (user.CurrentWeek < user.WorkoutWeeks)
            {
                user.CurrentWeek++;
                user.CurrentDay = 0;
            }
            else
            {
                //Program completed
            }
            _dc.SaveChanges();

        }

    }
}
