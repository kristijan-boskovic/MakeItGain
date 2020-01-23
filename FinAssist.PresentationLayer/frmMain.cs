using System;
using System.Windows.Forms;

using FinAssist.Model;
using FinAssist.Controllers;

namespace FinAssist.PresentationLayer
{
	public partial class frmMain : Form
	{
		private readonly MainController _controller;

		public frmMain(MainController inController)
		{
			_controller = inController;
            _controller.LoadDefaultModel();
            InitializeComponent();
		}

		private void loadDefaultModelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//_controller.LoadDefaultModel();
		}

		private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//_controller.AddAccount();
		}

		private void viewExercisesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//_controller.ShowExercises();
		}

        private void addExpenditureToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//_controller.AddExpenditureTransaction();
		}

		private void addIncomeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// _controller.AddIncomeTransaction();
		}

		private void addTransferToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//_controller.AddTransferTransaction();
		}

		private void showSummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//_controller.ShowSummaryReport();
		}

		private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//_controller.ShowTransactions();
		}

		private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//_controller.ShowExpenditureCategories();
		}

		private void placesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// _controller.ShowExpenditurePlaces();
		}

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void workoutsButton_Click(object sender, EventArgs e)
        {
            _controller.ShowWorkouts();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            //_controller.ShowExercises();
        }

        private void exercisesButton_Click(object sender, EventArgs e)
        {
            _controller.ShowExercises();
        }

        private void trainerButton_Click(object sender, EventArgs e)
        {
            //_controller.ShowExercises();
        }


        private void bodyButton_Click(object sender, EventArgs e)
        {
            //_controller.ShowExercises();
        }
    }
}
