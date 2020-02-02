using FinAssist.DAL.MemoryBased;
using FinAssist.Model;
using Xunit;

namespace MakeItGain.MemoryBasedDAL.Tests
{
    public class WeightMeasureRepositoryTests
    {
        private WeightMeasureRepository _weightMeasureRepository;

        public WeightMeasureRepositoryTests()
        {
            System.Reflection.FieldInfo fi = typeof(WeightMeasureRepository).GetField("_instance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
            Assert.NotNull(fi);
            fi.SetValue(null, null);
            _weightMeasureRepository = WeightMeasureRepository.getInstance();
            PrepareData();
        }

        [Fact]
        public void GetAllWeightMeasures_ReturnsAllWeightMeasures()
        {
            // Act
            var weightMeasures = _weightMeasureRepository.GetAllWeightMeasures();

            // Assert
            Assert.NotNull(weightMeasures);
        }

        [Fact]
        public void AddWeightMeasure_AddsNewWeightMeasure()
        {
            // Act
            var weightMeasures = _weightMeasureRepository.GetAllWeightMeasures();

            // Assert
            Assert.Equal(2, weightMeasures.Count);

            // Act
            _weightMeasureRepository.AddWeightMeasure(new WeightMeasure(3, 98.0, 90.0, "02.02.2020"));
            weightMeasures = _weightMeasureRepository.GetAllWeightMeasures();

            // Assert
            Assert.Equal(3, weightMeasures.Count);
        }

        private void PrepareData()
        {
            _weightMeasureRepository.AddWeightMeasure(new WeightMeasure(1, 103.5, 90.0, "10.01.2020"));
            _weightMeasureRepository.AddWeightMeasure(new WeightMeasure(2, 102.0, 90.0, "20.01.2020"));
        }
    }
}