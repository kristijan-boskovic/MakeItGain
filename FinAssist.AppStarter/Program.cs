using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using FinAssist.Controllers;
using FinAssist.PresentationLayer;
using FinAssist.DAL.MemoryBased;

namespace FinAssist.AppStarter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			WindowFormsFactory _formsFactory = new WindowFormsFactory();

			// umjesto Singleton patterna, imati ćemo samo jednu instancu repozitorija unutar glavnog programa
			TransactionRepository _transRepo = new TransactionRepository();

			// a za Account repozitorij koristimo Singleton
			MainFormController mainController = new MainFormController(_formsFactory, AccountRepository.getInstance(), _transRepo);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FinAssist.PresentationLayer.frmMainWindow(mainController));
            Application.Run(new Form1());

        }
    }
}
