namespace FinAssist.Model
{
	public class Exercise : EntityBase<int>
	{
		public static readonly int UndefinedExerciseId = -1;

		public Exercise() : base(UndefinedExerciseId)
		{
		}

		public Exercise(int exerciseId, string exerciseName, MuscleGroup muscleGroup) : base(exerciseId)
		{
			ExerciseName = exerciseName;
            MuscleGroup = muscleGroup;
        }

		public string ExerciseName { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
    }
}