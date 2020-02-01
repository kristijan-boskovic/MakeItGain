using System;
using System.Windows.Forms;
using FinAssist.Controllers;

namespace FinAssist.PresentationLayer
{
    public partial class frmMain : Form
	{
		private readonly MainController _controller;

		public frmMain(MainController inController)
		{
            _controller = inController;
            _controller.LoadDefaultModels();
            InitializeComponent();
		}

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void workoutsButton_Click(object sender, EventArgs e)
        {
            _controller.ShowWorkouts();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            _controller.ShowHistoryWorkouts();
        }

        private void exercisesButton_Click(object sender, EventArgs e)
        {
            _controller.ShowExercises();
        }

        private void bodyButton_Click(object sender, EventArgs e)
        {
            _controller.ShowWeightMeasures();
        }
    }
}
