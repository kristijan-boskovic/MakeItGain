using System.Collections.Generic;

namespace FinAssist.Model.Repositories
{
	public interface IWorkoutRepository
	{
		int	getWorkoutNum();
        Workout getWorkoutById(int workoutId);
        Workout getWorkoutByName(string workoutName);
		List<Workout> getAllWorkouts();
        List<HistoryWorkout> getAllHistoryWorkouts();
        List<int> getAllWorkoutsIds();
		int	getNewId();
		void addWorkout(Workout workout);
        void editWorkout(Workout workout);
        void deleteWorkout(Workout workout);
        void startWorkout(Workout workout);
        void finishWorkout(Workout workout, string duration, string date, int caloriesBurned, List<int> reps);
    }
}