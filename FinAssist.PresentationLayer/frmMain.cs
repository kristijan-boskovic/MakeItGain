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
            //var n = 5;
            //for (int i = 0; i < n; i++)
            //{
            //    //Create label
            //    Label label = new Label();
            //    label.Text = String.Format("Label {0}", i);
            //    //Position label on screen
            //    label.Left = 10;
            //    label.Top = (i + 1) * 20;
            //    //Create textbox
            //    TextBox textBox = new TextBox();
            //    //Position textbox on screen
            //    textBox.Left = 120;
            //    textBox.Top = (i + 1) * 20;
            //    //Add controls to form
            //    this.Controls.Add(label);
            //    this.Controls.Add(textBox);
            //}
            _controller = inController;
            _controller.LoadDefaultModel();
            InitializeComponent();
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
            _controller.ShowHistoryWorkouts();
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
