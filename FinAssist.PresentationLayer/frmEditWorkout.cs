using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
			//foreach (string s in _accountTypes)
			//	cmbAccountType.Items.Add(s);
		}

		public bool ShowViewModal(Workout workout)
		{
            txtWorkoutName.Text = workout.WorkoutName;
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

		//public string AccountName => txtWorkoutName.Text;
		//public string AccountType => cmbAccountType.SelectedItem.ToString();
        public string WorkoutName => txtWorkoutName.Text;

        // ekvivalent
        // public string AccountType
        // {
        //  get
        //  {
        //return cmbAccountType.SelectedText;
        //  }
        // }

        public List<string> ExerciseNames
        {
			get
			{
				//float balanceValue = 0;

				////if( Single.TryParse(txtInitialBalance.Text, out balanceValue) == true )
				//	return balanceValue;

				//throw new ArgumentException();

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
