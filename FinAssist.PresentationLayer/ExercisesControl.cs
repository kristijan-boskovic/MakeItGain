using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinAssist.Model;
using FinAssist.BaseLib;
using FinAssist.Controllers;

namespace FinAssist.PresentationLayer
{
    public partial class ExercisesControl : UserControl
    {
        private List<DisplayExercise> _displayExercises = null;
        private MainController _controller;

        public ExercisesControl()
        {
            InitializeComponent();
        }

        public void ShowModaless(MainController mainController, List<DisplayExercise> displayExercises)
        {
            _controller = mainController;
            _displayExercises = displayExercises;

            UpdateList();

            this.Show();
        }

        private void ExercisesControl_Load(object sender, EventArgs e)
        {

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

                listDiplayExercises.Items.Add(lvt);
            }
        }

        private void listAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
