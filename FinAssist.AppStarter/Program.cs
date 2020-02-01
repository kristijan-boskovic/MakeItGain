using System;
using System.Windows.Forms;

using FinAssist.Controllers;
using FinAssist.PresentationLayer;
using FinAssist.DAL.MemoryBased;

namespace FinAssist.AppStarter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
			WindowFormsFactory _formsFactory = new WindowFormsFactory();
            MainController mainController = new MainController(_formsFactory, ExerciseRepository.getInstance(), WorkoutRepository.getInstance(), WeightMeasureRepository.getInstance());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(mainController));
        }
    }
}
