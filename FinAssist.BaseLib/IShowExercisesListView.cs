using System.Collections.Generic;
using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.BaseLib
{
    public interface IShowExercisesListView
	{
		void ShowExercises(IMainController mainController, List<Exercise> exerciseList, IExerciseRepository exerciseRepository);
	}
}
