using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FinAssist.BaseLib;

namespace FinAssist.PresentationLayer
{
	public partial class frmAddAccount : Form, IAddNewAccountView
	{
		private readonly List<string> _accountTypes = null;
		 
		public frmAddAccount(List<string> inAccountTypes )
		{
			_accountTypes = inAccountTypes;

			InitializeComponent();
		}

		private void frmAddAccount_Load(object sender, EventArgs e)
		{
			foreach (string s in _accountTypes)
				cmbAccountType.Items.Add(s);
		}

		public bool ShowViewModal()
		{
			if (this.ShowDialog() == DialogResult.OK)
				return true;
			else
				return false;
		}

		public string AccountName => txtAccountName.Text;
		public string AccountType => cmbAccountType.SelectedItem.ToString();
		// ekvivalent
		// public string AccountType
		// {
		   //  get
		   //  {
				 //return cmbAccountType.SelectedText;
		   //  }
		// }

		public float InitialBalance
		{
			get
			{
				float balanceValue = 0;

				if( Single.TryParse(txtInitialBalance.Text, out balanceValue) == true )
					return balanceValue;

				throw new ArgumentException();
			}
		}

        private void cmbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
