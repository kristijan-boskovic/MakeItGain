using System;
using System.Collections.Generic;
using System.Text;

namespace FinAssist.Model
{
	public class HistoryWorkout : Workout
	{

		public HistoryWorkout()
		{

		}

		public HistoryWorkout(int workoutId, string workoutName, List<Exercise> exercises, int setsPerExercise, string duration, string date, int caloriesBurned, List<int> reps) : base(workoutId, workoutName, exercises, setsPerExercise)
		{
            Duration = duration;
            Date = date;
            CaloriesBurned = caloriesBurned;
            Reps = reps;
        }

        public string Duration { get; set; }
        public string Date { get; set; }
        public int CaloriesBurned { get; set; }
        List<int> Reps { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("", 200);
            for (int i = 0; i < Exercises.Count; i++)
            {
                int counter = 0;
                sb.Append(Exercises[i].ExerciseName + " (reps per each set): ");
                foreach (var rep in Reps)
                {
                    counter++;
                    if (counter > SetsPerExercise)
                    {
                        counter = 0;
                        i++;
                        sb.Append("\r\n" + Exercises[i].ExerciseName + " (reps per set): ");
                        if (i > Exercises.Count)
                        {
                            break;
                        }
                    }
                    sb.Append(rep + " ");
                }

                sb.Append("\r\n");
            }
            sb.Append("\r\n");

            sb.Append("Sets per exercise: " + SetsPerExercise + "\r\n" + "\r\n");

            sb.Append("Duration: " + Duration + "\r\n" + "\r\n");

            sb.Append("Calories burned: " + CaloriesBurned + " kcal" + "\r\n" + "\r\n");

            return sb.ToString();
        }
    }
}