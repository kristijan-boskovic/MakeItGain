using System.Collections.Generic;
using System.Linq;

using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.DAL.MemoryBased
{
	// Ilustracija implementacije In-Memory repozitorija korištenjem Singleton patterna
	public class WorkoutRepository : IWorkoutRepository
    {
		private static int _nextId = 1;
		private static WorkoutRepository _instance;

		private readonly List<Workout>	_listWorkouts = new List<Workout>();

		private WorkoutRepository()
		{
		}

		public static WorkoutRepository getInstance()
		{
			return _instance ?? (_instance = new WorkoutRepository());
		}


		public int	getWorkoutNum()
		{
			return _listWorkouts.Count;
		}

		public Workout getWorkoutByName(string workoutName)
		{
			//foreach (var acc in _listAccounts)
			//	if (acc.Name == inAccName)
			//		return acc;

			var workout = (from l in _listWorkouts where l.WorkoutName == workoutName select l).First();

			if (workout != null)
            {
                return workout;
            }

            throw new AccountDoesntExist(); // TODO: change
		}

		public Workout getWorkoutById(int workoutId)
		{
			var workout = (from l in _listWorkouts where l.Id == workoutId select l).First();
			return workout;
		}

		public List<Workout> getAllWorkouts()
		{
			List<Workout> workouts = _listWorkouts.OfType<Workout>().ToList();
            _nextId = workouts.Count + 1;
			return workouts;
		}

        public List<int> getAllWorkoutsIds()
		{
			return _listWorkouts.Select(x => x.Id).ToList();
		}

		//public List<int> getAllAccountsOfType(AccountTypesList.AccountTypesEnum inType)
		//{
		//	return (from acc in _listExercises where AccountTypesList.isAccountOfType(acc, inType) == true select acc.Id).ToList();
		//}

		public int getNewId()
		{
			int nextID = _nextId;

			_nextId++;

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

		public void addWorkout(Workout workout)
		{
			// provjeriti da li već postoji account s tim imenom
			if (_listWorkouts.Any(x => x.WorkoutName == workout.WorkoutName))
			{
				throw new AccountAlreadyExists(); // TODO: change
			}

			// što ćemo s ID-jem?
			// provjeriti ćemo da li je neinicijaliziran ilii možda taj Id već postoji
			if (workout.Id == Workout.UndefinedExerciseId || _listWorkouts.Any(x => x.Id == workout.Id) )		
				workout.Id = getNewId();					// i redefinirati ga ako nije inicijaliziran

			_listWorkouts.Add(workout);
		}

        public void editWorkout(Workout workout)
        {
            _listWorkouts.Find(x => x.Id == workout.Id).WorkoutName = workout.WorkoutName;
            _listWorkouts.Find(x => x.Id == workout.Id).Exercises = workout.Exercises;
        }

        public void deleteWorkout(int workoutId)
        {

        }
    }
}
