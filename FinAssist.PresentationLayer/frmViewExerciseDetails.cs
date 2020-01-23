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
    public partial class frmViewExerciseDetails : Form, IShowExerciseDetails
    {
	    private List<Exercise> _exercises = null;
	    private IMainController _mainController = null;

        public string AccountName => throw new NotImplementedException();

        public string AccountType => throw new NotImplementedException();

        public float InitialBalance => throw new NotImplementedException();

        public frmViewExerciseDetails()
        {
            InitializeComponent();
        }

        //public void ShowModaless()
        //{
        //    //_mainController = mainController;
        //    //_displayExercises = displayExercises;

        //    //UpdateList();

        //    this.Show();
        //}

        //private void btnAddNewExercise_Click(object sender, EventArgs e)
        //{
        //    //_mainController.AddAccount();
        //}
        //private void listExercises_DoubleClick(object sender, EventArgs e)
        //{
        //    if (listExercises.SelectedItems[0] != null)
        //    {
        //        int index = listExercises.SelectedItems[0].Index;
        //        string accountName = listExercises.SelectedItems[0].SubItems[0].Text;

        //        //_mainController.EditAccount(accountName);
        //    }
        //}
        private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        //private void UpdateList()
        //{
        //    for (int i = 0; i < _displayExercises.Count(); i++)
        //    {
        //        DisplayExercise displayExercise = _displayExercises[i];

        //        string muscleGroup = displayExercise.MuscleGroup.ToString().ToLower();
        //        //string accInitialBalance = acc.InitialBalance.ToString(CultureInfo.InvariantCulture);

        //        ListViewItem lvt = new ListViewItem(displayExercise.ExerciseName);
        //        lvt.SubItems.Add(muscleGroup);
        //        //lvt.SubItems.Add(accInitialBalance);

        //        listExercises.Items.Add(lvt);
        //    }
        //}

        //private void listExercises_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        public void ShowExerciseDetails(Exercise exercise)
        {
            exerciseDescriptionLabel.Text = exercise.Description;
            var photoName = exercise.PhotoAbbv;
            switch (photoName)
            {
                case "bench_press":
                    pictureBox1.Image = Properties.Resources.bench_press;
                    break;
                case "military_press":
                    pictureBox1.Image = Properties.Resources.military_press;
                    break;
                case "deadlift":
                    pictureBox1.Image = Properties.Resources.deadlift;
                    break;
                case "squat":
                    pictureBox1.Image = Properties.Resources.squat;
                    break;
            }
            this.Show();
        }

        private void frmViewExerciseDetails_Load(object sender, EventArgs e)
        {

        }

        private void exerciseDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
