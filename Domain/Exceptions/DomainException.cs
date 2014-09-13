using System;

namespace IBatisSqlMapSample.Domain.Exceptions
{
	/// <summary>
	/// DomainException ÇÃäTóvÇÃê‡ñæÇ≈Ç∑ÅB
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
