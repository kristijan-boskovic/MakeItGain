using FinAssist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinAssist.BaseLib
{
	public interface IAddNewWorkoutView
	{
		bool ShowViewModal();
		string	WorkoutName { get; }
		List<string> ExerciseNames { get; }
		//float	InitialBalance { get; }
	}
}
