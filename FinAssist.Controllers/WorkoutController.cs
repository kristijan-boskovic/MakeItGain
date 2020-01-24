﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinAssist.Model;
using FinAssist.Model.Repositories;
using FinAssist.BaseLib;

namespace FinAssist.Controllers
{
    public class WorkoutController
    {
        //public void AddNewAccount(IAddNewAccountView inForm, IAccountRepository accountRepository)
        //{
        //	if (inForm.ShowViewModal() == true)
        //	{
        //		try
        //		{
        //			string Name = inForm.AccountName;
        //			string AccType = inForm.AccountType;
        //			float Balance = inForm.InitialBalance;

        //			int ID = accountRepository.getNewID();

        //			Account newAccount = AccountFactory.CreateAccount(ID, Name, AccType, Balance);

        //			accountRepository.addAccount(newAccount);
        //		}
        //		catch (Exception ex)
        //		{
        //			MessageBox.Show("EXCEPTION: " + ex.Message);
        //			throw;
        //		}
        //	}
        //}

        //public void EditAccount(IEditAccountView inForm, string accountName, IAccountRepository inRepo)
        //{

        //}

        public void ViewWorkouts(IShowWorkoutsListView form, IWorkoutRepository workoutRepository, IMainController mainController)
        {
            // dohvati sve accounte i proslijedi ih View-u
            List<Workout> workouts = workoutRepository.getAllWorkouts();

            // zašto proslijeđujemo i mainController?
            // zato što na ovom View-u imamo "Add new account" i "Edit new account" funkcionalnost!
            form.ShowWorkouts(mainController, workouts);
        }

        public void AddNewWorkout(IAddNewWorkoutView form, IWorkoutRepository workoutRepository, IExerciseRepository exerciseRepository)
        {
            if (form.ShowViewModal() == true)
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
                    int workoutId = workoutRepository.getNewId();
                    List<Exercise> exercises = new List<Exercise>();

                    foreach (var exerciseName in exerciseNames)
                    {
                        var exercise = exerciseRepository.getExerciseByName(exerciseName);
                        exercises.Add(exercise);
                    }
                    //Account newAccount = AccountFactory.CreateAccount(ID, Name, AccType, Balance);
                    Workout newWorkout = new Workout(workoutId, workoutName, exercises, false, "", 0, setsPerExercise);
                    workoutRepository.addWorkout(newWorkout);
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
            if (form.ShowViewModal(workout) == true)
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
                    //int workoutId = workoutRepository.getNewId();
                    int workoutId = workout.Id;
                    List<Exercise> exercises = new List<Exercise>();

                    foreach (var exerciseName in exerciseNames)
                    {
                        var exercise = exerciseRepository.getExerciseByName(exerciseName);
                        exercises.Add(exercise);
                    }
                    workout.WorkoutName = workoutName;
                    workout.Exercises = exercises;
                    workout.SetsPerExercise = setsPerExercise;
                    workoutRepository.editWorkout(workout);
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
            workoutRepository.deleteWorkout(workout);
        }

        public void StartWorkout(IStartWorkoutView form, Workout workout, IWorkoutRepository workoutRepository)
        {
            form.ShowWorkoutSession(workout);
        }
    }
}