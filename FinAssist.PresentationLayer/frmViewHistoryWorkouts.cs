using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FinAssist.BaseLib;
using FinAssist.Model;

namespace FinAssist.PresentationLayer
{
    public partial class frmViewHistoryWorkouts : Form, IShowHistoryWorkoutsListView
    {
	    private List<HistoryWorkout> _historyWorkouts = null;
	    private IMainController _mainController = null;

		public frmViewHistoryWorkouts()
        {
            InitializeComponent();
        }

        public void ShowHistoryWorkouts(IMainController mainController, List<HistoryWorkout> historyWorkouts)
        {
            _mainController = mainController;
            _historyWorkouts = historyWorkouts;
            UpdateList();
            this.Show();
        }

        private void listHistoryWorkouts_DoubleClick(object sender, EventArgs e)
        {
            if (listHistoryWorkouts.SelectedItems[0] != null)
            {
                var index = listHistoryWorkouts.SelectedItems[0].Index;
                var chosenHistoryWorkout = _historyWorkouts[index];
                _mainController.ViewHistoryWorkoutDetails(chosenHistoryWorkout);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void UpdateList()
        {
            for (int i = 0; i < _historyWorkouts.Count(); i++)
            {
                HistoryWorkout historyWorkout = _historyWorkouts[i];
                ListViewItem lvt = new ListViewItem(historyWorkout.WorkoutName);
                lvt.SubItems.Add(historyWorkout.Date);
                listHistoryWorkouts.Items.Add(lvt);
            }
        }

        private void frmViewHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
