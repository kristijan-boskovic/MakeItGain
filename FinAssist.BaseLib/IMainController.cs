using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinAssist.Model.Repositories;

namespace FinAssist.BaseLib
{
	public interface IMainFormController
	{
		void AddAccount();
		void EditAccount(string accountName);


	}
}
