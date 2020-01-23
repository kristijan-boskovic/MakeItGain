using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinAssist.BaseLib
{
	public interface IWindowFormsFactory
	{
		IAddNewAccountView CreateAddNewAccountView(List<string> inAccType);
		IEditAccountView CreateEditAccountView();
        IShowAccountsListView CreateShowAccountsListView();

        IShowExercisesListView CreateShowExercisesListView();
        IShowExerciseDetails CreateShowExercisesDetails();

    }
}
