using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FinAssist.Model;
using FinAssist.Model.Repositories;
using FinAssist.BaseLib;

namespace FinAssist.Controllers
{
    public class WorkoutController
    {
        public void ViewWorkouts(IShowWorkoutsListView form, IWorkoutRepository workoutRepository, IMainController mainController)
        {
            List<Workout> workouts = workoutRepository.GetAllWorkouts();
            form.ShowWorkouts(mainController, workouts, workoutRepository);
        }

        public void ViewHistoryWorkoutDetails(IShowHistoryWorkoutDetails form, HistoryWorkout historyWorkout)
        {
            form.ShowHistoryWorkoutDetails(historyWorkout);
        }

        public void AddNewWorkout(IAddWorkoutView form, IWorkoutRepository workoutRepository, IExerciseRepository exerciseRepository)
        {
            if (form.ConfirmAddWorkout() == true)
            {
                try
                {
                    string workoutName = form.WorkoutName;
                    int setsPerExercise;

                    try
                    {
                        setsPerExercise = form.SetsPerExercise;
                        if (setsPerExercise < 1)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please input valid number of sets per exercise.");
                        return;
                    }

                    if (String.IsNullOrEmpty(workoutName))
                    {
                        MessageBox.Show("Please input your workout name.");
                        return;
                    }
                    List<string> exerciseNames = form.ExerciseNames;
                    int workoutId = workoutRepository.GetNewId();
                    List<Exercise> exercises = new List<Exercise>();

                    foreach (var exerciseName in exerciseNames)
                    {
                        var exercise = exerciseRepository.GetExerciseByName(exerciseName);
                        exercises.Add(exercise);
                    }
                    Workout newWorkout = new Workout(workoutId, workoutName, exercises, setsPerExercise);
                    workoutRepository.AddWorkout(newWorkout);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("EXCEPTION: " + ex.Message);
                    throw;
                }
            }
        }

        public void EditWorkout(IEditWorkoutView form, Workout workout, IWorkoutRepository workoutRepository, IExerciseRepository exerciseRepository)
        {
            if (form.ConfirmEditWorkout(workout) == true)
            {
                try
                {
                    string workoutName = form.WorkoutName;
                    int setsPerExercise;

                    try
                    {
                        setsPerExercise = form.SetsPerExercise;
                        if (setsPerExercise < 1)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please input valid number of sets per exercise.");
                        return;
                    }

                    if (String.IsNullOrEmpty(workoutName))
                    {
                        MessageBox.Show("Please input your workout name.");
                        return;
                    }
                    List<string> exerciseNames = form.ExerciseNames;
                    int workoutId = workout.Id;
                    List<Exercise> exercises = new List<Exercise>();

                    foreach (var exerciseName in exerciseNames)
                    {
                        var exercise = exerciseRepository.GetExerciseByName(exerciseName);
                        exercises.Add(exercise);
                    }
                    workout.WorkoutName = workoutName;
                    workout.Exercises = exercises;
                    workout.SetsPerExercise = setsPerExercise;
                    workoutRepository.EditWorkout(workout);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("EXCEPTION: " + ex.Message);
                    throw;
                }
            }
        }

        public void DeleteWorkout(Workout workout, IWorkoutRepository workoutRepository)
        {
            workoutRepository.DeleteWorkout(workout);
        }

        public void StartWorkout(IStartWorkoutView form, Workout workout, IWorkoutRepository workoutRepository, IMainController mainController)
        {
            form.ShowWorkoutSession(mainController, workout);
        }

        public void FinishWorkout(Workout workout, string duration, string date, int caloriesBurned, IWorkoutRepository workoutRepository, List<int> reps, List<int> weights)
        {
            workoutRepository.finishWorkout(workout, duration, date, caloriesBurned, reps, weights);
        }

        public void ViewHistoryWorkouts(IShowHistoryWorkoutsListView form, IWorkoutRepository workoutRepository, IMainController mainController)
        {
            List<HistoryWorkout> historyWorkouts = workoutRepository.GetAllHistoryWorkouts();
            form.ShowHistoryWorkouts(mainController, historyWorkouts);
        }
    }
}