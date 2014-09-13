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
	/// frmBookView の概要の説明です。
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
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmBookView()
		{
			//
			// Windows フォーム デザイナ サポートに必要です。
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent 呼び出しの後に、コンストラクタ コードを追加してください。
			//
		}

		/// <summary>
		/// 使用されているリソースに後処理を実行します。
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

		#region Windows フォーム デザイナで生成されたコード 
		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
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
			this.btnSearchTitle.Text = "タイトル検索(&T)";
			this.btnSearchTitle.Click += new System.EventHandler(this.btnSearchTitle_Click);
			// 
			// btnRead
			// 
			this.btnRead.Location = new System.Drawing.Point(16, 320);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(112, 24);
			this.btnRead.TabIndex = 11;
			this.btnRead.Text = "参照(&R)";
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(240, 320);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(112, 24);
			this.btnUpdate.TabIndex = 13;
			this.btnUpdate.Text = "更新(&U)";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(128, 320);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(112, 24);
			this.btnCreate.TabIndex = 12;
			this.btnCreate.Text = "追加(&C)";
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(352, 320);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(112, 24);
			this.btnDelete.TabIndex = 14;
			this.btnDelete.Text = "削除(&D)";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.Location = new System.Drawing.Point(24, 13);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(56, 24);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "タイトル";
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
														   "以上",
														   "以下"});
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
			this.lblPrice.Text = "価格";
			// 
			// btnSearchPriceWeight
			// 
			this.btnSearchPriceWeight.Location = new System.Drawing.Point(216, 48);
			this.btnSearchPriceWeight.Name = "btnSearchPriceWeight";
			this.btnSearchPriceWeight.Size = new System.Drawing.Size(128, 24);
			this.btnSearchPriceWeight.TabIndex = 9;
			this.btnSearchPriceWeight.Text = "価格検索(&S)";
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
			this.Text = "書籍一覧";
			this.Load += new System.EventHandler(this.frmBookView_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		/// <summary>
		/// フォームロード時の処理
		/// </summary>
		private void frmBookView_Load(object sender, System.EventArgs e)
		{	
			
			//データグリッドのカラム名を設定
			_dataSet = new DataSet();
			_dataTable  = _dataSet.Tables.Add("");
			DataColumn dc1 = _dataTable.Columns.Add("ISBN-KEY(隠し)");
			DataColumn dc2 = _dataTable.Columns.Add("ISBN");
			DataColumn dc3 = _dataTable.Columns.Add("タイトル");
			DataColumn dc4 = _dataTable.Columns.Add("価格", typeof(int));
			DataColumn dc5 = _dataTable.Columns.Add("発売日", typeof(DateTime));
			// データグリッドのスタイルの作成
			DataGridTableStyle tableStyle = new DataGridTableStyle();
			tableStyle.MappingName = _dataTable.TableName;
			this.grdMain.TableStyles.Add(tableStyle);
			// 列スタイルの作成
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
			// 列のヘッダーにタイトルの設定
			tbc1.HeaderText = dc1.ColumnName;
			tbc2.HeaderText = dc2.ColumnName;
			tbc3.HeaderText = dc3.ColumnName;
			tbc4.HeaderText = dc4.ColumnName;
			tbc5.HeaderText = dc5.ColumnName;
			// 列の右寄せ・センタリング・左寄せの設定
			tbc1.Alignment = HorizontalAlignment.Left;
			tbc2.Alignment = HorizontalAlignment.Left;
			tbc3.Alignment = HorizontalAlignment.Left;
			tbc4.Alignment = HorizontalAlignment.Right;
			tbc5.Alignment = HorizontalAlignment.Left;
			// 列幅の設定
			tbc1.Width = 0;
			tbc2.Width = 100;
			tbc3.Width = 140;
			tbc4.Width = 80;
			tbc5.Width = 80;
			// 列スタイルをテーブルのスタイルに登録
			tableStyle.GridColumnStyles.Add(tbc1);
			tableStyle.GridColumnStyles.Add(tbc2);
			tableStyle.GridColumnStyles.Add(tbc3);
			tableStyle.GridColumnStyles.Add(tbc4);
			tableStyle.GridColumnStyles.Add(tbc5);
			//データグリッドの行追加・削除・編集を不可に設定
			_dataTable.DefaultView.AllowNew = false;
			_dataTable.DefaultView.AllowDelete = false;
			_dataTable.DefaultView.AllowEdit = false;
			this.grdMain.SetDataBinding(_dataTable.DefaultView, "");
			
			//価格コンボボックスの初期設定
			this.cmbPrice.SelectedIndex = 0;

			//名称検索の実行
			showBooksByTitle();
		}


		/// <summary>
		/// 名称検索の実行
		/// </summary>
		private void btnSearchTitle_Click(object sender, System.EventArgs e)
		{
			showBooksByTitle();
		}

		/// <summary>
		/// 価格検索の実行
		/// </summary>
		private void btnSearchPriceWeight_Click(object sender, System.EventArgs e)
		{
			showBooksByPrice();
		}

		/// <summary>
		/// 「参照ボタン」押下時の処理
		/// </summary>
		private void btnRead_Click(object sender, System.EventArgs e)
		{
			//書籍ISBNが有効であれば「参照」ダイアログ表示
			if (getBookIsbnBySelcectedRow() != "")
			{
				frmBookDetail frmdetail = new frmBookDetail();
				frmdetail.BookIsbn = getBookIsbnBySelcectedRow();
				frmdetail.CrudStatus = "READ";
				frmdetail.ShowDialog();
			}
		}

		/// <summary>
		/// 「追加ボタン」押下時の処理
		/// </summary>
		private void btnCreate_Click(object sender, System.EventArgs e)
		{
			//書籍の「追加」ダイアログ表示
			frmBookDetail frmdetail = new frmBookDetail();
			frmdetail.CrudStatus = "CREATE";
			frmdetail.ShowDialog();
			//変更があれば再表示
			if (frmdetail.DialogResult == DialogResult.OK){
				showBooksByTitle();
			}
		}

		/// <summary>
		/// 「削除ボタン」押下時の処理
		/// </summary>
		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			//書籍ISBNが有効であれば「削除」ダイアログ表示
			if (getBookIsbnBySelcectedRow() != "")
			{
				frmBookDetail frmdetail = new frmBookDetail();
				frmdetail.BookIsbn = getBookIsbnBySelcectedRow();
				frmdetail.CrudStatus = "DELETE";
				frmdetail.ShowDialog();
				//変更があれば再表示
				if (frmdetail.DialogResult == DialogResult.OK)
				{
					showBooksByTitle();
				}
			}
		}

		/// <summary>
		/// 「更新ボタン」押下時の処理
		/// </summary>
		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			//書籍ISBNが有効であれば「更新」ダイアログ表示
			if (getBookIsbnBySelcectedRow() != "")
			{
				frmBookDetail frmdetail = new frmBookDetail();
				frmdetail.BookIsbn = getBookIsbnBySelcectedRow();
				frmdetail.CrudStatus = "UPDATE";
				frmdetail.ShowDialog();
				//変更があれば再表示
				if (frmdetail.DialogResult == DialogResult.OK)
				{
					showBooksByTitle();
				}
			}
		}

		/// <summary>
		/// 名称検索の実行
		/// </summary>
		private void showBooksByTitle()
		{
			//LIKE検索実行
			IList books = Mapper.Instance().QueryForList("GetBookListByTitle",this.txtTitle.Text);
			//データグリッドをクリア
			_dataTable.Clear();
			//データグリッドに検索結果をセット
			foreach (Book book in books)
			{
				_dataTable.Rows.Add(new Object[] {book.Isbn, book.IsbnWithHyphen,book.Title,book.Price,book.SaleDate});
			}
		}

		/// <summary>
		/// 価格検索の実行
		/// </summary>
		private void showBooksByPrice()
		{
			//価格検索実行
			Hashtable param = new Hashtable();
			param.Add("price",this.cmbPrice.Text);	//価格
			param.Add("priceCompare",this.cmbPrice2.Text);	//「以上」or「以下」
			IList books = Mapper.Instance().QueryForList("GetBookListByPrice",param);
			//データグリッドをクリア
			_dataTable.Clear();
			//データグリッドに検索結果をセット
			foreach (Book book in books)
			{
				_dataTable.Rows.Add(new Object[] {book.Isbn,book.IsbnWithHyphen, book.Title,book.Price,book.SaleDate});
			}
		}

		/// <summary>
		/// データグリッドで選択されている行の書籍ISBNを取得
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
				//書籍リストが空白の状態でボタンがクリックされた場合(可)
				_logger.Debug(e.Message);
			}
			return result;
		}

		private void grdMain_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			//クリック時に行全体を選択
			if (_dataTable.Rows.Count != 0)
			 {
				this.grdMain.Select(this.grdMain.CurrentCell.RowNumber);
			 }
		}




	}
}
