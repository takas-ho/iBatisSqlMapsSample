using System;

namespace IBatisSqlMapSample.Domain.Exceptions
{
	/// <summary>
	/// DomainException の概要の説明です。
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
