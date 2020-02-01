using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FinAssist.BaseLib;

namespace FinAssist.PresentationLayer
{
    public partial class frmAddWorkout : Form, IAddWorkoutView
	{		 
		public frmAddWorkout()
		{
			InitializeComponent();
		}

		private void frmAddWorkout_Load(object sender, EventArgs e)
		{

		}

		public bool ConfirmAddWorkout()
		{
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

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void chkdListBoxExercises_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelExercises_Click(object sender, EventArgs e)
        {

        }
    }
}
