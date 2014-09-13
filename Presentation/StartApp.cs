using System;
using System.Windows.Forms;

namespace IBatisSqlMapSample.Presentation
{
	/// <summary>
	/// StartApp �̊T�v�̐����ł��B
	/// </summary>
	public class StartApp
	{

		private static readonly log4net.ILog _logger = 
			log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		/// <summary>
		/// �A�v���P�[�V�����̃��C�� �G���g�� �|�C���g�ł��B
		/// </summary>
		[STAThread]
		static void Main() 
		{
			try
			{
				_logger.Info("��iBATIS.NET�̃T���v�����N�����܂��B");
				frmBookView frmBook = new frmBookView();
				frmBook.ShowDialog();
			}
			catch(Exception ex)
			{
				_logger.Error("��iBATIS.NET�T���v���A�v���P�[�V�����̃G���[��",ex);
				MessageBox.Show("�\�����ʃG���[�������������߃A�v���P�[�V�������I�����܂��B\r�ڍׂ́ulog4net�v�̃��O�����m�F���������B",
				"iBatisSample",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			_logger.Info("��iBATIS.NET�̃T���v�����I�����܂��B");
		}
	}
}
