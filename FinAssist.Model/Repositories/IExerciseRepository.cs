using System.Collections.Generic;

namespace FinAssist.Model.Repositories
{
	public interface IExerciseRepository
	{
		int	getExerciseNum();
        Exercise getExerciseById(int exerciseId);
        Exercise getExerciseByName(string exerciseName);
		List<DisplayExercise> getAllDisplayExercises();
        List<WorkoutExercise> getAllWorkoutExercises();
        List<int> getAllExercisesIds();
		//List<int> getAllAccountsOfType(AccountTypesList.AccountTypesEnum inType);

		int	getNewId();
		//bool doesExerciseExist(string exerciseName);
		//ExpenditureSinkAccount getExpSinkAccount();

		void addExercise(Exercise exercise);
		void deleteExercise(int exerciseId);
	}
}