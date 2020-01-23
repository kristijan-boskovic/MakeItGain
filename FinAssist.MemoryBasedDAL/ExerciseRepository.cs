using System.Collections.Generic;
using System.Linq;

using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.DAL.MemoryBased
{
	// Ilustracija implementacije In-Memory repozitorija korištenjem Singleton patterna
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


		public int	getExerciseNum()
		{
			return _listExercises.Count;
		}

		public Exercise getExerciseByName(string exerciseName)
		{
			//foreach (var acc in _listAccounts)
			//	if (acc.Name == inAccName)
			//		return acc;

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

		public List<DisplayExercise> getAllDisplayExercises()
		{
			List<DisplayExercise> displayExercises = _listExercises.OfType<DisplayExercise>().ToList();

			return displayExercises;
		}

        public List<WorkoutExercise> getAllWorkoutExercises()
        {
            List<WorkoutExercise> workoutExercises = _listExercises.OfType<WorkoutExercise>().ToList();

            return workoutExercises;
        }

        public List<int> getAllExercisesIds()
		{
			return _listExercises.Select(x => x.Id).ToList();
		}

		//public List<int> getAllAccountsOfType(AccountTypesList.AccountTypesEnum inType)
		//{
		//	return (from acc in _listExercises where AccountTypesList.isAccountOfType(acc, inType) == true select acc.Id).ToList();
		//}

		public int getNewId()
		{
			int nextID = _nextID;

			_nextID++;

			return nextID;
		}

		//public bool doesAccountExists(string inAccName)
		//{
		//	var acc = (from l in _listExercises where l.Name == inAccName select l).First();

		//	return acc != null;
		//}

		//public ExpenditureSinkAccount getExpSinkAccount()
		//{
		//	foreach (var acc in _listExercises)
		//		if (acc is ExpenditureSinkAccount)
		//			return acc as ExpenditureSinkAccount;

		//	throw new NoExpSinkAccountException();
		//}

		public void addExercise(Exercise exercise)
		{
			// provjeriti da li već postoji account s tim imenom
			if (_listExercises.Any(x => x.ExerciseName == exercise.ExerciseName))
			{
				throw new AccountAlreadyExists(); // TODO: change
			}

			// što ćemo s ID-jem?
			// provjeriti ćemo da li je neinicijaliziran ilii možda taj Id već postoji
			if (exercise.Id == Exercise.UndefinedExerciseId || _listExercises.Any(x => x.Id == exercise.Id) )		
				exercise.Id = getNewId();					// i redefinirati ga ako nije inicijaliziran

			_listExercises.Add(exercise);
		}

		public void deleteExercise(int exerciseId)
		{
			
		}

	}
}
