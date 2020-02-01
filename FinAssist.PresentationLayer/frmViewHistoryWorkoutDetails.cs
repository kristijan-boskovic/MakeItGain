using System;
using System.Windows.Forms;
using FinAssist.BaseLib;
using FinAssist.Model;

namespace FinAssist.PresentationLayer
{
    public partial class frmViewHistoryWorkoutDetails : Form, IShowHistoryWorkoutDetails
    {
        public frmViewHistoryWorkoutDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        public void ShowHistoryWorkoutDetails(HistoryWorkout historyWorkout)
        {
            lblHistoryWorkoutDetails.Text = historyWorkout.ToString();
            this.Text = historyWorkout.WorkoutName;
            this.Show();
        }

        private void frmViewHistoryWorkoutDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
