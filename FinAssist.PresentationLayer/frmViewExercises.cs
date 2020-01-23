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
    public partial class frmViewExercises : Form, IShowExercisesListView
    {
	    private List<DisplayExercise> _displayExercises = null;
	    private IMainController _mainController = null;

		public frmViewExercises()
        {
            InitializeComponent();
        }

        public void ShowModaless(IMainController mainController, List<DisplayExercise> displayExercises)
        {
            _mainController = mainController;
            _displayExercises = displayExercises;

            UpdateList();

            this.Show();
        }

        private void btnAddNewExercise_Click(object sender, EventArgs e)
        {
            //_mainController.AddAccount();
        }
        private void listExercises_DoubleClick(object sender, EventArgs e)
        {
            if (listExercises.SelectedItems[0] != null)
            {
                var index = listExercises.SelectedItems[0].Index;
                var chosenExercise = _displayExercises[index];
                _mainController.ViewExerciseDetails(chosenExercise);

                //_mainController.EditAccount(accountName);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void UpdateList()
        {
            for (int i = 0; i < _displayExercises.Count(); i++)
            {
                DisplayExercise displayExercise = _displayExercises[i];

                string muscleGroup = displayExercise.MuscleGroup.ToString().ToLower();
                //string accInitialBalance = acc.InitialBalance.ToString(CultureInfo.InvariantCulture);

                ListViewItem lvt = new ListViewItem(displayExercise.ExerciseName);
                lvt.SubItems.Add(muscleGroup);
                //lvt.SubItems.Add(accInitialBalance);

                listExercises.Items.Add(lvt);
            }
        }

        private void listExercises_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmViewExercises_Load(object sender, EventArgs e)
        {

        }
    }
}
