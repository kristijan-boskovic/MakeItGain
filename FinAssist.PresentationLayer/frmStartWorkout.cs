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
	public partial class frmStartWorkout : Form, IStartWorkoutView
	{		 
		public frmStartWorkout()
		{
			InitializeComponent();
		}

		private void frmStartWorkout_Load(object sender, EventArgs e)
		{

		}

        public void ShowWorkoutSession(Workout workout)
        {
            //labelExerciseDescription.Text = exercise.Description;
            //var photoName = exercise.PhotoAbbv;
            //switch (photoName)
            //{
            //    case "bench_press":
            //        pictureBoxExercise.Image = Properties.Resources.bench_press;
            //        break;
            //    case "military_press":
            //        pictureBoxExercise.Image = Properties.Resources.military_press;
            //        break;
            //    case "deadlift":
            //        pictureBoxExercise.Image = Properties.Resources.deadlift;
            //        break;
            //    case "squat":
            //        pictureBoxExercise.Image = Properties.Resources.squat;
            //        break;
            //}
            //this.Text = exercise.ExerciseName;
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

        }
    }
}
