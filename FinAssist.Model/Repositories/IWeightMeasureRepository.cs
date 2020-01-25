using System.Collections.Generic;

namespace FinAssist.Model.Repositories
{
	public interface IWeightMeasureRepository
    {
		int getWeightMeasureNum();
        WeightMeasure getWeightMeasureById(int weightMeasureId);
		List<WeightMeasure> getAllWeightMeasures();
        List<int> getAllWeightMeasuresIds();
		int	getNewId();
		void addWeightMeasure(WeightMeasure weightMeasure);
	}
}