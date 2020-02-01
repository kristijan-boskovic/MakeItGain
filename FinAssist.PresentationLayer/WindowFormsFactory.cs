using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinAssist.BaseLib;
using FinAssist.Model.Repositories;

namespace FinAssist.PresentationLayer
{
	public class WindowFormsFactory : Subject, IWindowFormsFactory
	{
        public IShowExercisesListView CreateShowExercisesListView()
        {
            var newFrm = new frmViewExercises();
            return newFrm;
        }

        public IShowExerciseDetails CreateShowExercisesDetails()
        {
            var newFrm = new frmViewExerciseDetails();
            return newFrm;
        }

        public IShowWorkoutsListView CreateShowWorkoutsListView()
        {
            var newFrm = new frmViewWorkouts();
            _listObservers.Clear();
            Attach(newFrm);
            return newFrm;
        }

        public IAddWorkoutView CreateAddNewWorkoutView()
        {
            var newFrm = new frmAddWorkout();
            return newFrm;
        }

        public IEditWorkoutView CreateEditWorkoutView()
        {
            var newFrm = new frmEditWorkout();
            return newFrm;
        }

        public IStartWorkoutView CreateStartWorkoutView()
        {
            var newFrm = new frmStartWorkout();
            return newFrm;
        }

        public IShowHistoryWorkoutsListView CreateShowHistoryWorkoutsListView()
        {
            var newFrm = new frmViewHistoryWorkouts();
            return newFrm;
        }

        public IShowHistoryWorkoutDetails CreateShowHistoryWorkoutDetails()
        {
            var newFrm = new frmViewHistoryWorkoutDetails();
            return newFrm;
        }

        public IShowWeightMeasuresListView CreateShowWeightMeasuresListView()
        {
            var newFrm = new frmViewWeightMeasures();
            _listObservers.Clear();
            Attach(newFrm);
            return newFrm;
        }

        public IAddWeightMeasureView CreateAddNewWeightMeasureView()
        {
            var newFrm = new frmAddWeightMeasure();
            return newFrm;
        }
    }
}
