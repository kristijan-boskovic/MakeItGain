using System.Collections.Generic;

namespace FinAssist.Model.Repositories
{
	public interface IWorkoutRepository
	{
		int	GetWorkoutNum();
        Workout GetWorkoutById(int workoutId);
        Workout GetWorkoutByName(string workoutName);
		List<Workout> GetAllWorkouts();
        List<HistoryWorkout> GetAllHistoryWorkouts();
        List<int> GetAllWorkoutsIds();
		int	GetNewId();
		void AddWorkout(Workout workout);
        void EditWorkout(Workout workout);
        void DeleteWorkout(Workout workout);
        void StartWorkout(Workout workout);
        void finishWorkout(Workout workout, string duration, string date, int caloriesBurned, List<int> reps, List<int> weights);
    }
}