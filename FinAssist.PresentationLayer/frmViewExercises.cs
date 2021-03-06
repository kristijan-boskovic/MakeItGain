﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FinAssist.BaseLib;
using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.PresentationLayer
{
    public partial class frmViewExercises : Form, IShowExercisesListView
    {
	    private List<Exercise> _exercises = null;
	    private IMainController _mainController = null;
        private IExerciseRepository _exerciseRepository = null;

        public frmViewExercises()
        {
            InitializeComponent();
        }

        public void ShowExercises(IMainController mainController, List<Exercise> exercises, IExerciseRepository exerciseRepository)
        {
            _mainController = mainController;
            _exercises = exercises;
            _exerciseRepository = exerciseRepository;
            UpdateList();
            this.Show();
        }

        private void listExercises_DoubleClick(object sender, EventArgs e)
        {
            if (listExercises.SelectedItems[0] != null)
            {
                var index = listExercises.SelectedItems[0].Index;
                var chosenExercise = _exercises[index];
                _mainController.ViewExerciseDetails(chosenExercise);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void UpdateList()
        {
            listExercises.Items.Clear();

            for (int i = 0; i < _exercises.Count(); i++)
            {
                Exercise exercise = _exercises[i];
                string muscleGroup = exercise.MuscleGroup.ToString().ToLower();

                ListViewItem lvt = new ListViewItem(exercise.ExerciseName);
                lvt.SubItems.Add(muscleGroup);
                listExercises.Items.Add(lvt);
            }
        }

        private void frmViewExercises_Load(object sender, EventArgs e)
        {
            cmbMuscleGroup.SelectedItem = cmbMuscleGroup.Items[0];
        }

        private void cmbMuscleGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMuscleGroup = cmbMuscleGroup.SelectedItem.ToString();

            if (selectedMuscleGroup.Equals("all"))
            {
                _exercises = _exerciseRepository.GetAllExercises();
            }
            else
            {
                _exercises = _exerciseRepository.GetExercisesByMuscleGroup(selectedMuscleGroup.ToUpper());
            }

            UpdateList();
        }
    }
}
