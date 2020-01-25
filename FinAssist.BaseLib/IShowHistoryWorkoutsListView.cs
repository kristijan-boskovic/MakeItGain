using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinAssist.Model;

namespace FinAssist.BaseLib
{
	public interface IShowHistoryWorkoutsListView
	{
		void ShowHistoryWorkouts(IMainController mainController, List<HistoryWorkout> historyWorkoutList);
	}
}
