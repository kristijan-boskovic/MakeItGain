using System;

namespace FinAssist.Model
{
	[Serializable]
	public class FinAssistBaseException : Exception
	{
	}

	[Serializable]
	public class NoExpSinkAccountException : FinAssistBaseException
	{
	}

	[Serializable]
	public class AccountDoesntExist : FinAssistBaseException
	{
	}

	[Serializable]
	public class AccountAlreadyExists : FinAssistBaseException
	{
	}

	[Serializable]
	public class ExpPlaceDoesntExist : FinAssistBaseException
	{
	}

	[Serializable]
	public class TransactionIndexException : FinAssistBaseException
	{
	}

	public class WrongAccountTypeNameInString : FinAssistBaseException
	{
	}

	public class AccountTypeNotInList : FinAssistBaseException
	{
	}

	public class TransactionIDAlreadyExists : FinAssistBaseException
	{
	}
}