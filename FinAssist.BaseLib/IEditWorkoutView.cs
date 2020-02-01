﻿using FinAssist.Model;
using System.Collections.Generic;

namespace FinAssist.BaseLib
{
    public interface IEditWorkoutView
	{
		bool ConfirmEditWorkout(Workout workout);
		string	WorkoutName { get; }
		List<string> ExerciseNames { get; }
        int SetsPerExercise { get; }
    }
}
