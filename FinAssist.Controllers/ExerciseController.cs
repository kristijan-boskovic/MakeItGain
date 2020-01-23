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
    public class ExerciseController
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

        public void ViewExercises(IShowExercisesListView form, IExerciseRepository exerciseRepository, IMainController mainController)
        {
            // dohvati sve accounte i proslijedi ih View-u
            List<DisplayExercise> displayExercises = exerciseRepository.getAllDisplayExercises();

            // zašto proslijeđujemo i mainController?
            // zato što na ovom View-u imamo "Add new account" i "Edit new account" funkcionalnost!
            form.ShowModaless(mainController, displayExercises);
        }

        public void ViewExerciseDetails(IShowExerciseDetails form, DisplayExercise exercise)
        {
            form.ShowExerciseDetails(exercise);
        }
    }
}