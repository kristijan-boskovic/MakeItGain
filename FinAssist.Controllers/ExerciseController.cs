using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinAssist.Model;
using FinAssist.Model.Repositories;
using FinAssist.BaseLib;

namespace FinAssist.Controllers
{
    public class ExerciseController
    {
        public void ViewExercises(IShowExercisesListView form, IExerciseRepository exerciseRepository, IMainController mainController)
        {
            // dohvati sve accounte i proslijedi ih View-u
            List<Exercise> exercises = exerciseRepository.getAllExercises();

            // zašto proslijeđujemo i mainController?
            // zato što na ovom View-u imamo "Add new account" i "Edit new account" funkcionalnost!
            form.ShowExercises(mainController, exercises);
        }

        public void ViewExerciseDetails(IShowExerciseDetails form, Exercise exercise)
        {
            form.ShowExerciseDetails(exercise);
        }
    }
}