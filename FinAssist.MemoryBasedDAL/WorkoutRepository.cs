using System;
using System.Collections.Generic;
using System.Linq;
using FinAssist.BaseLib;
using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.DAL.MemoryBased
{
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

        public Workout GetWorkoutById(int workoutId)
        {
            var workout = (from l in _listWorkouts where l.Id == workoutId select l).First();
            return workout;
        }

        public List<Workout> GetAllWorkouts()
		{
			List<Workout> workouts = _listWorkouts.OfType<Workout>().ToList();
            _nextId = workouts.Count + 1;
			return workouts;
		}

        public List<HistoryWorkout> GetAllHistoryWorkouts()
        {
            List<HistoryWorkout> historyWorkouts = _listHistoryWorkouts.OfType<HistoryWorkout>().ToList();
            return historyWorkouts;
        }

		public int GetNewId()
		{
			int nextID = _nextId;

			_nextId++;

			return nextID;
		}

		public void AddWorkout(Workout workout)
		{
			if (_listWorkouts.Any(x => x.WorkoutName == workout.WorkoutName))
			{
				throw new ExerciseAlreadyExists();
			}

			if (workout.Id == Workout.UndefinedExerciseId || _listWorkouts.Any(x => x.Id == workout.Id) )		
				workout.Id = GetNewId();

			_listWorkouts.Add(workout);

            NotifyObservers();
		}

        public void EditWorkout(Workout workout)
        {
            _listWorkouts.Find(x => x.Id == workout.Id).WorkoutName = workout.WorkoutName;
            _listWorkouts.Find(x => x.Id == workout.Id).Exercises = workout.Exercises;
        }

        public void DeleteWorkout(Workout workout)
        {
            _listWorkouts.RemoveAll(x => x.Id == workout.Id);
        }

        public void AddWorkoutToHistory(Workout workout, string duration, string date, int caloriesBurned, List<int> reps, List<int> weights)
        {
            HistoryWorkout historyWorkout = new HistoryWorkout(workout.Id, workout.WorkoutName, workout.Exercises, workout.SetsPerExercise, duration, date, caloriesBurned, reps, weights);
            _listHistoryWorkouts.Add(historyWorkout);
        }
    }
}
