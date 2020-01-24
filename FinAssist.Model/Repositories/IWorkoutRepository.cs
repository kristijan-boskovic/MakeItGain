using System.Collections.Generic;

namespace FinAssist.Model.Repositories
{
	public interface IWorkoutRepository
	{
		int	getWorkoutNum();
        Workout getWorkoutById(int workoutId);
        Workout getWorkoutByName(string workoutName);
		List<Workout> getAllWorkouts();
        List<int> getAllWorkoutsIds();
		//List<int> getAllAccountsOfType(AccountTypesList.AccountTypesEnum inType);

		int	getNewId();
		//bool doesExerciseExist(string exerciseName);
		//ExpenditureSinkAccount getExpSinkAccount();

		void addWorkout(Workout workout);
        void editWorkout(Workout workout);
        void deleteWorkout(Workout workout);
        void startWorkout(Workout workout);

    }
}