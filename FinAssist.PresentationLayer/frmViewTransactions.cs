using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinAssist.PresentationLayer
{
    public partial class frmViewTransactions : Form
    {
		//private TransactionRepository refTransRep;

		//public frmViewTransactions(TransactionRepository inTransRep)
		//{
		//    refTransRep = inTransRep;

		//    InitializeComponent();
		//}

		private void frmViewTransactions_Load(object sender, EventArgs e)
		{
			UpdateList();
		}

		private void UpdateList()
		{
		//    for(int i=0; i<refTransRep.Count; i++ )
		//    {
		//        Transaction trans = refTransRep.getTransactionByIndex(i);

		//        string transType = "TODO";
		//        string transDesc = "TODO";

		//        ListViewItem lvt = new ListViewItem(trans.TransDate.ToShortDateString());
		//        lvt.SubItems.Add(trans.FromAcc.Name);
		//        lvt.SubItems.Add(trans.ToAcc.Name);
		//        lvt.SubItems.Add(trans.Amount.ToString());
		//        lvt.SubItems.Add(transType);
		//        lvt.SubItems.Add(transDesc);

		//        listTransaction.Items.Add(lvt);
		//    }
		}
	}
}
