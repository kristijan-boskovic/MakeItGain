using System;
using System.Windows.Forms;

using FinAssist.Model;
using FinAssist.Controllers;

namespace FinAssist.PresentationLayer
{
	public partial class frmMainWindow : Form
	{
		private readonly MainFormController _controller;

		public frmMainWindow(MainFormController inController)
		{
			_controller = inController;

			InitializeComponent();
		}

		private void loadDefaultModelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_controller.LoadDefaultModel();
		}

		private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_controller.AddAccount();
		}

		private void viewAccountsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_controller.ShowAccounts();
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

        private void frmMainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
