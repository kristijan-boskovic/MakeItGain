using System.Collections.Generic;
using System.Text;

namespace FinAssist.Model
{
    public class HistoryWorkout : Workout
	{
		public HistoryWorkout(int workoutId, string workoutName, List<Exercise> exercises, int setsPerExercise, string duration, string date, int caloriesBurned, List<int> reps, List<int> weights) : base(workoutId, workoutName, exercises, setsPerExercise)
		{
            Duration = duration;
            Date = date;
            CaloriesBurned = caloriesBurned;
            Reps = reps;
            Weights = weights;
        }

        public string Duration { get; set; }
        public string Date { get; set; }
        public int CaloriesBurned { get; set; }
        List<int> Reps { get; set; }
        List<int> Weights { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("", 200);
            for (int i = 0; i < Exercises.Count; i++)
            {
                int counter = 0;
                sb.Append(Exercises[i].ExerciseName + ": ");
                for (int j = 0; j < Reps.Count; j++)
                {
                    int rep = Reps[j];
                    counter++;
                    if (counter > SetsPerExercise)
                    {
                        counter = 1;
                        i++;
                        sb.Append("\r\n" + Exercises[i].ExerciseName + ": ");
                        if (i > Exercises.Count)
                        {
                            break;
                        }
                    }
                    sb.Append(rep + " x " + Weights[j] + " kg, ");
                }

                sb.Append("\r\n");
            }
            sb.Append("\r\n");
            sb.Append("Duration: " + Duration + "\r\n" + "\r\n");
            sb.Append("Calories burned: " + CaloriesBurned + " kcal" + "\r\n" + "\r\n");

            return sb.ToString();
        }
    }
}