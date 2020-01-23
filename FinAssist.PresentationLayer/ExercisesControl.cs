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
        private List<Exercise> _exercises = null;
        private MainController _controller;

        public ExercisesControl()
        {
            InitializeComponent();
        }

        public void ShowModaless(MainController mainController, List<Exercise> exercises)
        {
            _controller = mainController;
            _exercises = exercises;

            UpdateList();

            this.Show();
        }

        private void ExercisesControl_Load(object sender, EventArgs e)
        {

        }

        private void UpdateList()
        {
            for (int i = 0; i < _exercises.Count(); i++)
            {
                Exercise exercise = _exercises[i];

                string muscleGroup = exercise.MuscleGroup.ToString().ToLower();
                //string accInitialBalance = acc.InitialBalance.ToString(CultureInfo.InvariantCulture);

                ListViewItem lvt = new ListViewItem(exercise.ExerciseName);
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
