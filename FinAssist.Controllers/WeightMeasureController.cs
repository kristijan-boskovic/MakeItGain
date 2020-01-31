using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinAssist.Model;
using FinAssist.Model.Repositories;
using FinAssist.BaseLib;

namespace FinAssist.Controllers
{
    public class WeightMeasureController
    {
        public void ViewWeightMeasures(IShowWeightMeasuresListView form, IWeightMeasureRepository weightMeasureRepository, IMainController mainController)
        {
            // dohvati sve accounte i proslijedi ih View-u
            List<WeightMeasure> weightMeasures = weightMeasureRepository.getAllWeightMeasures();

            // zašto proslijeđujemo i mainController?
            // zato što na ovom View-u imamo "Add new account" i "Edit new account" funkcionalnost!
            form.ShowWeightMeasures(mainController, weightMeasures, weightMeasureRepository);
        }

        public void AddNewWeightMeasure(IAddNewWeightMeasureView form, IWeightMeasureRepository weightMeasureRepository)
        {
            if (form.ShowViewModal() == true)
            {
                try
                {
                    double currentWeight;
                    double goalWeight;

                    try
                    {
                        currentWeight = form.CurrentWeight;
                        goalWeight = form.GoalWeight;

                        if (currentWeight < 0 || goalWeight < 0)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please input valid weights.");
                        return;
                    }

                    int weightMeasureId = weightMeasureRepository.getNewId();
                    WeightMeasure weightMeasure = new WeightMeasure(weightMeasureId, currentWeight, goalWeight, DateTime.Now.ToString("dd/MM/yyyy"));
                    weightMeasureRepository.addWeightMeasure(weightMeasure);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("EXCEPTION: " + ex.Message);
                    throw;
                }
            }
        }
    }
}