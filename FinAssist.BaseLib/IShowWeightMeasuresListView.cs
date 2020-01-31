using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.BaseLib
{
	public interface IShowWeightMeasuresListView : IObserver
    {
		void ShowWeightMeasures(IMainController mainController, List<WeightMeasure> weightMeasuresList, IWeightMeasureRepository weightMeasureRepository);
	}
}
