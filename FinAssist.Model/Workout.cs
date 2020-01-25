using System;
using System.Collections.Generic;

namespace FinAssist.Model
{
	public class Workout : EntityBase<int>
	{
		public static readonly int UndefinedExerciseId = -1;

		public Workout() : base(UndefinedExerciseId)
		{
		}

		public Workout(int workoutId, string workoutName, List<Exercise> exercises, int setsPerExercise) : base(workoutId)
		{
			WorkoutName = workoutName;
            Exercises = exercises;
            SetsPerExercise = setsPerExercise;
        }

		public string WorkoutName { get; set; }
        public List<Exercise> Exercises { get; set; }
        public int SetsPerExercise { get; set; }
    }
}