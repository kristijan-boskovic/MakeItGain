using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FinAssist.BaseLib;
using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.PresentationLayer
{
    public partial class frmViewWeightMeasures : Form, IShowWeightMeasuresListView, IObserver
    {
        private List<WeightMeasure> _weightMeasures = null;
        private IMainController _mainController = null;
        private IWeightMeasureRepository _weightMeasureRepository = null;


        public frmViewWeightMeasures()
        {
            InitializeComponent();
        }

        public void ShowWeightMeasures(IMainController mainController, List<WeightMeasure> weightMeasures, IWeightMeasureRepository weightMeasureRepository)
        {
            _mainController = mainController;
            _weightMeasures = weightMeasures;
            _weightMeasureRepository = weightMeasureRepository;
            UpdateList();
            this.Show();
        }

        public void UpdateList()
        {
            listWeightMeasures.Items.Clear();

            for (int i = 0; i < _weightMeasures.Count(); i++)
            {
                WeightMeasure weightMeasure = _weightMeasures[i];

                ListViewItem lvt = new ListViewItem(weightMeasure.DateOfMeasure);
                lvt.SubItems.Add(weightMeasure.CurrentWeight.ToString() + " kg");
                lvt.SubItems.Add(weightMeasure.GoalWeight.ToString() + " kg");

                double weightToLose = weightMeasure.CurrentWeight - weightMeasure.GoalWeight;
                if (weightToLose <= 0)
                {
                    lvt.SubItems.Add("Goal reached!");
                }
                else
                {
                    lvt.SubItems.Add(weightToLose.ToString() + " kg");
                }

                listWeightMeasures.Items.Add(lvt);
            }
        }

        private void frmViewWeightMeasures_Load(object sender, EventArgs e)
        {

        }

        private void btnAddWeightMeasure_Click(object sender, EventArgs e)
        {
            _mainController.AddWeightMeasure();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateObserved()
        {
            _weightMeasures = _weightMeasureRepository.GetAllWeightMeasures();
            UpdateList();
        }
    }
}
