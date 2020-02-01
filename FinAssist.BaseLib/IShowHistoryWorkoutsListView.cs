using System.Collections.Generic;

using FinAssist.Model;

namespace FinAssist.BaseLib
{
    public interface IShowHistoryWorkoutsListView
	{
		void ShowHistoryWorkouts(IMainController mainController, List<HistoryWorkout> historyWorkoutList);
	}
}
