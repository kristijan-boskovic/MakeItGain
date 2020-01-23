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

		public Workout(int workoutId, string workoutName, List<Exercise> exercises, bool isActive, string time, int caloriesBurned) : base(workoutId)
		{
			WorkoutName = workoutName;
            Exercises = exercises;
            IsActive = isActive;
            Time = time;
            CaloriesBurned = caloriesBurned;
        }

		public string WorkoutName { get; set; }
        public List<Exercise> Exercises { get; set; }
        public bool IsActive { get; set; }
        public string Time { get; set; }
        public int CaloriesBurned { get; set; }

    }
}