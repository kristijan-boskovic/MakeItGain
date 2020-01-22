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
    public partial class frmViewAccounts : Form, IShowAccountsListView
    {
	    private List<AccountWithBalance> _listAccounts = null;
	    private IMainFormController _mainController = null;

		public frmViewAccounts()
        {
            InitializeComponent();
        }

	    public void ShowModaless(IMainFormController inMainController, List<AccountWithBalance> inListAccounts)
	    {
		    _mainController = inMainController;
		    _listAccounts = inListAccounts;

			UpdateList();

			this.Show();
		}

        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
	        _mainController.AddAccount();
        }
		private void listAccounts_DoubleClick(object sender, EventArgs e)
		{
			if (listAccounts.SelectedItems[0] != null)
			{
				int ind = listAccounts.SelectedItems[0].Index;
				string accountName = listAccounts.SelectedItems[0].SubItems[0].Text;

				_mainController.EditAccount(accountName);
			}
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void UpdateList()
        {
			for (int i = 0; i < _listAccounts.Count(); i++)
			{
				AccountWithBalance acc = _listAccounts[i];

				string accType = AccountTypesList.getAccountTypeName(acc);
				string accInitialBalance = acc.InitialBalance.ToString(CultureInfo.InvariantCulture);

				ListViewItem lvt = new ListViewItem(acc.Name);
				lvt.SubItems.Add(accType);
				lvt.SubItems.Add(accInitialBalance);

				listAccounts.Items.Add(lvt);
			}
		}


	}
}
