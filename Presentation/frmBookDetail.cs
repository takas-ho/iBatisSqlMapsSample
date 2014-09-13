using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using IBatisNet.DataMapper;

using IBatisSqlMapSample.Domain.Exceptions;
using IBatisSqlMapSample.Domain.Books;


namespace IBatisSqlMapSample.Presentation
{
	/// <summary>
	/// frmBookDetail �̊T�v�̐����ł��B
	/// </summary>
	public class frmBookDetail : System.Windows.Forms.Form
	{

		//log4net�̃C���X�^���X���擾
		private static readonly log4net.ILog _logger = 
			log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		
		//�Ώۏ��Ђ�ISBN
		private string _userIsbn = null;

		//�����Ώۂ̃X�e�[�^�X(CREATE/READ/UPDATE/DELETE)��ێ�
		private String _crudStatus = null;
		
		private System.Windows.Forms.Label lblIsbn;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblSaleDate;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtIsbn;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.DateTimePicker dtpBirthday;
		private System.Windows.Forms.Button btnOk;
		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmBookDetail()
		{
			//
			// Windows �t�H�[�� �f�U�C�i �T�|�[�g�ɕK�v�ł��B
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent �Ăяo���̌�ɁA�R���X�g���N�^ �R�[�h��ǉ����Ă��������B
			//
		}

		/// <summary>
		/// �g�p����Ă��郊�\�[�X�Ɍ㏈�������s���܂��B
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows �t�H�[�� �f�U�C�i�Ő������ꂽ�R�[�h 
		/// <summary>
		/// �f�U�C�i �T�|�[�g�ɕK�v�ȃ��\�b�h�ł��B���̃��\�b�h�̓��e��
		/// �R�[�h �G�f�B�^�ŕύX���Ȃ��ł��������B
		/// </summary>
		private void InitializeComponent()
		{
			this.txtIsbn = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblIsbn = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblSaleDate = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtIsbn
			// 
			this.txtIsbn.Location = new System.Drawing.Point(92, 16);
			this.txtIsbn.MaxLength = 10;
			this.txtIsbn.Name = "txtIsbn";
			this.txtIsbn.Size = new System.Drawing.Size(72, 19);
			this.txtIsbn.TabIndex = 1;
			this.txtIsbn.Text = "";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(92, 45);
			this.txtTitle.MaxLength = 50;
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(140, 19);
			this.txtTitle.TabIndex = 3;
			this.txtTitle.Text = "";
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.Location = new System.Drawing.Point(88, 104);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.Size = new System.Drawing.Size(108, 19);
			this.dtpBirthday.TabIndex = 9;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(92, 74);
			this.txtPrice.MaxLength = 8;
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(64, 19);
			this.txtPrice.TabIndex = 5;
			this.txtPrice.Text = "";
			this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(16, 144);
			this.btnOk.Name = "btnOk";
			this.btnOk.TabIndex = 10;
			this.btnOk.Text = "OK";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(160, 144);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "�߂�";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblIsbn
			// 
			this.lblIsbn.Location = new System.Drawing.Point(36, 20);
			this.lblIsbn.Name = "lblIsbn";
			this.lblIsbn.Size = new System.Drawing.Size(52, 20);
			this.lblIsbn.TabIndex = 0;
			this.lblIsbn.Text = "ISBN";
			// 
			// lblTitle
			// 
			this.lblTitle.Location = new System.Drawing.Point(36, 48);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(52, 20);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "�^�C�g��";
			// 
			// lblSaleDate
			// 
			this.lblSaleDate.Location = new System.Drawing.Point(36, 104);
			this.lblSaleDate.Name = "lblSaleDate";
			this.lblSaleDate.Size = new System.Drawing.Size(52, 20);
			this.lblSaleDate.TabIndex = 8;
			this.lblSaleDate.Text = "������";
			// 
			// lblPrice
			// 
			this.lblPrice.Location = new System.Drawing.Point(36, 76);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(52, 20);
			this.lblPrice.TabIndex = 4;
			this.lblPrice.Text = "���i";
			// 
			// frmBookDetail
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.ClientSize = new System.Drawing.Size(248, 174);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.lblSaleDate);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblIsbn);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.txtIsbn);
			this.Controls.Add(this.dtpBirthday);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmBookDetail";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "���Џ��";
			this.Load += new System.EventHandler(this.frmBookDetail_Load);
			this.ResumeLayout(false);

		}
		#endregion
		
		/// <summary>
		/// �X�V�X�e�[�^�X(CREATE/READ/UPDATE/DELETE)
		/// </summary>
		public String CrudStatus 
		{
			get{ return _crudStatus; }
			set{ _crudStatus = value; }
		}

