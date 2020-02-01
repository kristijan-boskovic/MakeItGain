using System.Collections.Generic;

using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.BaseLib
{
    public interface IShowWorkoutsListView : IObserver
	{
		void ShowWorkouts(IMainController mainController, List<Workout> workoutList, IWorkoutRepository workoutRepository);
	}
}
