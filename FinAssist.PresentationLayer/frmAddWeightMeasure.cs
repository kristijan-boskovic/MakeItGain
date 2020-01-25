using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FinAssist.BaseLib;
using FinAssist.Model;

namespace FinAssist.PresentationLayer
{
	public partial class frmAddWeightMeasure : Form, IAddNewWeightMeasureView
	{		 
		public frmAddWeightMeasure()
		{
			InitializeComponent();
		}

		private void frmAddWeightMeasure_Load(object sender, EventArgs e)
		{

		}

		public bool ShowViewModal()
		{
			if (this.ShowDialog() == DialogResult.OK)
				return true;
			else
				return false;
		}

        public double CurrentWeight => Double.Parse(txtCurrentWeight.Text);
        public double GoalWeight => Double.Parse(txtGoalWeight.Text);

        private void btnAddNewWeightMeasure_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