		/// <summary>
		/// ����ISBN
		/// </summary>
		public string BookIsbn
		{
			get{ return _userIsbn; }
			set{ _userIsbn = value; }
		}

		/// <summary>
		/// �t�H�[�����[�h���̐���
		/// </summary>
		private void frmBookDetail_Load(object sender, System.EventArgs e)
		{
			//(Assertion)�X�V�X�e�[�^�X�̐ݒ�`�F�b�N
			System.Diagnostics.Debug.Assert(_crudStatus != null,"�X�e�[�^�X���ݒ�");

			//���̓R���g���[���̐���
			SetUpInputLock();

			//OK�{�^�����̐���
			SetUpOkButtunTitle();

			//���Џ��̕\��
			LoadBookInfo();

		}


		/// <summary>
		/// ���Џ��̕\�����s��
		/// </summary>
		private void LoadBookInfo()
		{
			if (_crudStatus.Equals("READ") || _crudStatus.Equals("DELETE") || _crudStatus.Equals("UPDATE"))
			{
				Book book = (Book)Mapper.Instance().QueryForObject("GetBookByIsbn",_userIsbn);
				this.txtIsbn.Text = book.Isbn.ToString();
				this.txtTitle.Text = book.Title;
				this.txtPrice.Text = book.Price.ToString();
				this.dtpBirthday.Value = book.SaleDate;
			}
		}

		/// <summary>
		/// �e�L�X�g�{�b�N�X�̓��͐���
		/// </summary>
		private void SetUpInputLock()
		{
			// ���̓R���g���[���̐���
			if (_crudStatus.Equals("READ") || _crudStatus.Equals("DELETE"))
			{
				this.txtTitle.Enabled= false;
				this.txtPrice.Enabled=false;
				this.dtpBirthday.Enabled=false;
			}

			if (_crudStatus.Equals("READ") || _crudStatus.Equals("DELETE") || _crudStatus.Equals("UPDATE"))
			{
				this.txtIsbn.Enabled =false;
			}
		}

		/// <summary>
		/// OK�{�^�����̐���
		/// </summary>
		private void SetUpOkButtunTitle()
		{
			if (_crudStatus.Equals("CREATE"))
			{
				this.btnOk.Text="�V�K�ǉ�";
			}
			else if(_crudStatus.Equals("UPDATE"))
			{
				this.btnOk.Text="�X�V";
			}
			else if(_crudStatus.Equals("READ"))
			{
				this.btnOk.Text="OK";
			}
			else if(_crudStatus.Equals("DELETE"))
			{
				this.btnOk.Text="�폜";
			}
		}

		/// <summary>
		/// �X�V�{�^���������̐���
		/// </summary>
		private void btnOk_Click(object sender, System.EventArgs e)
		{

			try
			{
				//Book�I�u�W�F�N�g�ɒl��ݒ�
				Book book = new Book();
				if (_crudStatus.Equals("CREATE") || (_crudStatus.Equals("UPDATE")))
				{

					book.Isbn = this.txtIsbn.Text;
					book.Title = this.txtTitle.Text;
					book.Price = int.Parse(this.txtPrice.Text);
					book.SaleDate = new DateTime(this.dtpBirthday.Value.Year,this.dtpBirthday.Value.Month,this.dtpBirthday.Value.Day);
				}

				//�����ɉ������X�V�˗������{
				if (_crudStatus.Equals("CREATE"))
				{
					Mapper.Instance().Insert("InsertBook",book);
				}
				if (_crudStatus.Equals("UPDATE"))
				{
					Mapper.Instance().Update("UpdateBook",book);
				}
				if (_crudStatus.Equals("DELETE"))
				{
					Mapper.Instance().Delete("DeleteBook",this.txtIsbn.Text);
				}
				
				//�G���[���Ȃ���΃t�H�[�������
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch(DomainException ex)
			{
				//���͕����̕s���Ɋւ���G���[�̏ꍇ
				MessageBox.Show(ex.Message, ex.GetType().ToString(),
					MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			catch(FormatException ex)
			{
				//���͕����̕s���Ɋւ���G���[�̏ꍇ
				MessageBox.Show(ex.Message, ex.GetType().ToString(),
					MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			catch(Exception ex)
			{
				//Log4net��Exception�̏ڍׂ�\��
				_logger.Error("�f�[�^�x�[�X�X�V���ɗ\�����ʃG���[���������܂����B",ex);

				//���̑��̃G���[�̏ꍇ(�L�[�d���ESQL�s���Ȃ�)
				MessageBox.Show("�\�����ʃG���[���������܂����B"+ "\r\r" + ex.Message,
					ex.GetType().ToString(),MessageBoxButtons.OK,MessageBoxIcon.Error);

			}
		
		}

		/// <summary>
		/// �L�����Z���{�^���������̐���
		/// </summary>
		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}



	}
}
