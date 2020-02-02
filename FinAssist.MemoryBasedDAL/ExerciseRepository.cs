using System.Collections.Generic;
using System.Linq;
using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.DAL.MemoryBased
{
	public class ExerciseRepository : IExerciseRepository
	{
		private static int _nextID = 1;
		private static ExerciseRepository _instance;
		private readonly List<Exercise>	_listExercises = new List<Exercise>();

		private ExerciseRepository()
		{

		}

		public static ExerciseRepository getInstance()
		{
			return _instance ?? (_instance = new ExerciseRepository());
		}

		public Exercise GetExerciseByName(string exerciseName)
		{
			var exercise = (from l in _listExercises where l.ExerciseName == exerciseName select l).First();

			if (exercise != null)
            {
                return exercise;
            }

            throw new ExerciseDoesntExist();
		}

        public List<Exercise> GetExercisesByMuscleGroup(string muscleGroup)
        {
            var exercises = (from l in _listExercises where l.MuscleGroup.ToString() == muscleGroup select l).ToList();
            return exercises;
        }

        public List<Exercise> GetAllExercises()
		{
			var exercises = _listExercises.OfType<Exercise>().ToList();
			return exercises;
		}

        public int GetNewId()
		{
			int nextID = _nextID;
			_nextID++;
			return nextID;
		}

		public void AddExercise(Exercise exercise)
		{
			if (_listExercises.Any(x => x.ExerciseName == exercise.ExerciseName))
			{
				throw new ExerciseAlreadyExists();
			}

			if (exercise.Id == Exercise.UndefinedExerciseId || _listExercises.Any(x => x.Id == exercise.Id) )		
				exercise.Id = GetNewId();

			_listExercises.Add(exercise);
		}
    }
}
