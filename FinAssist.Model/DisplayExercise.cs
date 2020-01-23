using System;

namespace FinAssist.Model
{
	public class DisplayExercise : Exercise
	{
		public DisplayExercise()
		{
		}

		public DisplayExercise(int exerciseId, string exerciseName, MuscleGroup muscleGroup, string description, string photoAbbv) : base(exerciseId, exerciseName, muscleGroup)
		{
            Description = description;
            PhotoAbbv = photoAbbv; // TODO: replace with actual photo
        }

        public string Description { get; set; }
        public string PhotoAbbv { get; set; }
    }
}