﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinAssist.Model;

namespace FinAssist.BaseLib
{
	public interface IShowExercisesListView
	{
		void ShowExercises(IMainController mainController, List<Exercise> exerciseList);
	}
}
