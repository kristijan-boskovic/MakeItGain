using FinAssist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinAssist.BaseLib
{
	public interface IEditWorkoutView
	{
		bool ShowViewModal(Workout workout);
		string	WorkoutName { get; }
		List<string> ExerciseNames { get; }
	}
}
