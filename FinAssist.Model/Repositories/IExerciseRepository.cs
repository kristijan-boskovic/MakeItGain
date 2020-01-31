using System.Collections.Generic;

namespace FinAssist.Model.Repositories
{
	public interface IExerciseRepository
	{
		int	getExerciseNum();
        Exercise getExerciseById(int exerciseId);
        Exercise getExerciseByName(string exerciseName);
        List<Exercise> getExercisesByMuscleGroup(string muscleGroup);
        List<Exercise> getAllExercises();
        List<int> getAllExercisesIds();
		int	getNewId();
		void addExercise(Exercise exercise);
		void deleteExercise(int exerciseId);
	}
}