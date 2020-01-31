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


		public int getExerciseNum()
		{
			return _listExercises.Count;
		}

		public Exercise getExerciseByName(string exerciseName)
		{
			var exercise = (from l in _listExercises where l.ExerciseName == exerciseName select l).First();

			if (exercise != null)
            {
                return exercise;
            }

            throw new AccountDoesntExist(); // TODO: change
		}

		public Exercise getExerciseById(int exerciseId)
		{
			var exercise = (from l in _listExercises where l.Id == exerciseId select l).First();
			return exercise;
		}

        public List<Exercise> getExercisesByMuscleGroup(string muscleGroup)
        {
            var exercises = (from l in _listExercises where l.MuscleGroup.ToString() == muscleGroup select l).ToList();
            return exercises;
        }

        public List<Exercise> getAllExercises()
		{
			var exercises = _listExercises.OfType<Exercise>().ToList();
			return exercises;
		}

        public List<int> getAllExercisesIds()
		{
			var exercises = _listExercises.Select(x => x.Id).ToList();
            return exercises;
        }

        public int getNewId()
		{
			int nextID = _nextID;
			_nextID++;
			return nextID;
		}

		public void addExercise(Exercise exercise)
		{
			if (_listExercises.Any(x => x.ExerciseName == exercise.ExerciseName))
			{
				throw new AccountAlreadyExists(); // TODO: change
			}

			if (exercise.Id == Exercise.UndefinedExerciseId || _listExercises.Any(x => x.Id == exercise.Id) )		
				exercise.Id = getNewId();					// i redefinirati ga ako nije inicijaliziran

			_listExercises.Add(exercise);
		}

		public void deleteExercise(int exerciseId)
		{
			
		}
	}
}
