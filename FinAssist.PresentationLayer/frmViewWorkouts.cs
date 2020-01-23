using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FinAssist.BaseLib;
using FinAssist.Controllers;
using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.PresentationLayer
{
    public partial class frmViewWorkouts : Form, IShowWorkoutsListView
    {
        //private List<DisplayExercise> _displayExercises = null;
        private List<Workout> _workouts = null;
        private IMainController _mainController = null;

		public frmViewWorkouts()
        {
            InitializeComponent();
        }

        public void ShowWorkouts(IMainController mainController, List<Workout> workouts)
        {
            _mainController = mainController;
            _workouts = workouts;

            UpdateList();

            this.Show();
        }

        private void btnAddNewWorkout_Click(object sender, EventArgs e)
        {
            //_mainController.AddAccount();
        }
        private void listWorkouts_DoubleClick(object sender, EventArgs e)
        {
            //if (listWorkouts.SelectedItems[0] != null)
            //{
            //    var index = listWorkouts.SelectedItems[0].Index;
            //    var chosenWorkout = _workouts[index];
            //    _mainController.ViewWorkoutDetails(chosenWorkout);

            //    //_mainController.EditAccount(accountName);
            //}
        }
        private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void UpdateList()
        {
            for (int i = 0; i < _workouts.Count(); i++)
            {
                Workout workout = _workouts[i];

                //string muscleGroup = displayExercise.MuscleGroup.ToString().ToLower();
                //string accInitialBalance = acc.InitialBalance.ToString(CultureInfo.InvariantCulture);

                ListViewItem lvt = new ListViewItem((i+1).ToString());
                lvt.SubItems.Add(workout.WorkoutName);
                //lvt.SubItems.Add(accInitialBalance);

                listWorkouts.Items.Add(lvt);
            }
        }

        private void listWorkouts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmViewWorkouts_Load(object sender, EventArgs e)
        {

        }
    }
}
