using System;

namespace IBatisSqlMapSample.Domain.Exceptions
{
	/// <summary>
	/// DomainException �̊T�v�̐����ł��B
	/// </summary>
	public class DomainException : ApplicationException
	{
		public DomainException() : base()
		{
		}
		public DomainException(string message) : base(message)
		{
		}
		public DomainException(string message, Exception innerException) : base(message,innerException)
		{
		}
	}
}
