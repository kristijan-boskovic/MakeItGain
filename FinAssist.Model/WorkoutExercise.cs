using System.Collections.Generic;

namespace FinAssist.Model
{
	public class WorkoutExercise : Exercise
	{
		public WorkoutExercise()
		{
		}

		public WorkoutExercise(int exerciseId, string exerciseName, MuscleGroup muscleGroup, Dictionary<int, int> numberOfSetsAndReps) : base(exerciseId, exerciseName, muscleGroup)
		{
            NumberOfSetsAndReps = numberOfSetsAndReps;
        }

        public Dictionary<int, int> NumberOfSetsAndReps { get; set; }
    }
}