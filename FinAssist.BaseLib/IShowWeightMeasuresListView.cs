using System.Collections.Generic;

using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.BaseLib
{
    public interface IShowWeightMeasuresListView : IObserver
    {
		void ShowWeightMeasures(IMainController mainController, List<WeightMeasure> weightMeasuresList, IWeightMeasureRepository weightMeasureRepository);
	}
}
