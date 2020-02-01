namespace FinAssist.BaseLib
{
    public interface IAddWeightMeasureView
    {
		bool ConfirmAddWeight();
		double	CurrentWeight { get; }
        double GoalWeight { get; }
    }
}
