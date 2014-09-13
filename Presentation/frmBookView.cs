using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using IBatisNet.DataMapper;
using IBatisSqlMapSample.Domain.Books;



namespace IBatisSqlMapSample.Presentation
{
	/// <summary>
	/// frmBookView �̊T�v�̐����ł��B
	/// </summary>
	public class frmBookView : System.Windows.Forms.Form
	{
		private static readonly log4net.ILog _logger = 
			log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		

		private DataSet _dataSet = null;
		private DataTable _dataTable  = null;
		private System.Windows.Forms.DataGrid grdMain;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnSearchTitle;
		private System.Windows.Forms.ComboBox cmbPrice;
		private System.Windows.Forms.ComboBox cmbPrice2;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.Button btnSearchPriceWeight;

		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmBookView()
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
				if (components != null) 
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
			this.grdMain = new System.Windows.Forms.DataGrid();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.btnSearchTitle = new System.Windows.Forms.Button();
			this.btnRead = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.cmbPrice = new System.Windows.Forms.ComboBox();
			this.cmbPrice2 = new System.Windows.Forms.ComboBox();
			this.lblPrice = new System.Windows.Forms.Label();
			this.btnSearchPriceWeight = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
			this.SuspendLayout();
			// 
			// grdMain
			// 
			this.grdMain.CaptionVisible = false;
			this.grdMain.DataMember = "";
			this.grdMain.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.grdMain.Location = new System.Drawing.Point(16, 80);
			this.grdMain.Name = "grdMain";
			this.grdMain.ReadOnly = true;
			this.grdMain.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
			this.grdMain.Size = new System.Drawing.Size(456, 232);
			this.grdMain.TabIndex = 10;
			this.grdMain.Paint += new System.Windows.Forms.PaintEventHandler(this.grdMain_Paint);
			// 
			// txtTitle
			// 
			this.txtTitle.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.txtTitle.Location = new System.Drawing.Point(72, 8);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(136, 22);
			this.txtTitle.TabIndex = 1;
			this.txtTitle.Text = "";
			// 
			// btnSearchTitle
			// 
			this.btnSearchTitle.Location = new System.Drawing.Point(216, 8);
			this.btnSearchTitle.Name = "btnSearchTitle";
			this.btnSearchTitle.Size = new System.Drawing.Size(128, 24);
			this.btnSearchTitle.TabIndex = 2;
			this.btnSearchTitle.Text = "�^�C�g������(&T)";
			this.btnSearchTitle.Click += new System.EventHandler(this.btnSearchTitle_Click);
			// 
			// btnRead
			// 
			this.btnRead.Location = new System.Drawing.Point(16, 320);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(112, 24);
			this.btnRead.TabIndex = 11;
			this.btnRead.Text = "�Q��(&R)";
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(240, 320);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(112, 24);
			this.btnUpdate.TabIndex = 13;
			this.btnUpdate.Text = "�X�V(&U)";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(128, 320);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(112, 24);
			this.btnCreate.TabIndex = 12;
			this.btnCreate.Text = "�ǉ�(&C)";
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(352, 320);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(112, 24);
			this.btnDelete.TabIndex = 14;
			this.btnDelete.Text = "�폜(&D)";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.Location = new System.Drawing.Point(24, 13);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(56, 24);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "�^�C�g��";
			// 
			// cmbPrice
			// 
			this.cmbPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPrice.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cmbPrice.Items.AddRange(new object[] {
														  "1000",
														  "2000",
														  "3000",
														  "4000",
														  "5000"});
			this.cmbPrice.Location = new System.Drawing.Point(72, 50);
			this.cmbPrice.Name = "cmbPrice";
			this.cmbPrice.Size = new System.Drawing.Size(80, 23);
			this.cmbPrice.TabIndex = 4;
			// 
			// cmbPrice2
			// 
			this.cmbPrice2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPrice2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cmbPrice2.Items.AddRange(new object[] {
														   "",
														   "�ȏ�",
														   "�ȉ�"});
			this.cmbPrice2.Location = new System.Drawing.Point(152, 50);
			this.cmbPrice2.Name = "cmbPrice2";
			this.cmbPrice2.Size = new System.Drawing.Size(56, 23);
			this.cmbPrice2.TabIndex = 5;
			// 
			// lblPrice
			// 
			this.lblPrice.Location = new System.Drawing.Point(32, 55);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(40, 18);
			this.lblPrice.TabIndex = 3;
			this.lblPrice.Text = "���i";
			// 
			// btnSearchPriceWeight
			// 
			this.btnSearchPriceWeight.Location = new System.Drawing.Point(216, 48);
			this.btnSearchPriceWeight.Name = "btnSearchPriceWeight";
			this.btnSearchPriceWeight.Size = new System.Drawing.Size(128, 24);
			this.btnSearchPriceWeight.TabIndex = 9;
			this.btnSearchPriceWeight.Text = "���i����(&S)";
			this.btnSearchPriceWeight.Click += new System.EventHandler(this.btnSearchPriceWeight_Click);
			// 
			// frmBookView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.ClientSize = new System.Drawing.Size(480, 354);
			this.Controls.Add(this.btnSearchPriceWeight);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.cmbPrice);
			this.Controls.Add(this.cmbPrice2);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnRead);
			this.Controls.Add(this.btnSearchTitle);
			this.Controls.Add(this.grdMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmBookView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "���Јꗗ";
			this.Load += new System.EventHandler(this.frmBookView_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		/// <summary>
		/// �t�H�[�����[�h���̏���
		/// </summary>
		private void frmBookView_Load(object sender, System.EventArgs e)
		{	
			
			//�f�[�^�O���b�h�̃J��������ݒ�
			_dataSet = new DataSet();
			_dataTable  = _dataSet.Tables.Add("");
			DataColumn dc1 = _dataTable.Columns.Add("ISBN-KEY(�B��)");
			DataColumn dc2 = _dataTable.Columns.Add("ISBN");
			DataColumn dc3 = _dataTable.Columns.Add("�^�C�g��");
			DataColumn dc4 = _dataTable.Columns.Add("���i", typeof(int));
			DataColumn dc5 = _dataTable.Columns.Add("������", typeof(DateTime));
			// �f�[�^�O���b�h�̃X�^�C���̍쐬
			DataGridTableStyle tableStyle = new DataGridTableStyle();
			tableStyle.MappingName = _dataTable.TableName;
			this.grdMain.TableStyles.Add(tableStyle);
			// ��X�^�C���̍쐬
			DataGridTextBoxColumn tbc1 = new DataGridTextBoxColumn();
			DataGridTextBoxColumn tbc2 = new DataGridTextBoxColumn();
			DataGridTextBoxColumn tbc3 = new DataGridTextBoxColumn();
			DataGridTextBoxColumn tbc4 = new DataGridTextBoxColumn();
			DataGridTextBoxColumn tbc5 = new DataGridTextBoxColumn();
			tbc1.MappingName = dc1.ColumnName;
			tbc2.MappingName = dc2.ColumnName;
			tbc3.MappingName = dc3.ColumnName;
			tbc4.MappingName = dc4.ColumnName;
			tbc5.MappingName = dc5.ColumnName;
			// ��̃w�b�_�[�Ƀ^�C�g���̐ݒ�
			tbc1.HeaderText = dc1.ColumnName;
			tbc2.HeaderText = dc2.ColumnName;
			tbc3.HeaderText = dc3.ColumnName;
			tbc4.HeaderText = dc4.ColumnName;
			tbc5.HeaderText = dc5.ColumnName;
			// ��̉E�񂹁E�Z���^�����O�E���񂹂̐ݒ�
			tbc1.Alignment = HorizontalAlignment.Left;
			tbc2.Alignment = HorizontalAlignment.Left;
			tbc3.Alignment = HorizontalAlignment.Left;
			tbc4.Alignment = HorizontalAlignment.Right;
			tbc5.Alignment = HorizontalAlignment.Left;
			// �񕝂̐ݒ�
			tbc1.Width = 0;
			tbc2.Width = 100;
			tbc3.Width = 140;
			tbc4.Width = 80;
			tbc5.Width = 80;
			// ��X�^�C�����e�[�u���̃X�^�C���ɓo�^
			tableStyle.GridColumnStyles.Add(tbc1);
			tableStyle.GridColumnStyles.Add(tbc2);
			tableStyle.GridColumnStyles.Add(tbc3);
			tableStyle.GridColumnStyles.Add(tbc4);
			tableStyle.GridColumnStyles.Add(tbc5);
			//�f�[�^�O���b�h�̍s�ǉ��E�폜�E�ҏW��s�ɐݒ�
			_dataTable.DefaultView.AllowNew = false;
			_dataTable.DefaultView.AllowDelete = false;
			_dataTable.DefaultView.AllowEdit = false;
			this.grdMain.SetDataBinding(_dataTable.DefaultView, "");
			
			//���i�R���{�{�b�N�X�̏����ݒ�
			this.cmbPrice.SelectedIndex = 0;

			//���̌����̎��s
			showBooksByTitle();
		}


		/// <summary>
		/// ���̌����̎��s
		/// </summary>
		private void btnSearchTitle_Click(object sender, System.EventArgs e)
		{
			showBooksByTitle();
		}

		/// <summary>
		/// ���i�����̎��s
		/// </summary>
		private void btnSearchPriceWeight_Click(object sender, System.EventArgs e)
		{
			showBooksByPrice();
		}

		/// <summary>
		/// �u�Q�ƃ{�^���v�������̏���
		/// </summary>
		private void btnRead_Click(object sender, System.EventArgs e)
		{
			//����ISBN���L���ł���΁u�Q�Ɓv�_�C�A���O�\��
			if (getBookIsbnBySelcectedRow() != "")
			{
				frmBookDetail frmdetail = new frmBookDetail();
				frmdetail.BookIsbn = getBookIsbnBySelcectedRow();
				frmdetail.CrudStatus = "READ";
				frmdetail.ShowDialog();
			}
		}

		/// <summary>
		/// �u�ǉ��{�^���v�������̏���
		/// </summary>
		private void btnCreate_Click(object sender, System.EventArgs e)
		{
			//���Ђ́u�ǉ��v�_�C�A���O�\��
			frmBookDetail frmdetail = new frmBookDetail();
			frmdetail.CrudStatus = "CREATE";
			frmdetail.ShowDialog();
			//�ύX������΍ĕ\��
			if (frmdetail.DialogResult == DialogResult.OK){
				showBooksByTitle();
			}
		}

		/// <summary>
		/// �u�폜�{�^���v�������̏���
		/// </summary>
		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			//����ISBN���L���ł���΁u�폜�v�_�C�A���O�\��
			if (getBookIsbnBySelcectedRow() != "")
			{
				frmBookDetail frmdetail = new frmBookDetail();
				frmdetail.BookIsbn = getBookIsbnBySelcectedRow();
				frmdetail.CrudStatus = "DELETE";
				frmdetail.ShowDialog();
				//�ύX������΍ĕ\��
				if (frmdetail.DialogResult == DialogResult.OK)
				{
					showBooksByTitle();
				}
			}
		}

		/// <summary>
		/// �u�X�V�{�^���v�������̏���
		/// </summary>
		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			//����ISBN���L���ł���΁u�X�V�v�_�C�A���O�\��
			if (getBookIsbnBySelcectedRow() != "")
			{
				frmBookDetail frmdetail = new frmBookDetail();
				frmdetail.BookIsbn = getBookIsbnBySelcectedRow();
				frmdetail.CrudStatus = "UPDATE";
				frmdetail.ShowDialog();
				//�ύX������΍ĕ\��
				if (frmdetail.DialogResult == DialogResult.OK)
				{
					showBooksByTitle();
				}
			}
		}

		/// <summary>
		/// ���̌����̎��s
		/// </summary>
		private void showBooksByTitle()
		{
			//LIKE�������s
			IList books = Mapper.Instance().QueryForList("GetBookListByTitle",this.txtTitle.Text);
			//�f�[�^�O���b�h���N���A
			_dataTable.Clear();
			//�f�[�^�O���b�h�Ɍ������ʂ��Z�b�g
			foreach (Book book in books)
			{
				_dataTable.Rows.Add(new Object[] {book.Isbn, book.IsbnWithHyphen,book.Title,book.Price,book.SaleDate});
			}
		}

		/// <summary>
		/// ���i�����̎��s
		/// </summary>
		private void showBooksByPrice()
		{
			//���i�������s
			Hashtable param = new Hashtable();
			param.Add("price",this.cmbPrice.Text);	//���i
			param.Add("priceCompare",this.cmbPrice2.Text);	//�u�ȏ�vor�u�ȉ��v
			IList books = Mapper.Instance().QueryForList("GetBookListByPrice",param);
			//�f�[�^�O���b�h���N���A
			_dataTable.Clear();
			//�f�[�^�O���b�h�Ɍ������ʂ��Z�b�g
			foreach (Book book in books)
			{
				_dataTable.Rows.Add(new Object[] {book.Isbn,book.IsbnWithHyphen, book.Title,book.Price,book.SaleDate});
			}
		}

		/// <summary>
		/// �f�[�^�O���b�h�őI������Ă���s�̏���ISBN���擾
		/// </summary>
		private string getBookIsbnBySelcectedRow()
		{
			string result = "";
			try
			{
				result = (string)grdMain[grdMain.CurrentCell.RowNumber,0];		
			}
			catch(Exception e)
			{
				//���Ѓ��X�g���󔒂̏�ԂŃ{�^�����N���b�N���ꂽ�ꍇ(��)
				_logger.Debug(e.Message);
			}
			return result;
		}

		private void grdMain_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			//�N���b�N���ɍs�S�̂�I��
			if (_dataTable.Rows.Count != 0)
			 {
				this.grdMain.Select(this.grdMain.CurrentCell.RowNumber);
			 }
		}




	}
}
