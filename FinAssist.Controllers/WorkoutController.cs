using System;
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

        public void AddNewWorkout(IAddNewWorkoutView inForm, IWorkoutRepository workoutRepository, IExerciseRepository exerciseRepository)
        {
            if (inForm.ShowViewModal() == true)
            {
                try
                {
                    string workoutName = inForm.WorkoutName;
                    if (String.IsNullOrEmpty(workoutName))
                    {
                        MessageBox.Show("Please input your workout name!");
                        return;
                    }
                    List<string> exerciseNames = inForm.ExerciseNames;
                    int workoutId = workoutRepository.getNewId();
                    List<Exercise> exercises = new List<Exercise>();

                    foreach (var exerciseName in exerciseNames)
                    {
                        var exercise = exerciseRepository.getExerciseByName(exerciseName);
                        exercises.Add(exercise);
                    }
                    //Account newAccount = AccountFactory.CreateAccount(ID, Name, AccType, Balance);
                    Workout newWorkout = new Workout(workoutId, workoutName, exercises, false, "", 0);
                    workoutRepository.addWorkout(newWorkout);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("EXCEPTION: " + ex.Message);
                    throw;
                }
            }
        }
    }
}