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
	public partial class frmAddWorkout : Form, IAddNewWorkoutView
	{		 
		public frmAddWorkout()
		{
			InitializeComponent();
		}

		private void frmAddWorkout_Load(object sender, EventArgs e)
		{

		}

		public bool ShowViewModal()
		{
			if (this.ShowDialog() == DialogResult.OK)
				return true;
			else
				return false;
		}

        public string WorkoutName => txtWorkoutName.Text;

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

        private void btnAddNewWorkout_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
