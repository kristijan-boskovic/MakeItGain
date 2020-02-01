using System;
using System.Collections.Generic;
using System.Linq;
using FinAssist.BaseLib;
using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.DAL.MemoryBased
{
	// Ilustracija implementacije In-Memory repozitorija korištenjem Singleton patterna
	public class WorkoutRepository : Subject, IWorkoutRepository
    {
		private static int _nextId = 1;
		private static WorkoutRepository _instance;

		private readonly List<Workout>	_listWorkouts = new List<Workout>();
        private readonly List<HistoryWorkout> _listHistoryWorkouts = new List<HistoryWorkout>();

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

        public List<HistoryWorkout> getAllHistoryWorkouts()
        {
            List<HistoryWorkout> historyWorkouts = _listHistoryWorkouts.OfType<HistoryWorkout>().ToList();
            //_nextId = workouts.Count + 1;
            return historyWorkouts;
        }


        public List<int> getAllWorkoutsIds()
		{
			return _listWorkouts.Select(x => x.Id).ToList();
		}

		public int getNewId()
		{
			int nextID = _nextId;

			_nextId++;

			return nextID;
		}

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

            NotifyObservers();
		}

        public void editWorkout(Workout workout)
        {
            _listWorkouts.Find(x => x.Id == workout.Id).WorkoutName = workout.WorkoutName;
            _listWorkouts.Find(x => x.Id == workout.Id).Exercises = workout.Exercises;
        }

        public void deleteWorkout(Workout workout)
        {
            _listWorkouts.RemoveAll(x => x.Id == workout.Id);
        }

        public void startWorkout(Workout workout)
        {
            
        }

        public void finishWorkout(Workout workout, string duration, string date, int caloriesBurned, List<int> reps, List<int> weights)
        {
            HistoryWorkout historyWorkout = new HistoryWorkout(workout.Id, workout.WorkoutName, workout.Exercises, workout.SetsPerExercise, duration, date, caloriesBurned, reps, weights);
            _listHistoryWorkouts.Add(historyWorkout);
        }
    }
}
