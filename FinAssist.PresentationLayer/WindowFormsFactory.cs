using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinAssist.BaseLib;
using FinAssist.Model.Repositories;

namespace FinAssist.PresentationLayer
{
	public class WindowFormsFactory : IWindowFormsFactory
	{
		public IAddNewAccountView CreateAddNewAccountView(List<string> inAccType ) {
			var newFrm = new frmAddAccount(inAccType);

			return newFrm;
		}
		public IShowAccountsListView CreateShowAccountsListView() {
			var newFrm = new frmViewAccounts();

			return newFrm;
		}
		public IEditAccountView CreateEditAccountView() {
			var newFrm = new frmEditAccount();

			return newFrm;
		}
	}
}
