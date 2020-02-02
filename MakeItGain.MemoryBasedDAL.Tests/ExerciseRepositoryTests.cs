using FinAssist.DAL.MemoryBased;
using FinAssist.Model;
using Xunit;

namespace MakeItGain.MemoryBasedDAL.Tests
{
    public class ExerciseRepositoryTests
    {
        private ExerciseRepository _exerciseRepository;

        public ExerciseRepositoryTests()
        {
            System.Reflection.FieldInfo fi = typeof(ExerciseRepository).GetField("_instance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
            Assert.NotNull(fi);
            fi.SetValue(null, null);
            _exerciseRepository = ExerciseRepository.getInstance();
            PrepareData();
        }

        [Fact]
        public void GetAllExercises_ReturnsAllExercises()
        {
            // Act
            var exercises = _exerciseRepository.GetAllExercises();

            // Assert
            Assert.NotNull(exercises);
        }

        [Fact]
        public void GetExercisesByMuscleGroup_ReturnsFilteredExercises()
        {
            // Act
            var filteredExercises = _exerciseRepository.GetExercisesByMuscleGroup("LEGS");

            // Assert
            Assert.Equal(2, filteredExercises.Count);
        }

        [Fact]
        public void AddExercise_AddsNewExercise()
        {
            // Act
            var exercises = _exerciseRepository.GetAllExercises();

            // Assert
            Assert.Equal(8, exercises.Count);

            // Act
            Exercise dumbbellFly = new Exercise(9, "Dumbbell fly", MuscleGroup.CHEST, "Lie down on a regular bench with dumbbells in your hands. Raise the dumbbells above your chest and then lower them out to your sides. Raise the dumbbells back to starting position.", "dumbbell_fly");
            _exerciseRepository.AddExercise(dumbbellFly);
            exercises = _exerciseRepository.GetAllExercises();

            // Assert
            Assert.Equal(9, exercises.Count);
        }

        private void PrepareData()
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
        }
    }
}