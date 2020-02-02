using System.Collections.Generic;

namespace FinAssist.Model.Repositories
{
	public interface IExerciseRepository
	{
        Exercise GetExerciseByName(string exerciseName);
        List<Exercise> GetExercisesByMuscleGroup(string muscleGroup);
        List<Exercise> GetAllExercises();
		int	GetNewId();
		void AddExercise(Exercise exercise);
    }
}