using System.Collections.Generic;

namespace FinAssist.Model.Repositories
{
	public interface IWorkoutRepository
	{
        Workout GetWorkoutById(int workoutId);
        List<Workout> GetAllWorkouts();
        List<HistoryWorkout> GetAllHistoryWorkouts();
		int	GetNewId();
		void AddWorkout(Workout workout);
        void EditWorkout(Workout workout);
        void DeleteWorkout(Workout workout);
        void AddWorkoutToHistory(Workout workout, string duration, string date, int caloriesBurned, List<int> reps, List<int> weights);
    }
}