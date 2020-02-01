using System.Collections.Generic;

namespace FinAssist.Model.Repositories
{
	public interface IWeightMeasureRepository
    {
		int GetWeightMeasureNum();
        WeightMeasure GetWeightMeasureById(int weightMeasureId);
		List<WeightMeasure> GetAllWeightMeasures();
        List<int> GetAllWeightMeasuresIds();
		int	GetNewId();
		void AddWeightMeasure(WeightMeasure weightMeasure);
	}
}