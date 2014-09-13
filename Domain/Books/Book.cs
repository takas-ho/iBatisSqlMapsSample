using System;
using IBatisSqlMapSample.Domain.Exceptions;

namespace IBatisSqlMapSample.Domain.Books
{
	/// <summary>
	/// Book
	/// </summary>
	public class Book
	{
		private string _Isbn;
		private string _Title;
		private DateTime _SaleDate;
		private int _Price;

		public string Isbn 
		{
			get{ return _Isbn; }
			set
			{
				if (value.Length != 10)
				{
					throw new DomainException("ISBN���s���ł��B");
				}
				_Isbn = value; 
			}
		}

		public string IsbnWithHyphen
		{
			get{ return 
				_Isbn.Substring(0,1) + "-" + _Isbn.Substring(1,4) +	"-" + _Isbn.Substring(5,4) + "-" + _Isbn.Substring(9,1);
				}
		}

		public string Title 
		{
			get{ return _Title; }
			set{
				if (value == "")
				{
					throw new DomainException("�^�C�g�����s���ł��B");
				}				
				
				_Title = value; }
		}

		public DateTime SaleDate 
		{
			get{ return _SaleDate; }
			set{
				if (DateTime.Compare( value.Date , DateTime.Now) > 0)
				{
					throw new DomainException("���������s���ł��B");
				}
				_SaleDate = value; }
		}

		public int Price 
		{
			get{ return _Price; }
			set{
				if (value <= 0)
				{
					throw new DomainException("���i���s���ł��B");
				}
				_Price = value; }
		}
	}
}