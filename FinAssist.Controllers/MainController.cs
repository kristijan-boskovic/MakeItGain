﻿using System.Collections.Generic;
using FinAssist.BaseLib;
using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.Controllers
{
    public class MainController : IMainController
	{
		private bool _defaultModelLoaded = false;

		private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IExerciseRepository _exerciseRepository = null;
        private readonly IWorkoutRepository _workoutRepository = null;
        private readonly IWeightMeasureRepository _weightMeasureRepository = null;

        public MainController(IWindowFormsFactory inFormFactory, IExerciseRepository exerciseRepository, IWorkoutRepository workoutRepository, IWeightMeasureRepository weightMeasureRepository)
        {
            _formsFactory = inFormFactory;
            _exerciseRepository = exerciseRepository;
            _workoutRepository = workoutRepository;
            _weightMeasureRepository = weightMeasureRepository;
        }

        public void LoadDefaultModels()
		{
			if (_defaultModelLoaded == false)
			{
                Exercise benchPress = new Exercise(1, "Bench press", MuscleGroup.CHEST, "Lie down on a flat bench under a barbell. Lower the barbell towards your chest, once it hits the chest, push it back up.", "bench_press");
                Exercise militaryPress = new Exercise(2, "Military press", MuscleGroup.SHOULDERS, "Stand up with a barbell resting on your upper chest. Press the weight straight up above your head, and then lower it back down.", "military_press");
                Exercise squat = new Exercise(3, "Squat", MuscleGroup.LEGS, "Stand up with a barbell resting on your upper back. Squat down until your thighs are parallel to the floor and then stand back up.", "squat");
                Exercise deadlift = new Exercise(4, "Deadlift", MuscleGroup.LEGS, "Stand up with a barbell resting on the floor in front of you. Squat down and grab onto the bar outside your thighs. Arch your back and then simply stand up.", "deadlift");
                Exercise dumbbellCurl = new Exercise(5, "Dumbbell curl", MuscleGroup.BICEPS, "Stand up with one dumbbell in each hand. Curl the dumbbells up to shoulder level and then lower them back down.", "dumbbell_curl");
                Exercise ropePushDown = new Exercise(6, "Rope pushdown", MuscleGroup.TRICEPS, "Stand up in a cable machine. Grab the rope with both hands with your elbows tucked in at your sides. Push the rope down then bring it back up.", "rope_pushdown");
                Exercise pullUp = new Exercise(7, "Pullup", MuscleGroup.BACK, "Hang freely from a pullup bar with a little wider than shoulder width grip. Pull yourself up until your chin is above the bar, then lower yourself back down.", "pullup");
                Exercise situp = new Exercise(8, "Situp", MuscleGroup.ABS, "Lie down flat on your back and lift your torso with your hands behind your head. Once your torso is completely straight, lower yourself down to start position.", "situp");

                _exerciseRepository.AddExercise(benchPress);
                _exerciseRepository.AddExercise(militaryPress);
                _exerciseRepository.AddExercise(squat);
                _exerciseRepository.AddExercise(deadlift);
                _exerciseRepository.AddExercise(dumbbellCurl);
                _exerciseRepository.AddExercise(ropePushDown);
                _exerciseRepository.AddExercise(pullUp);
                _exerciseRepository.AddExercise(situp);

                _workoutRepository.AddWorkout(new Workout(1, "Upper body", new List<Exercise>() { benchPress, militaryPress }, 4));
                _workoutRepository.AddWorkout(new Workout(2, "Lower body", new List<Exercise>() { squat, deadlift }, 5));
                _workoutRepository.AddWorkout(new Workout(3, "Full body", new List<Exercise>() { benchPress, militaryPress, squat, deadlift }, 3));

                _workoutRepository.AddWorkoutToHistory(new Workout(1, "Upper body", new List<Exercise>() { benchPress, militaryPress }, 4), "00:44:23", "20.01.2020", 342, new List<int>() { 10, 10, 9, 9, 10, 10, 10, 9 }, new List<int>() { 90, 95, 100, 100, 70, 70, 75, 75 });

                _weightMeasureRepository.AddWeightMeasure(new WeightMeasure(1, 103.5, 90.0, "10.01.2020"));
                _weightMeasureRepository.AddWeightMeasure(new WeightMeasure(2, 102.0, 90.0, "20.01.2020"));

                _defaultModelLoaded = true;
			}
		}

        public void ShowExercises()
		{
			var exerciseController = new ExerciseController();
			var newFrm = _formsFactory.CreateShowExercisesListView();
            exerciseController.ViewExercises(newFrm, _exerciseRepository, this);
		}

        public void ViewExerciseDetails(Exercise exercise)
        {
            var exerciseController = new ExerciseController();
            var newFrm = _formsFactory.CreateShowExercisesDetails();
            exerciseController.ViewExerciseDetails(newFrm, exercise);
        }

        public void ShowWorkouts()
        {
            var workoutController = new WorkoutController();
            var newFrm = _formsFactory.CreateShowWorkoutsListView();
            workoutController.ViewWorkouts(newFrm, _workoutRepository, this);
        }

        public void AddWorkout()
        {
            var workoutController = new WorkoutController();
            var newFrm = _formsFactory.CreateAddNewWorkoutView();
            workoutController.AddNewWorkout(newFrm, _workoutRepository, _exerciseRepository);
        }

        public void EditWorkout(Workout workout)
        {
            var workoutController = new WorkoutController();
            var newFrm = _formsFactory.CreateEditWorkoutView();
            workoutController.EditWorkout(newFrm, workout, _workoutRepository, _exerciseRepository);
        }

        public void DeleteWorkout(Workout workout)
        {
            var workoutController = new WorkoutController();
            workoutController.DeleteWorkout(workout, _workoutRepository);
        }

        public void StartWorkout(Workout workout)
        {
            var workoutController = new WorkoutController();
            var newFrm = _formsFactory.CreateStartWorkoutView();
            workoutController.StartWorkout(newFrm, workout, _workoutRepository, this);
        }

        public void AddWorkoutToHistory(Workout workout, string duration, string date, int caloriesBurned, List<int> reps, List<int> weights)
        {
            var workoutController = new WorkoutController();
            workoutController.AddWorkoutToHistory(workout, duration, date, caloriesBurned, _workoutRepository, reps, weights);
        }

        public void ShowHistoryWorkouts()
        {
            var workoutController = new WorkoutController();
            var newFrm = _formsFactory.CreateShowHistoryWorkoutsListView();
            workoutController.ViewHistoryWorkouts(newFrm, _workoutRepository, this);
        }

        public void ViewHistoryWorkoutDetails(HistoryWorkout historyWorkout)
        {
            var workoutController = new WorkoutController();
            var newFrm = _formsFactory.CreateShowHistoryWorkoutDetails();
            workoutController.ViewHistoryWorkoutDetails(newFrm, historyWorkout);
        }

        public void ShowWeightMeasures()
        {
            var weightMeasureController = new WeightMeasureController();
            var newFrm = _formsFactory.CreateShowWeightMeasuresListView();
            weightMeasureController.ViewWeightMeasures(newFrm, _weightMeasureRepository, this);
        }

        public void AddWeightMeasure()
        {
            var weightMeasureController = new WeightMeasureController();
            var newFrm = _formsFactory.CreateAddNewWeightMeasureView();
            weightMeasureController.AddNewWeightMeasure(newFrm, _weightMeasureRepository);
        }
    }
}
