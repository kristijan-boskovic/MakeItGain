using System.Collections.Generic;

namespace FinAssist.BaseLib
{
    public interface IAddWorkoutView
	{
		bool ConfirmAddWorkout();
		string	WorkoutName { get; }
		List<string> ExerciseNames { get; }
        int SetsPerExercise { get; }
    }
}
