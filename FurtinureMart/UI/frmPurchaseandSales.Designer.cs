namespace FurtinureMart.UI
{
	partial class frmPurchaseandSales
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseandSales));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.lblTop = new System.Windows.Forms.Label();
			this.pnlDeaCust = new System.Windows.Forms.Panel();
			this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtContact = new System.Windows.Forms.TextBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblBillDate = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblContact = new System.Windows.Forms.Label();
			this.lblSearch = new System.Windows.Forms.Label();
			this.lblDeaCustTitle = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.txtRate = new System.Windows.Forms.TextBox();
			this.txtInventory = new System.Windows.Forms.TextBox();
			this.txtSearchProduct = new System.Windows.Forms.TextBox();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblRate = new System.Windows.Forms.Label();
			this.lblInventry = new System.Windows.Forms.Label();
			this.lblProductName = new System.Windows.Forms.Label();
			this.lblproductSearch = new System.Windows.Forms.Label();
			this.lblProductTitle = new System.Windows.Forms.Label();
			this.pnldataGridView = new System.Windows.Forms.Panel();
			this.dgvAddedProducts = new System.Windows.Forms.DataGridView();
			this.lblDGVTitle = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtReturnAmount = new System.Windows.Forms.TextBox();
			this.txtPaidAmount = new System.Windows.Forms.TextBox();
			this.txtGrandTotal = new System.Windows.Forms.TextBox();
			this.txtGST = new System.Windows.Forms.TextBox();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.txtSubTotal = new System.Windows.Forms.TextBox();
			this.lblReturnAmount = new System.Windows.Forms.Label();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.lblGST = new System.Windows.Forms.Label();
			this.lblPaidAmount = new System.Windows.Forms.Label();
			this.lblGarndTotal = new System.Windows.Forms.Label();
			this.lblSubTotal = new System.Windows.Forms.Label();
			this.lblCalculationTitle = new System.Windows.Forms.Label();
			this.labelDiscount = new System.Windows.Forms.Label();
			this.textDisCount = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			this.pnlDeaCust.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnldataGridView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel1.Controls.Add(this.pictureBoxClose);
			this.panel1.Controls.Add(this.lblTop);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1260, 41);
			this.panel1.TabIndex = 2;
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(1231, 3);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(29, 30);
			this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxClose.TabIndex = 1;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
			// 
			// lblTop
			// 
			this.lblTop.AutoSize = true;
			this.lblTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTop.Location = new System.Drawing.Point(500, 9);
			this.lblTop.Name = "lblTop";
			this.lblTop.Size = new System.Drawing.Size(177, 21);
			this.lblTop.TabIndex = 0;
			this.lblTop.Text = "PURCHASE AND SALES ";
		//	this.lblTop.Click += new System.EventHandler(this.lblTop_Click);
			// 
			// pnlDeaCust
			// 
			this.pnlDeaCust.Controls.Add(this.textDisCount);
			this.pnlDeaCust.Controls.Add(this.labelDiscount);
			this.pnlDeaCust.Controls.Add(this.dtpBillDate);
			this.pnlDeaCust.Controls.Add(this.txtAddress);
			this.pnlDeaCust.Controls.Add(this.txtName);
			this.pnlDeaCust.Controls.Add(this.txtEmail);
			this.pnlDeaCust.Controls.Add(this.txtContact);
			this.pnlDeaCust.Controls.Add(this.txtSearch);
			this.pnlDeaCust.Controls.Add(this.lblBillDate);
			this.pnlDeaCust.Controls.Add(this.lblAddress);
			this.pnlDeaCust.Controls.Add(this.lblName);
			this.pnlDeaCust.Controls.Add(this.lblEmail);
			this.pnlDeaCust.Controls.Add(this.lblContact);
			this.pnlDeaCust.Controls.Add(this.lblSearch);
			this.pnlDeaCust.Controls.Add(this.lblDeaCustTitle);
			this.pnlDeaCust.Location = new System.Drawing.Point(12, 47);
			this.pnlDeaCust.Name = "pnlDeaCust";
			this.pnlDeaCust.Size = new System.Drawing.Size(1236, 122);
			this.pnlDeaCust.TabIndex = 3;
		//	this.pnlDeaCust.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDeaCust_Paint);
			// 
			// dtpBillDate
			// 
			this.dtpBillDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpBillDate.Location = new System.Drawing.Point(1020, 25);
			this.dtpBillDate.Name = "dtpBillDate";
			this.dtpBillDate.Size = new System.Drawing.Size(200, 25);
			this.dtpBillDate.TabIndex = 14;
			// 
			// txtAddress
			// 
			this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.Location = new System.Drawing.Point(705, 22);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(235, 80);
			this.txtAddress.TabIndex = 13;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(70, 77);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(235, 25);
			this.txtName.TabIndex = 12;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(393, 25);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(235, 25);
			this.txtEmail.TabIndex = 11;
			// 
			// txtContact
			// 
			this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContact.Location = new System.Drawing.Point(393, 77);
			this.txtContact.Name = "txtContact";
			this.txtContact.Size = new System.Drawing.Size(235, 25);
			this.txtContact.TabIndex = 10;
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(70, 25);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(235, 25);
			this.txtSearch.TabIndex = 9;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// lblBillDate
			// 
			this.lblBillDate.AutoSize = true;
			this.lblBillDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBillDate.Location = new System.Drawing.Point(959, 25);
			this.lblBillDate.Name = "lblBillDate";
			this.lblBillDate.Size = new System.Drawing.Size(55, 17);
			this.lblBillDate.TabIndex = 8;
			this.lblBillDate.Text = "Bill Date";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAddress.Location = new System.Drawing.Point(643, 25);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(56, 17);
			this.lblAddress.TabIndex = 5;
			this.lblAddress.Text = "Address";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(7, 80);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(43, 17);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "Name";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(335, 25);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(39, 17);
			this.lblEmail.TabIndex = 3;
			this.lblEmail.Text = "Email";
			// 
			// lblContact
			// 
			this.lblContact.AutoSize = true;
			this.lblContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContact.Location = new System.Drawing.Point(335, 80);
			this.lblContact.Name = "lblContact";
			this.lblContact.Size = new System.Drawing.Size(52, 17);
			this.lblContact.TabIndex = 2;
			this.lblContact.Text = "Contact";
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(7, 25);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(47, 17);
			this.lblSearch.TabIndex = 1;
			this.lblSearch.Text = "Search";
			// 
			// lblDeaCustTitle
			// 
			this.lblDeaCustTitle.AutoSize = true;
			this.lblDeaCustTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDeaCustTitle.Location = new System.Drawing.Point(4, 4);
			this.lblDeaCustTitle.Name = "lblDeaCustTitle";
			this.lblDeaCustTitle.Size = new System.Drawing.Size(213, 17);
			this.lblDeaCustTitle.TabIndex = 0;
			this.lblDeaCustTitle.Text = "Distributor and Customer Details";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnAdd);
			this.panel2.Controls.Add(this.txtQty);
			this.panel2.Controls.Add(this.txtProductName);
			this.panel2.Controls.Add(this.txtRate);
			this.panel2.Controls.Add(this.txtInventory);
			this.panel2.Controls.Add(this.txtSearchProduct);
			this.panel2.Controls.Add(this.lblQuantity);
			this.panel2.Controls.Add(this.lblRate);
			this.panel2.Controls.Add(this.lblInventry);
			this.panel2.Controls.Add(this.lblProductName);
			this.panel2.Controls.Add(this.lblproductSearch);
			this.panel2.Controls.Add(this.lblProductTitle);
			this.panel2.Location = new System.Drawing.Point(12, 187);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1236, 78);
			this.panel2.TabIndex = 4;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(1128, 36);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(95, 26);
			this.btnAdd.TabIndex = 11;
			this.btnAdd.Text = "ADD";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtQty
			// 
			this.txtQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQty.Location = new System.Drawing.Point(962, 37);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(143, 25);
			this.txtQty.TabIndex = 10;
			//this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
			// 
			// txtProductName
			// 
			this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductName.Location = new System.Drawing.Point(300, 36);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(143, 25);
			this.txtProductName.TabIndex = 9;
			// 
			// txtRate
			// 
			this.txtRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRate.Location = new System.Drawing.Point(749, 38);
			this.txtRate.Name = "txtRate";
			this.txtRate.Size = new System.Drawing.Size(143, 25);
			this.txtRate.TabIndex = 8;
			// 
			// txtInventory
			// 
			this.txtInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInventory.Location = new System.Drawing.Point(529, 36);
			this.txtInventory.Name = "txtInventory";
			this.txtInventory.Size = new System.Drawing.Size(143, 25);
			this.txtInventory.TabIndex = 7;
			// 
			// txtSearchProduct
			// 
			this.txtSearchProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchProduct.Location = new System.Drawing.Point(84, 36);
			this.txtSearchProduct.Name = "txtSearchProduct";
			this.txtSearchProduct.Size = new System.Drawing.Size(143, 25);
			this.txtSearchProduct.TabIndex = 6;
			this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuantity.Location = new System.Drawing.Point(928, 41);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(28, 17);
			this.lblQuantity.TabIndex = 5;
			this.lblQuantity.Text = "Qty";
			// 
			// lblRate
			// 
			this.lblRate.AutoSize = true;
			this.lblRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRate.Location = new System.Drawing.Point(709, 39);
			this.lblRate.Name = "lblRate";
			this.lblRate.Size = new System.Drawing.Size(34, 17);
			this.lblRate.TabIndex = 4;
			this.lblRate.Text = "Rate";
			// 
			// lblInventry
			// 
			this.lblInventry.AutoSize = true;
			this.lblInventry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInventry.Location = new System.Drawing.Point(475, 40);
			this.lblInventry.Name = "lblInventry";
			this.lblInventry.Size = new System.Drawing.Size(53, 17);
			this.lblInventry.TabIndex = 3;
			this.lblInventry.Text = "Inventry";
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductName.Location = new System.Drawing.Point(251, 41);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(43, 17);
			this.lblProductName.TabIndex = 2;
			this.lblProductName.Text = "Name";
			// 
			// lblproductSearch
			// 
			this.lblproductSearch.AutoSize = true;
			this.lblproductSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblproductSearch.Location = new System.Drawing.Point(10, 39);
			this.lblproductSearch.Name = "lblproductSearch";
			this.lblproductSearch.Size = new System.Drawing.Size(68, 17);
			this.lblproductSearch.TabIndex = 1;
			this.lblproductSearch.Text = "Model No";
			// 
			// lblProductTitle
			// 
			this.lblProductTitle.AutoSize = true;
			this.lblProductTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductTitle.Location = new System.Drawing.Point(6, 4);
			this.lblProductTitle.Name = "lblProductTitle";
			this.lblProductTitle.Size = new System.Drawing.Size(97, 17);
			this.lblProductTitle.TabIndex = 0;
			this.lblProductTitle.Text = "Product Detail";
			// 
			// pnldataGridView
			// 
			this.pnldataGridView.Controls.Add(this.dgvAddedProducts);
			this.pnldataGridView.Controls.Add(this.lblDGVTitle);
			this.pnldataGridView.Location = new System.Drawing.Point(12, 284);
			this.pnldataGridView.Name = "pnldataGridView";
			this.pnldataGridView.Size = new System.Drawing.Size(599, 421);
			this.pnldataGridView.TabIndex = 5;
			// 
			// dgvAddedProducts
			// 
			this.dgvAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAddedProducts.Location = new System.Drawing.Point(13, 37);
			this.dgvAddedProducts.Name = "dgvAddedProducts";
			this.dgvAddedProducts.Size = new System.Drawing.Size(573, 366);
			this.dgvAddedProducts.TabIndex = 1;
			// 
			// lblDGVTitle
			// 
			this.lblDGVTitle.AutoSize = true;
			this.lblDGVTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDGVTitle.Location = new System.Drawing.Point(5, 5);
			this.lblDGVTitle.Name = "lblDGVTitle";
			this.lblDGVTitle.Size = new System.Drawing.Size(91, 17);
			this.lblDGVTitle.TabIndex = 0;
			this.lblDGVTitle.Text = "Add Products";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnSave);
			this.panel3.Controls.Add(this.txtReturnAmount);
			this.panel3.Controls.Add(this.txtPaidAmount);
			this.panel3.Controls.Add(this.txtGrandTotal);
			this.panel3.Controls.Add(this.txtGST);
			this.panel3.Controls.Add(this.txtDiscount);
			this.panel3.Controls.Add(this.txtSubTotal);
			this.panel3.Controls.Add(this.lblReturnAmount);
			this.panel3.Controls.Add(this.lblDiscount);
			this.panel3.Controls.Add(this.lblGST);
			this.panel3.Controls.Add(this.lblPaidAmount);
			this.panel3.Controls.Add(this.lblGarndTotal);
			this.panel3.Controls.Add(this.lblSubTotal);
			this.panel3.Controls.Add(this.lblCalculationTitle);
			this.panel3.Location = new System.Drawing.Point(627, 284);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(621, 421);
			this.panel3.TabIndex = 6;
			//this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(247, 373);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(211, 38);
			this.btnSave.TabIndex = 13;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtReturnAmount
			// 
			this.txtReturnAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReturnAmount.Location = new System.Drawing.Point(135, 312);
			this.txtReturnAmount.Name = "txtReturnAmount";
			this.txtReturnAmount.ReadOnly = true;
			this.txtReturnAmount.Size = new System.Drawing.Size(380, 25);
			this.txtReturnAmount.TabIndex = 12;
			this.txtReturnAmount.Text = "0";
			// 
			// txtPaidAmount
			// 
			this.txtPaidAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPaidAmount.Location = new System.Drawing.Point(135, 252);
			this.txtPaidAmount.Name = "txtPaidAmount";
			this.txtPaidAmount.Size = new System.Drawing.Size(380, 25);
			this.txtPaidAmount.TabIndex = 11;
			this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
			// 
			// txtGrandTotal
			// 
			this.txtGrandTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGrandTotal.Location = new System.Drawing.Point(135, 197);
			this.txtGrandTotal.Name = "txtGrandTotal";
			this.txtGrandTotal.ReadOnly = true;
			this.txtGrandTotal.Size = new System.Drawing.Size(380, 25);
			this.txtGrandTotal.TabIndex = 10;
			this.txtGrandTotal.Text = "0";
			// 
			// txtGST
			// 
			this.txtGST.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGST.Location = new System.Drawing.Point(135, 147);
			this.txtGST.Name = "txtGST";
			this.txtGST.Size = new System.Drawing.Size(380, 25);
			this.txtGST.TabIndex = 9;
			this.txtGST.Text = "0";
			this.txtGST.TextChanged += new System.EventHandler(this.txtGST_TextChanged);
			// 
			// txtDiscount
			// 
			this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiscount.Location = new System.Drawing.Point(135, 95);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(380, 25);
			this.txtDiscount.TabIndex = 8;
			this.txtDiscount.Text = "0";
			this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
			// 
			// txtSubTotal
			// 
			this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSubTotal.Location = new System.Drawing.Point(135, 37);
			this.txtSubTotal.Name = "txtSubTotal";
			this.txtSubTotal.ReadOnly = true;
			this.txtSubTotal.Size = new System.Drawing.Size(380, 25);
			this.txtSubTotal.TabIndex = 7;
			this.txtSubTotal.Text = "0";
		//	this.txtSubTotal.TextChanged += new System.EventHandler(this.txtSubTotal_TextChanged);
			// 
			// lblReturnAmount
			// 
			this.lblReturnAmount.AutoSize = true;
			this.lblReturnAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReturnAmount.Location = new System.Drawing.Point(7, 315);
			this.lblReturnAmount.Name = "lblReturnAmount";
			this.lblReturnAmount.Size = new System.Drawing.Size(95, 17);
			this.lblReturnAmount.TabIndex = 6;
			this.lblReturnAmount.Text = "Return Amount";
			// 
			// lblDiscount
			// 
			this.lblDiscount.AutoSize = true;
			this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDiscount.Location = new System.Drawing.Point(7, 95);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(81, 17);
			this.lblDiscount.TabIndex = 5;
			this.lblDiscount.Text = "Discount( %)";
			// 
			// lblGST
			// 
			this.lblGST.AutoSize = true;
			this.lblGST.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGST.Location = new System.Drawing.Point(7, 147);
			this.lblGST.Name = "lblGST";
			this.lblGST.Size = new System.Drawing.Size(50, 17);
			this.lblGST.TabIndex = 4;
			this.lblGST.Text = "GST(%)";
			// 
			// lblPaidAmount
			// 
			this.lblPaidAmount.AutoSize = true;
			this.lblPaidAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPaidAmount.Location = new System.Drawing.Point(7, 252);
			this.lblPaidAmount.Name = "lblPaidAmount";
			this.lblPaidAmount.Size = new System.Drawing.Size(82, 17);
			this.lblPaidAmount.TabIndex = 3;
			this.lblPaidAmount.Text = "Paid Amount";
			// 
			// lblGarndTotal
			// 
			this.lblGarndTotal.AutoSize = true;
			this.lblGarndTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGarndTotal.Location = new System.Drawing.Point(7, 197);
			this.lblGarndTotal.Name = "lblGarndTotal";
			this.lblGarndTotal.Size = new System.Drawing.Size(76, 17);
			this.lblGarndTotal.TabIndex = 2;
			this.lblGarndTotal.Text = "Grand Total";
			// 
			// lblSubTotal
			// 
			this.lblSubTotal.AutoSize = true;
			this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubTotal.Location = new System.Drawing.Point(7, 37);
			this.lblSubTotal.Name = "lblSubTotal";
			this.lblSubTotal.Size = new System.Drawing.Size(62, 17);
			this.lblSubTotal.TabIndex = 1;
			this.lblSubTotal.Text = "Sub Total";
			// 
			// lblCalculationTitle
			// 
			this.lblCalculationTitle.AutoSize = true;
			this.lblCalculationTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCalculationTitle.Location = new System.Drawing.Point(4, 5);
			this.lblCalculationTitle.Name = "lblCalculationTitle";
			this.lblCalculationTitle.Size = new System.Drawing.Size(124, 17);
			this.lblCalculationTitle.TabIndex = 0;
			this.lblCalculationTitle.Text = "Calculation Details";
			// 
			// labelDiscount
			// 
			this.labelDiscount.AutoSize = true;
			this.labelDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDiscount.Location = new System.Drawing.Point(959, 77);
			this.labelDiscount.Name = "labelDiscount";
			this.labelDiscount.Size = new System.Drawing.Size(81, 17);
			this.labelDiscount.TabIndex = 15;
			this.labelDiscount.Text = "Discount( %)";
			// 
			// textDisCount
			// 
			this.textDisCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textDisCount.Location = new System.Drawing.Point(1049, 77);
			this.textDisCount.Name = "textDisCount";
			this.textDisCount.Size = new System.Drawing.Size(174, 25);
			this.textDisCount.TabIndex = 16;
			// 
			// frmPurchaseandSales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1260, 717);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.pnldataGridView);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pnlDeaCust);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmPurchaseandSales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Purchase and Sales";
			this.Load += new System.EventHandler(this.frmPurchaseandSales_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			this.pnlDeaCust.ResumeLayout(false);
			this.pnlDeaCust.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.pnldataGridView.ResumeLayout(false);
			this.pnldataGridView.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Label lblTop;
		private System.Windows.Forms.Panel pnlDeaCust;
		private System.Windows.Forms.DateTimePicker dtpBillDate;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtContact;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblBillDate;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblContact;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.Label lblDeaCustTitle;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblProductTitle;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Label lblRate;
		private System.Windows.Forms.Label lblInventry;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.Label lblproductSearch;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtQty;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.TextBox txtRate;
		private System.Windows.Forms.TextBox txtInventory;
		private System.Windows.Forms.TextBox txtSearchProduct;
		private System.Windows.Forms.Panel pnldataGridView;
		private System.Windows.Forms.DataGridView dgvAddedProducts;
		private System.Windows.Forms.Label lblDGVTitle;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lblSubTotal;
		private System.Windows.Forms.Label lblCalculationTitle;
		private System.Windows.Forms.TextBox txtPaidAmount;
		private System.Windows.Forms.TextBox txtGrandTotal;
		private System.Windows.Forms.TextBox txtGST;
		private System.Windows.Forms.TextBox txtDiscount;
		private System.Windows.Forms.TextBox txtSubTotal;
		private System.Windows.Forms.Label lblReturnAmount;
		private System.Windows.Forms.Label lblDiscount;
		private System.Windows.Forms.Label lblGST;
		private System.Windows.Forms.Label lblPaidAmount;
		private System.Windows.Forms.Label lblGarndTotal;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtReturnAmount;
		private System.Windows.Forms.TextBox textDisCount;
		private System.Windows.Forms.Label labelDiscount;
	}
}