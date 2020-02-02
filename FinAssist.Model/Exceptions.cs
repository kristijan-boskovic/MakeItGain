using System;

namespace FinAssist.Model
{
	[Serializable]
	public class MakeItGainBaseException : Exception
	{

	}

	[Serializable]
	public class ExerciseDoesntExist : MakeItGainBaseException
	{

	}

	[Serializable]
	public class ExerciseAlreadyExists : MakeItGainBaseException
	{

	}
}