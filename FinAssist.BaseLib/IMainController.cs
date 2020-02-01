using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.BaseLib
{
	public interface IMainController
	{
        //void AddExercise();
        //void EditAccount(string accountName);
        void ViewExerciseDetails(Exercise exercise);
        void AddWorkout();
        void EditWorkout(Workout workout);
        void DeleteWorkout(Workout workout);
        void StartWorkout(Workout workout);
        void FinishWorkout(Workout workout, string duration, string date, int caloriesBurned, List<int> reps, List<int> weights);
        void ViewHistoryWorkoutDetails(HistoryWorkout historyWorkout);
        void AddWeightMeasure();
    }
}
