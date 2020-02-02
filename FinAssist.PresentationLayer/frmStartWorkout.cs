using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using FinAssist.BaseLib;
using FinAssist.Model;

namespace FinAssist.PresentationLayer
{
    public partial class frmStartWorkout : Form, IStartWorkoutView
	{
        private IMainController _mainController = null;
        private Workout _workout = null;
        private int caloriesBurned;
        private Stopwatch stopWatch = new Stopwatch();
        private Dictionary<string, List<int>> setsAndReps = new Dictionary<string, List<int>>();
        private List<TextBox> repsInputs = new List<TextBox>();
        private List<TextBox> weightInputs = new List<TextBox>();


        public frmStartWorkout()
		{
			InitializeComponent();
		}

		private void frmStartWorkout_Load(object sender, EventArgs e)
		{
            stopWatch.Start();
            tmrWorkout.Start();
        }

        public void ShowWorkoutSession(IMainController mainController, Workout workout)
        {
            _workout = workout;
            _mainController = mainController;
            var numberOfExercises = workout.Exercises.Count; 

            for (int i = 0; i < numberOfExercises; i++)
            {
                setsAndReps.Add(workout.Exercises[i].ExerciseName, new List<int>());
                var numberOfSets = workout.SetsPerExercise;

                for (int j = 1; j <= numberOfSets; j++)
                {
                    Label repsLabel = new Label();
                    repsLabel.AutoSize = true;
                    repsLabel.Text = workout.Exercises[i].ExerciseName +  " set " + j + ":";
                    repsLabel.Left = 10;
                    repsLabel.Top = (j) * 20 + (i) * 120 + 3;

                    TextBox repsTextBox = new TextBox();
                    repsTextBox.Left = 130;
                    repsTextBox.Width = 35;
                    repsTextBox.Height = 20;
                    repsTextBox.Top = (j) * 20 + (i) * 120;

                    TextBox weightsTextBox = new TextBox();
                    weightsTextBox.Left = 170;
                    weightsTextBox.Width = 35;
                    weightsTextBox.Height = 20;
                    weightsTextBox.Top = (j) * 20 + (i) * 120;

                    this.Controls.Add(repsLabel);
                    this.Controls.Add(repsTextBox);
                    this.Controls.Add(weightsTextBox);
                    repsInputs.Add(repsTextBox);
                    weightInputs.Add(weightsTextBox);
                }
            }

            this.Show();
        }

        private void btnFinishWorkout_Click(object sender, EventArgs e)
        {
            List<int> reps = new List<int>();
            foreach (var repsInput in repsInputs)
            {
                if (String.IsNullOrEmpty(repsInput.Text) || repsInput.Text.StartsWith("-"))
                {
                    repsInput.Text = "0";
                }
                try
                {
                    reps.Add(Int32.Parse(repsInput.Text));
                }
                catch (Exception)
                {
                    repsInput.Text = "0";
                    reps.Add(Int32.Parse(repsInput.Text));
                }
            }

            List<int> weights = new List<int>();
            foreach (var weightInput in weightInputs)
            {
                if (String.IsNullOrEmpty(weightInput.Text) || weightInput.Text.StartsWith("-"))
                {
                    weightInput.Text = "0";
                }
                try
                {
                    weights.Add(Int32.Parse(weightInput.Text));
                }
                catch (Exception)
                {
                    weightInput.Text = "0";
                    weights.Add(Int32.Parse(weightInput.Text));
                }
            }

            stopWatch.Stop();
            tmrWorkout.Stop();
            TimeSpan timeElapsed = stopWatch.Elapsed;
            string duration = String.Format("{0:00}:{1:00}:{2:00}", timeElapsed.Hours, timeElapsed.Minutes, timeElapsed.Seconds);
            caloriesBurned = (int) Math.Round(timeElapsed.Seconds * 0.34);

            _mainController.AddWorkoutToHistory(_workout, duration, DateTime.Now.ToString("dd/MM/yyyy"), caloriesBurned, reps, weights);
            this.Close();
        }

        private void tmrWorkout_Tick(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = stopWatch.Elapsed;
            string duration = String.Format("{0:00}:{1:00}:{2:00}", timeElapsed.Hours, timeElapsed.Minutes, timeElapsed.Seconds);
            lblTimer.Text = duration;
        }
    }
}
