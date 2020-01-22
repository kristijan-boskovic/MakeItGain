using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinAssist.BaseLib
{
	public interface IAddNewAccountView
	{
		bool	ShowViewModal();

		string	AccountName { get; }
		string	AccountType { get; }
		float	InitialBalance { get; }
	}
}
