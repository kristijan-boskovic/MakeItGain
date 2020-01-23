using System.Collections.Generic;

namespace FinAssist.Model
{
	public class Exercise : EntityBase<int>
	{
		public static readonly int UndefinedExerciseId = -1;

		public Exercise() : base(UndefinedExerciseId)
		{
		}

		public Exercise(int exerciseId, string exerciseName, MuscleGroup muscleGroup, string description, string photoAbbv) : base(exerciseId)
		{
			ExerciseName = exerciseName;
            MuscleGroup = muscleGroup;
            Description = description;
            PhotoAbbv = photoAbbv;

        }

        public string ExerciseName { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
        public string Description { get; set; }
        public string PhotoAbbv { get; set; }
    }
}