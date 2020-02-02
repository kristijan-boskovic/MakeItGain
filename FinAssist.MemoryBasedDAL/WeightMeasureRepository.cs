using System.Collections.Generic;
using System.Linq;
using FinAssist.BaseLib;
using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.DAL.MemoryBased
{
	public class WeightMeasureRepository : Subject, IWeightMeasureRepository
	{
		private static int _nextID = 1;
		private static WeightMeasureRepository _instance;

		private readonly List<WeightMeasure>	_listWeightMeasures = new List<WeightMeasure>();

		private WeightMeasureRepository()
		{

		}

		public static WeightMeasureRepository getInstance()
		{
			return _instance ?? (_instance = new WeightMeasureRepository());
		}

		public List<WeightMeasure> GetAllWeightMeasures()
		{
			List<WeightMeasure> weightMeasures = _listWeightMeasures.OfType<WeightMeasure>().ToList();

			return weightMeasures;
		}

		public int GetNewId()
		{
			int nextID = _nextID;

			_nextID++;

			return nextID;
		}

		public void AddWeightMeasure(WeightMeasure weightMeasure)
		{
			if (weightMeasure.Id == WeightMeasure.UndefinedWeightMeasureId || _listWeightMeasures.Any(x => x.Id == weightMeasure.Id))
            {
                weightMeasure.Id = GetNewId();
            }
            _listWeightMeasures.Add(weightMeasure);
            NotifyObservers();
        }
    }
}
