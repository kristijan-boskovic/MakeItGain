namespace FinAssist.BaseLib
{
    public interface IWindowFormsFactory
	{
        IShowExercisesListView CreateShowExercisesListView();
        IShowExerciseDetails CreateShowExercisesDetails();
        IShowWorkoutsListView CreateShowWorkoutsListView();
        IAddWorkoutView CreateAddNewWorkoutView();
        IEditWorkoutView CreateEditWorkoutView();
        IStartWorkoutView CreateStartWorkoutView();
        IShowHistoryWorkoutsListView CreateShowHistoryWorkoutsListView();
        IShowHistoryWorkoutDetails CreateShowHistoryWorkoutDetails();
        IShowWeightMeasuresListView CreateShowWeightMeasuresListView();
        IAddWeightMeasureView CreateAddNewWeightMeasureView();
    }
}
