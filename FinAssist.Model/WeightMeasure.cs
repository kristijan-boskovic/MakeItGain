namespace FinAssist.Model
{
    public class WeightMeasure : EntityBase<int>
	{
		public static readonly int UndefinedWeightMeasureId = -1;

		public WeightMeasure(int weightMeasureId, double currentWeight, double goalWeight, string dateOfMeasure) : base(weightMeasureId)
		{
            CurrentWeight = currentWeight;
            GoalWeight = goalWeight;
            DateOfMeasure = dateOfMeasure;

        }

        public double CurrentWeight { get; set; }
        public double GoalWeight { get; set; }
        public string DateOfMeasure { get; set; }
    }
}