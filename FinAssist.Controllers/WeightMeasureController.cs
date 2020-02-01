using System;
using System.Collections.Generic;
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
            List<WeightMeasure> weightMeasures = weightMeasureRepository.GetAllWeightMeasures();
            form.ShowWeightMeasures(mainController, weightMeasures, weightMeasureRepository);
        }

        public void AddNewWeightMeasure(IAddWeightMeasureView form, IWeightMeasureRepository weightMeasureRepository)
        {
            if (form.ConfirmAddWeight() == true)
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

                    int weightMeasureId = weightMeasureRepository.GetNewId();
                    WeightMeasure weightMeasure = new WeightMeasure(weightMeasureId, currentWeight, goalWeight, DateTime.Now.ToString("dd/MM/yyyy"));
                    weightMeasureRepository.AddWeightMeasure(weightMeasure);
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