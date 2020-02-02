using FinAssist.DAL.MemoryBased;
using FinAssist.Model;
using System.Collections.Generic;
using Xunit;

namespace MakeItGain.MemoryBasedDAL.Tests
{
    public class WorkoutRepositoryTests
    {
        private WorkoutRepository _workoutRepository;
        private ExerciseRepository _exerciseRepository;
        private Exercise _benchPress;
        private Exercise _militaryPress;
        private Exercise _squat;
        private Exercise _deadlift;

        public WorkoutRepositoryTests()
        {
            System.Reflection.FieldInfo fiw = typeof(WorkoutRepository).GetField("_instance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
            Assert.NotNull(fiw);
            fiw.SetValue(null, null);
            _workoutRepository = WorkoutRepository.getInstance();

            System.Reflection.FieldInfo fie = typeof(ExerciseRepository).GetField("_instance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
            Assert.NotNull(fie);
            fie.SetValue(null, null);
            _exerciseRepository = ExerciseRepository.getInstance();

            PrepareData();
        }

        [Fact]
        public void GetAllWorkouts_ReturnsAllWorkouts()
        {
            // Act
            var workouts = _workoutRepository.GetAllWorkouts();

            // Assert
            Assert.NotNull(workouts);
        }

        [Fact]
        public void GetAllHistoryWorkouts_ReturnsAllHistoryWorkouts()
        {
            // Act
            var historyWorkouts = _workoutRepository.GetAllHistoryWorkouts();

            // Assert
            Assert.NotNull(historyWorkouts);
        }

        [Fact]
        public void AddWorkout_AddsNewWorkout()
        {
            // Act
            var workouts = _workoutRepository.GetAllWorkouts();

            // Assert
            Assert.Equal(3, workouts.Count);

            // Act
            Workout workout = new Workout(4, "Push", new List<Exercise>() { _benchPress, _militaryPress }, 5);
            _workoutRepository.AddWorkout(workout);
            workouts = _workoutRepository.GetAllWorkouts();

            // Assert
            Assert.Equal(4, workouts.Count);
        }

        [Fact]
        public void EditWorkout_EditsExistingWorkout()
        {
            // Act
            var workoutId = 3;
            var workout = _workoutRepository.GetWorkoutById(workoutId);

            // Assert
            Assert.Equal("Full body", workout.WorkoutName);

            // Act
            workout.WorkoutName = "Full body training";
            _workoutRepository.EditWorkout(workout);
            workout = _workoutRepository.GetWorkoutById(workoutId);

            // Assert
            Assert.Equal("Full body training", workout.WorkoutName);
        }

        [Fact]
        public void DeleteWorkout_DeletesExistingWorkout()
        {
            // Act
            var workoutId = 1;
            var workout = _workoutRepository.GetWorkoutById(workoutId);
            var workouts = _workoutRepository.GetAllWorkouts();

            // Assert
            Assert.Equal(3, workouts.Count);

            // Act
            _workoutRepository.DeleteWorkout(workout);
            workouts = _workoutRepository.GetAllWorkouts();

            // Assert
            Assert.Equal(2, workouts.Count);
        }

        [Fact]
        public void AddWorkoutToHistory_AddsFinishedWorkoutToHistory()
        {
            // Act
            var workoutId = 1;
            var workout = _workoutRepository.GetWorkoutById(workoutId);
            var historyWorkouts = _workoutRepository.GetAllHistoryWorkouts();

            // Assert
            Assert.Single(historyWorkouts);

            // Act
            _workoutRepository.AddWorkoutToHistory(workout, "00:35:23", "02.02.2020", 297, new List<int>() { 10, 10, 10, 10, 10, 10, 10, 10 }, new List<int>() { 110, 110, 110, 110, 85, 85, 85, 85 });
            historyWorkouts = _workoutRepository.GetAllHistoryWorkouts();

            // Assert
            Assert.Equal(2, historyWorkouts.Count);
        }

        private void PrepareData()
        {
            _benchPress = new Exercise(1, "Bench press", MuscleGroup.CHEST, "Lie down on a flat bench under a barbell. Lower the barbell towards your chest, once it hits the chest, push it back up.", "bench_press");
            _militaryPress = new Exercise(2, "Military press", MuscleGroup.SHOULDERS, "Stand up with a barbell resting on your upper chest. Press the weight straight up above your head, and then lower it back down.", "military_press");
            _squat = new Exercise(3, "Squat", MuscleGroup.LEGS, "Stand up with a barbell resting on your upper back. Squat down until your thighs are parallel to the floor and then stand back up.", "squat");
            _deadlift = new Exercise(4, "Deadlift", MuscleGroup.LEGS, "Stand up with a barbell resting on the floor in front of you. Squat down and grab onto the bar outside your thighs. Arch your back and then simply stand up.", "deadlift");

            _exerciseRepository.AddExercise(_benchPress);
            _exerciseRepository.AddExercise(_militaryPress);
            _exerciseRepository.AddExercise(_squat);
            _exerciseRepository.AddExercise(_deadlift);

            _workoutRepository.AddWorkout(new Workout(1, "Upper body", new List<Exercise>() { _benchPress, _militaryPress }, 4));
            _workoutRepository.AddWorkout(new Workout(2, "Lower body", new List<Exercise>() { _squat, _deadlift }, 5));
            _workoutRepository.AddWorkout(new Workout(3, "Full body", new List<Exercise>() { _benchPress, _militaryPress, _squat, _deadlift }, 3));

            _workoutRepository.AddWorkoutToHistory(new Workout(1, "Upper body", new List<Exercise>() { _benchPress, _militaryPress }, 4), "00:44:23", "20.01.2020", 342, new List<int>() { 10, 10, 9, 9, 10, 10, 10, 9 }, new List<int>() { 90, 95, 100, 100, 70, 70, 75, 75 });
        }
    }
}