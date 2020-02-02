using System.Collections.Generic;

namespace FinAssist.Model.Repositories
{
	public interface IWeightMeasureRepository
    {
		List<WeightMeasure> GetAllWeightMeasures();
		int	GetNewId();
		void AddWeightMeasure(WeightMeasure weightMeasure);
    }
}