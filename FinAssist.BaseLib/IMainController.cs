using System.Collections.Generic;
using FinAssist.Model;

namespace FinAssist.BaseLib
{
    public interface IMainController
	{
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
