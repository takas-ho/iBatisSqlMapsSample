using System;
using System.Windows.Forms;

namespace IBatisSqlMapSample.Presentation
{
	/// <summary>
	/// StartApp の概要の説明です。
	/// </summary>
	public class StartApp
	{

		private static readonly log4net.ILog _logger = 
			log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			try
			{
				_logger.Info("●iBATIS.NETのサンプルを起動します。");
				frmBookView frmBook = new frmBookView();
				frmBook.ShowDialog();
			}
			catch(Exception ex)
			{
				_logger.Error("★iBATIS.NETサンプルアプリケーションのエラー★",ex);
				MessageBox.Show("予期せぬエラーが発生したためアプリケーションを終了します。\r詳細は「log4net」のログをご確認ください。",
				"iBatisSample",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			_logger.Info("●iBATIS.NETのサンプルを終了します。");
		}
	}
}
