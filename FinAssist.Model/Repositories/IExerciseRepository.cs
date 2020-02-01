using System.Collections.Generic;

namespace FinAssist.Model.Repositories
{
	public interface IExerciseRepository
	{
		int	GetExerciseNum();
        Exercise GetExerciseById(int exerciseId);
        Exercise GetExerciseByName(string exerciseName);
        List<Exercise> GetExercisesByMuscleGroup(string muscleGroup);
        List<Exercise> GetAllExercises();
        List<int> GetAllExercisesIds();
		int	GetNewId();
		void AddExercise(Exercise exercise);
		void DeleteExercise(int exerciseId);
	}
}