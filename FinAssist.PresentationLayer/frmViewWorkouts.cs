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
    public partial class frmViewWorkouts : Form, IShowWorkoutsListView, IObserver
    {
        //private List<DisplayExercise> _displayExercises = null;
        private List<Workout> _workouts = null;
        private IMainController _mainController = null;
        private IWorkoutRepository _workoutRepository = null;

        public frmViewWorkouts()
        {
            InitializeComponent();
        }

        public void ShowWorkouts(IMainController mainController, List<Workout> workouts, IWorkoutRepository workoutRepository)
        {
            _mainController = mainController;
            _workouts = workouts;
            _workoutRepository = workoutRepository;

            UpdateList();

            this.Show();
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

        public void UpdateList()
        {
            listWorkouts.Items.Clear();

            for (int i = 0; i < _workouts.Count(); i++)
            {
                Workout workout = _workouts[i];

                ListViewItem lvt = new ListViewItem((i+1).ToString());
                lvt.SubItems.Add(workout.WorkoutName);

                string workoutExercises = "";
                foreach (var exercise in workout.Exercises)
                {
                    if (workoutExercises.Equals(""))
                    {
                        workoutExercises = exercise.ExerciseName;
                    }
                    else
                    {
                        workoutExercises += ", " + exercise.ExerciseName;
                    }
                }
                lvt.SubItems.Add(workout.SetsPerExercise.ToString());
                lvt.SubItems.Add(workoutExercises);

                listWorkouts.Items.Add(lvt);
            }
        }

        private void listWorkouts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmViewWorkouts_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewWorkout_Click(object sender, EventArgs e)
        {
            _mainController.AddWorkout();
        }

        private void btnDeleteWorkout_Click(object sender, EventArgs e)
        {
            try
            {
                if (listWorkouts.SelectedItems[0] != null)
                {
                    var index = listWorkouts.SelectedItems[0].Index;
                    var chosenWorkout = _workouts[index];
                    _mainController.DeleteWorkout(chosenWorkout);
                    UpdateObserved();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose a workout you want to delete.");
                return;
            }
        }

        private void btnEditWorkout_Click(object sender, EventArgs e)
        {
            try
            {
                if (listWorkouts.SelectedItems[0] != null)
                {
                    var index = listWorkouts.SelectedItems[0].Index;
                    var chosenWorkout = _workouts[index];
                    _mainController.EditWorkout(chosenWorkout);
                    UpdateObserved();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose a workout you want to edit.");
                return;
            }
        }

        private void btnStartWorkout_Click(object sender, EventArgs e)
        {
            try
            {
                if (listWorkouts.SelectedItems[0] != null)
                {
                    var index = listWorkouts.SelectedItems[0].Index;
                    var chosenWorkout = _workouts[index];
                    _mainController.StartWorkout(chosenWorkout);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose a workout you want to start.");
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateObserved()
        {
            _workouts = _workoutRepository.GetAllWorkouts();
            UpdateList();
        }
    }
}
