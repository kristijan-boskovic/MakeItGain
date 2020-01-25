using FinAssist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinAssist.BaseLib
{
	public interface IAddNewWeightMeasureView
    {
		bool ShowViewModal();
		double	CurrentWeight { get; }
        double GoalWeight { get; }
    }
}
