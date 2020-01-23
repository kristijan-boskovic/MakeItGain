using System;
using FinAssist.BaseLib;
using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.Controllers
{
	public class MainController : IMainController
	{
		private bool _defaultModelLoaded = false;

		private readonly IWindowFormsFactory	_formsFactory = null;
		//private readonly IAccountRepository		_accountRepository = null;
        private readonly IExerciseRepository _exerciseRepository = null;
        //private readonly ITransactionRepository _transRepo = null;

        //public MainController(IWindowFormsFactory inFormFactory, IAccountRepository inAccountRepo, ITransactionRepository inTransRepo)
        //{
        //	_formsFactory = inFormFactory;
        //	_accountRepository = inAccountRepo;
        //    _transRepo = inTransRepo;
        //}
        public MainController(IWindowFormsFactory inFormFactory, IExerciseRepository exerciseRepository)
        {
            _formsFactory = inFormFactory;
            _exerciseRepository = exerciseRepository;
        }

        public void LoadDefaultModel()
		{
			if (_defaultModelLoaded == false)
			{
                //_accountRepository.addAccount(new CurrentAccount(1, "Tekući račun", 0.0F));
                //_accountRepository.addAccount(new CashAccount(2, "Gotovina", 100.0F));
                //_accountRepository.addAccount(new CreditCardAccount(3, "MasterCard kartica", -1000.0F));
                //_accountRepository.addAccount(new IncomeSourceAccount(4, "Plaća"));

                _exerciseRepository.addExercise(new DisplayExercise(1, "Bench press", MuscleGroup.CHEST, "Lie down on a flat bench under a barbell. Lower the barbell towards your chest, once it hits the chest, push it back up.", "bench_press"));
                _exerciseRepository.addExercise(new DisplayExercise(2, "Military press", MuscleGroup.SHOULDERS, "Stand up with a barbell resting on your upper chest. Press the weight straight up above your head, and then lower it back down.", "military_press"));
                _exerciseRepository.addExercise(new DisplayExercise(3, "Squat", MuscleGroup.LEGS, "Stand up with a barbell resting on your upper back. Squat down until your thighs are parallel to the floor and then stand back up.", "squat"));
                _exerciseRepository.addExercise(new DisplayExercise(4, "Deadlift", MuscleGroup.LEGS, "Stand up with a barbell resting on the floor in front of you. Grab the bar outside your thighs, arch your back, then simply stand up.", "deadlift"));

                _defaultModelLoaded = true;
			}
		}

		//public void AddAccount()
		//{
		//	var accController = new AccountController();

		//	var newFrm = _formsFactory.CreateAddNewAccountView(AccountTypesList.getAccountTypesList());

		//	accController.AddNewAccount(newFrm, _accountRepository);
		//}

		//public void EditAccount(string accountName)
		//{
		//	var accController = new AccountController();

		//	var newFrm = _formsFactory.CreateEditAccountView();

		//	accController.EditAccount(newFrm, accountName, _accountRepository);
		//}

		public void ShowExercises()
		{
			var exerciseController = new ExerciseController();
			var newFrm = _formsFactory.CreateShowExercisesListView();
            exerciseController.ViewExercises(newFrm, _exerciseRepository, this);
		}

        public void ViewExerciseDetails(DisplayExercise exercise)
        {
            var exerciseController = new ExerciseController();
            var newFrm = _formsFactory.CreateShowExercisesDetails();
            exerciseController.ViewExerciseDetails(newFrm, exercise);
        }
    }
}
