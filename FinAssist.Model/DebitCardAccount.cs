using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinAssist.Model
{
	public class DebitCardAccount : AccountWithBalance
	{
		public DebitCardAccount(int inID, string inName)
			: base(inID, inName)
		{
		}

		public DebitCardAccount(int inID, string inName, float inBalance)
			: base(inID, inName, inBalance)
		{
		}
	}
}
