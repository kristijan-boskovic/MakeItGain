using FinAssist.Model;

namespace FinAssist.BaseLib
{
    public interface IStartWorkoutView
	{
        void ShowWorkoutSession(IMainController mainController, Workout workout);
    }
}
