using System;
using System.Windows.Forms;
using FinAssist.BaseLib;

namespace FinAssist.PresentationLayer
{
    public partial class frmAddWeightMeasure : Form, IAddWeightMeasureView
	{		 
		public frmAddWeightMeasure()
		{
			InitializeComponent();
		}

		private void frmAddWeightMeasure_Load(object sender, EventArgs e)
		{

		}

		public bool ConfirmAddWeight()
		{
			if (this.ShowDialog() == DialogResult.OK)
				return true;
			else
				return false;
		}

        public double CurrentWeight => Double.Parse(txtCurrentWeight.Text);
        public double GoalWeight => Double.Parse(txtGoalWeight.Text);

        private void btnAddWeightMeasure_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
