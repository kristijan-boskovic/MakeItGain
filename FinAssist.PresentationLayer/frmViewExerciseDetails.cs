using System;
using System.Windows.Forms;
using FinAssist.BaseLib;
using FinAssist.Model;

namespace FinAssist.PresentationLayer
{
    public partial class frmViewExerciseDetails : Form, IShowExerciseDetails
    {
        public frmViewExerciseDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        public void ShowExerciseDetails(Exercise exercise)
        {
            lblExerciseDescription.Text = exercise.Description;
            var photoName = exercise.PhotoAbbv;
            switch (photoName)
            {
                case "bench_press":
                    pctrBoxExercise.Image = Properties.Resources.bench_press;
                    break;
                case "military_press":
                    pctrBoxExercise.Image = Properties.Resources.military_press;
                    break;
                case "deadlift":
                    pctrBoxExercise.Image = Properties.Resources.deadlift;
                    break;
                case "squat":
                    pctrBoxExercise.Image = Properties.Resources.squat;
                    break;
                case "dumbbell_curl":
                    pctrBoxExercise.Image = Properties.Resources.dumbbell_curl;
                    break;
                case "rope_pushdown":
                    pctrBoxExercise.Image = Properties.Resources.rope_pushdown;
                    break;
                case "pullup":
                    pctrBoxExercise.Image = Properties.Resources.pullup;
                    break;
                case "situp":
                    pctrBoxExercise.Image = Properties.Resources.situp;
                    break;
            }
            this.Text = exercise.ExerciseName;
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
