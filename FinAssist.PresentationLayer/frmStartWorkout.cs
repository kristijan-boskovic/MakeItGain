using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public frmStartWorkout()
		{
			InitializeComponent();
		}

		private void frmStartWorkout_Load(object sender, EventArgs e)
		{
            stopWatch.Start();
            timerWorkout.Start();
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
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Text = workout.Exercises[i].ExerciseName +  " set " + j + ":";
                    label.Left = 10;
                    label.Top = (j) * 20 + (i) * 120 + 3;

                    TextBox textBox = new TextBox();
                    textBox.Left = 130;
                    textBox.Width = 35;
                    textBox.Height = 20;
                    textBox.Top = (j) * 20 + (i) * 120;

                    this.Controls.Add(label);
                    this.Controls.Add(textBox);
                    repsInputs.Add(textBox);
                }
            }

            this.Show();
        }

        //public string WorkoutName => txtSetsPerExercise.Text;

  //      public List<string> ExerciseNames
  //      {
		//	get
		//	{
  //              var checkedItems = chkdListBoxExercises.CheckedItems;
  //              List<string> exerciseNames = new List<string>();
  //              foreach(var checkedItem in checkedItems)
  //              {
  //                  exerciseNames.Add(checkedItem.ToString());
  //              }
  //              return exerciseNames;
  //          }
		//}

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
            stopWatch.Stop();
            timerWorkout.Stop();
            TimeSpan timeElapsed = stopWatch.Elapsed;
            string duration = String.Format("{0:00}:{1:00}:{2:00}", timeElapsed.Hours, timeElapsed.Minutes, timeElapsed.Seconds);
            caloriesBurned = (int) Math.Round(timeElapsed.Seconds * 0.34);

            _mainController.FinishWorkout(_workout, duration, DateTime.Now.ToString("dd/MM/yyyy"), caloriesBurned, reps);
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = stopWatch.Elapsed;
            string duration = String.Format("{0:00}:{1:00}:{2:00}", timeElapsed.Hours, timeElapsed.Minutes, timeElapsed.Seconds);
            labelTimer.Text = duration;
        }

        private void labelTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
