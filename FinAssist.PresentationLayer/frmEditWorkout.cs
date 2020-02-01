using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FinAssist.BaseLib;
using FinAssist.Model;

namespace FinAssist.PresentationLayer
{
    public partial class frmEditWorkout : Form, IEditWorkoutView
	{		 
		public frmEditWorkout()
		{
			InitializeComponent();
		}

		private void frmEditWorkout_Load(object sender, EventArgs e)
		{

		}

		public bool ConfirmEditWorkout(Workout workout)
		{
            txtWorkoutName.Text = workout.WorkoutName;
            txtSetsPerExercise.Text = workout.SetsPerExercise.ToString();

            List<int> exerciseIds = new List<int>();

            foreach (var exercise in workout.Exercises)
            {
                exerciseIds.Add(exercise.Id - 1);
            }

            foreach (var exerciseId in exerciseIds)
            {
                chkdListBoxExercises.SetItemChecked(exerciseId, true);
            }

            if (this.ShowDialog() == DialogResult.OK)
				return true;
			else
				return false;
		}

        public string WorkoutName => txtWorkoutName.Text;
        public int SetsPerExercise => Int32.Parse(txtSetsPerExercise.Text);

        public List<string> ExerciseNames
        {
			get
			{
                var checkedItems = chkdListBoxExercises.CheckedItems;
                List<string> exerciseNames = new List<string>();
                foreach(var checkedItem in checkedItems)
                {
                    exerciseNames.Add(checkedItem.ToString());
                }
                return exerciseNames;
            }
		}

        private void btnEditWorkout_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
