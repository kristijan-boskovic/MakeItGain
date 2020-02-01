using System.Collections.Generic;
using FinAssist.Model;
using FinAssist.Model.Repositories;
using FinAssist.BaseLib;

namespace FinAssist.Controllers
{
    public class ExerciseController
    {
        public void ViewExercises(IShowExercisesListView form, IExerciseRepository exerciseRepository, IMainController mainController)
        {
            List<Exercise> exercises = exerciseRepository.GetAllExercises();
            form.ShowExercises(mainController, exercises, exerciseRepository);
        }

        public void ViewExerciseDetails(IShowExerciseDetails form, Exercise exercise)
        {
            form.ShowExerciseDetails(exercise);
        }
    }
}