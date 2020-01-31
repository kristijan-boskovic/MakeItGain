using System.Collections.Generic;
using System.Linq;
using FinAssist.BaseLib;
using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.DAL.MemoryBased
{
	// Ilustracija implementacije In-Memory repozitorija korištenjem Singleton patterna
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


		public int getWeightMeasureNum()
		{
			return _listWeightMeasures.Count;
		}

		public WeightMeasure getWeightMeasureById(int weightMeasureId)
		{
			var weightMeasure = (from l in _listWeightMeasures where l.Id == weightMeasureId select l).First();
			return weightMeasure;
		}

		public List<WeightMeasure> getAllWeightMeasures()
		{
			List<WeightMeasure> weightMeasures = _listWeightMeasures.OfType<WeightMeasure>().ToList();

			return weightMeasures;
		}

        public List<int> getAllWeightMeasuresIds()
		{
			return _listWeightMeasures.Select(x => x.Id).ToList();
		}

		public int getNewId()
		{
			int nextID = _nextID;

			_nextID++;

			return nextID;
		}

		public void addWeightMeasure(WeightMeasure weightMeasure)
		{
			if (weightMeasure.Id == WeightMeasure.UndefinedWeightMeasureId || _listWeightMeasures.Any(x => x.Id == weightMeasure.Id))
            {
                weightMeasure.Id = getNewId();
            }
            _listWeightMeasures.Add(weightMeasure);
            NotifyObservers();
        }
    }
}
