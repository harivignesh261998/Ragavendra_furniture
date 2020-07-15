namespace FurtinureMart.UI
{
	partial class frmDeaCust
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeaCust));
			this.lblProducts = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblDeaCustID = new System.Windows.Forms.Label();
			this.lblType = new System.Windows.Forms.Label();
			this.lblName1 = new System.Windows.Forms.Label();
			this.lblEmail1 = new System.Windows.Forms.Label();
			this.lblAddress1 = new System.Windows.Forms.Label();
			this.lblContact1 = new System.Windows.Forms.Label();
			this.txtDeaCustID1 = new System.Windows.Forms.TextBox();
			this.txtName1 = new System.Windows.Forms.TextBox();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.txtEmail1 = new System.Windows.Forms.TextBox();
			this.txtContact1 = new System.Windows.Forms.TextBox();
			this.txtAddress1 = new System.Windows.Forms.TextBox();
			this.btnAdd1 = new System.Windows.Forms.Button();
			this.btnUpdate1 = new System.Windows.Forms.Button();
			this.btnDelete1 = new System.Windows.Forms.Button();
			this.dgvDeaCust1 = new System.Windows.Forms.DataGridView();
			this.txtSearch1 = new System.Windows.Forms.TextBox();
			this.lblSearch1 = new System.Windows.Forms.Label();
			this.lblDisc1 = new System.Windows.Forms.Label();
			this.txtDisc1 = new System.Windows.Forms.TextBox();
			this.txtDisc2 = new System.Windows.Forms.TextBox();
			this.txtDisc3 = new System.Windows.Forms.TextBox();
			this.txtDisc4 = new System.Windows.Forms.TextBox();
			this.txtDisc5 = new System.Windows.Forms.TextBox();
			this.lblDisc2 = new System.Windows.Forms.Label();
			this.lblDisc3 = new System.Windows.Forms.Label();
			this.lblDisc4 = new System.Windows.Forms.Label();
			this.lblDisc5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDeaCust1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblProducts
			// 
			this.lblProducts.AutoSize = true;
			this.lblProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProducts.Location = new System.Drawing.Point(366, 12);
			this.lblProducts.Name = "lblProducts";
			this.lblProducts.Size = new System.Drawing.Size(187, 21);
			this.lblProducts.TabIndex = 1;
			this.lblProducts.Text = "DEALER AND CUSTOMER";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(877, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// lblDeaCustID
			// 
			this.lblDeaCustID.AutoSize = true;
			this.lblDeaCustID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDeaCustID.Location = new System.Drawing.Point(12, 60);
			this.lblDeaCustID.Name = "lblDeaCustID";
			this.lblDeaCustID.Size = new System.Drawing.Size(80, 17);
			this.lblDeaCustID.TabIndex = 3;
			this.lblDeaCustID.Text = "Customer ID";
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblType.Location = new System.Drawing.Point(13, 103);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(35, 17);
			this.lblType.TabIndex = 4;
			this.lblType.Text = "Type";
			// 
			// lblName1
			// 
			this.lblName1.AutoSize = true;
			this.lblName1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName1.Location = new System.Drawing.Point(13, 154);
			this.lblName1.Name = "lblName1";
			this.lblName1.Size = new System.Drawing.Size(43, 17);
			this.lblName1.TabIndex = 5;
			this.lblName1.Text = "Name";
			// 
			// lblEmail1
			// 
			this.lblEmail1.AutoSize = true;
			this.lblEmail1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail1.Location = new System.Drawing.Point(12, 202);
			this.lblEmail1.Name = "lblEmail1";
			this.lblEmail1.Size = new System.Drawing.Size(39, 17);
			this.lblEmail1.TabIndex = 6;
			this.lblEmail1.Text = "Email";
			// 
			// lblAddress1
			// 
			this.lblAddress1.AutoSize = true;
			this.lblAddress1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAddress1.Location = new System.Drawing.Point(12, 298);
			this.lblAddress1.Name = "lblAddress1";
			this.lblAddress1.Size = new System.Drawing.Size(56, 17);
			this.lblAddress1.TabIndex = 8;
			this.lblAddress1.Text = "Address";
			// 
			// lblContact1
			// 
			this.lblContact1.AutoSize = true;
			this.lblContact1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContact1.Location = new System.Drawing.Point(16, 250);
			this.lblContact1.Name = "lblContact1";
			this.lblContact1.Size = new System.Drawing.Size(52, 17);
			this.lblContact1.TabIndex = 7;
			this.lblContact1.Text = "Contact";
			// 
			// txtDeaCustID1
			// 
			this.txtDeaCustID1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDeaCustID1.Location = new System.Drawing.Point(109, 52);
			this.txtDeaCustID1.Name = "txtDeaCustID1";
			this.txtDeaCustID1.Size = new System.Drawing.Size(228, 25);
			this.txtDeaCustID1.TabIndex = 9;
			// 
			// txtName1
			// 
			this.txtName1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName1.Location = new System.Drawing.Point(109, 146);
			this.txtName1.Name = "txtName1";
			this.txtName1.Size = new System.Drawing.Size(228, 25);
			this.txtName1.TabIndex = 11;
			// 
			// cmbType
			// 
			this.cmbType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Items.AddRange(new object[] {
            "Distributor",
            "Customer"});
			this.cmbType.Location = new System.Drawing.Point(109, 95);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(228, 25);
			this.cmbType.TabIndex = 12;
			// 
			// txtEmail1
			// 
			this.txtEmail1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail1.Location = new System.Drawing.Point(109, 194);
			this.txtEmail1.Name = "txtEmail1";
			this.txtEmail1.Size = new System.Drawing.Size(228, 25);
			this.txtEmail1.TabIndex = 13;
			// 
			// txtContact1
			// 
			this.txtContact1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContact1.Location = new System.Drawing.Point(109, 242);
			this.txtContact1.Name = "txtContact1";
			this.txtContact1.Size = new System.Drawing.Size(228, 25);
			this.txtContact1.TabIndex = 14;
			// 
			// txtAddress1
			// 
			this.txtAddress1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress1.Location = new System.Drawing.Point(109, 278);
			this.txtAddress1.Multiline = true;
			this.txtAddress1.Name = "txtAddress1";
			this.txtAddress1.Size = new System.Drawing.Size(228, 109);
			this.txtAddress1.TabIndex = 15;
			// 
			// btnAdd1
			// 
			this.btnAdd1.BackColor = System.Drawing.Color.ForestGreen;
			this.btnAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd1.Location = new System.Drawing.Point(433, 413);
			this.btnAdd1.Name = "btnAdd1";
			this.btnAdd1.Size = new System.Drawing.Size(117, 33);
			this.btnAdd1.TabIndex = 16;
			this.btnAdd1.Text = "ADD";
			this.btnAdd1.UseVisualStyleBackColor = false;
			this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
			// 
			// btnUpdate1
			// 
			this.btnUpdate1.BackColor = System.Drawing.Color.ForestGreen;
			this.btnUpdate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate1.Location = new System.Drawing.Point(583, 413);
			this.btnUpdate1.Name = "btnUpdate1";
			this.btnUpdate1.Size = new System.Drawing.Size(117, 33);
			this.btnUpdate1.TabIndex = 17;
			this.btnUpdate1.Text = "UPDATE";
			this.btnUpdate1.UseVisualStyleBackColor = false;
			this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate1_Click);
			// 
			// btnDelete1
			// 
			this.btnDelete1.BackColor = System.Drawing.Color.ForestGreen;
			this.btnDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete1.Location = new System.Drawing.Point(728, 413);
			this.btnDelete1.Name = "btnDelete1";
			this.btnDelete1.Size = new System.Drawing.Size(117, 33);
			this.btnDelete1.TabIndex = 18;
			this.btnDelete1.Text = "DELETE";
			this.btnDelete1.UseVisualStyleBackColor = false;
			this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
			// 
			// dgvDeaCust1
			// 
			this.dgvDeaCust1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDeaCust1.Location = new System.Drawing.Point(381, 110);
			this.dgvDeaCust1.Name = "dgvDeaCust1";
			this.dgvDeaCust1.Size = new System.Drawing.Size(517, 283);
			this.dgvDeaCust1.TabIndex = 19;
			this.dgvDeaCust1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDeaCust1_RowHeaderMouseClick);
			// 
			// txtSearch1
			// 
			this.txtSearch1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch1.Location = new System.Drawing.Point(452, 71);
			this.txtSearch1.Name = "txtSearch1";
			this.txtSearch1.Size = new System.Drawing.Size(446, 25);
			this.txtSearch1.TabIndex = 21;
			// 
			// lblSearch1
			// 
			this.lblSearch1.AutoSize = true;
			this.lblSearch1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch1.Location = new System.Drawing.Point(389, 74);
			this.lblSearch1.Name = "lblSearch1";
			this.lblSearch1.Size = new System.Drawing.Size(47, 17);
			this.lblSearch1.TabIndex = 20;
			this.lblSearch1.Text = "Search";
			// 
			// lblDisc1
			// 
			this.lblDisc1.AutoSize = true;
			this.lblDisc1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisc1.Location = new System.Drawing.Point(12, 420);
			this.lblDisc1.Name = "lblDisc1";
			this.lblDisc1.Size = new System.Drawing.Size(92, 17);
			this.lblDisc1.TabIndex = 22;
			this.lblDisc1.Text = "Discount 1 (%)";
			// 
			// txtDisc1
			// 
			this.txtDisc1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDisc1.Location = new System.Drawing.Point(109, 412);
			this.txtDisc1.Name = "txtDisc1";
			this.txtDisc1.Size = new System.Drawing.Size(228, 25);
			this.txtDisc1.TabIndex = 23;
			// 
			// txtDisc2
			// 
			this.txtDisc2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDisc2.Location = new System.Drawing.Point(109, 443);
			this.txtDisc2.Name = "txtDisc2";
			this.txtDisc2.Size = new System.Drawing.Size(228, 25);
			this.txtDisc2.TabIndex = 24;
			// 
			// txtDisc3
			// 
			this.txtDisc3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDisc3.Location = new System.Drawing.Point(109, 474);
			this.txtDisc3.Name = "txtDisc3";
			this.txtDisc3.Size = new System.Drawing.Size(228, 25);
			this.txtDisc3.TabIndex = 25;
			// 
			// txtDisc4
			// 
			this.txtDisc4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDisc4.Location = new System.Drawing.Point(109, 505);
			this.txtDisc4.Name = "txtDisc4";
			this.txtDisc4.Size = new System.Drawing.Size(228, 25);
			this.txtDisc4.TabIndex = 26;
			// 
			// txtDisc5
			// 
			this.txtDisc5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDisc5.Location = new System.Drawing.Point(109, 536);
			this.txtDisc5.Name = "txtDisc5";
			this.txtDisc5.Size = new System.Drawing.Size(228, 25);
			this.txtDisc5.TabIndex = 27;
			// 
			// lblDisc2
			// 
			this.lblDisc2.AutoSize = true;
			this.lblDisc2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisc2.Location = new System.Drawing.Point(12, 446);
			this.lblDisc2.Name = "lblDisc2";
			this.lblDisc2.Size = new System.Drawing.Size(92, 17);
			this.lblDisc2.TabIndex = 28;
			this.lblDisc2.Text = "Discount 2 (%)";
			// 
			// lblDisc3
			// 
			this.lblDisc3.AutoSize = true;
			this.lblDisc3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisc3.Location = new System.Drawing.Point(12, 477);
			this.lblDisc3.Name = "lblDisc3";
			this.lblDisc3.Size = new System.Drawing.Size(92, 17);
			this.lblDisc3.TabIndex = 29;
			this.lblDisc3.Text = "Discount 3 (%)";
			// 
			// lblDisc4
			// 
			this.lblDisc4.AutoSize = true;
			this.lblDisc4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisc4.Location = new System.Drawing.Point(11, 508);
			this.lblDisc4.Name = "lblDisc4";
			this.lblDisc4.Size = new System.Drawing.Size(92, 17);
			this.lblDisc4.TabIndex = 30;
			this.lblDisc4.Text = "Discount 4 (%)";
			this.lblDisc4.Click += new System.EventHandler(this.label4_Click);
			// 
			// lblDisc5
			// 
			this.lblDisc5.AutoSize = true;
			this.lblDisc5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisc5.Location = new System.Drawing.Point(11, 539);
			this.lblDisc5.Name = "lblDisc5";
			this.lblDisc5.Size = new System.Drawing.Size(92, 17);
			this.lblDisc5.TabIndex = 31;
			this.lblDisc5.Text = "Discount 5 (%)";
			// 
			// frmDeaCust
			// 
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(910, 591);
			this.Controls.Add(this.lblDisc5);
			this.Controls.Add(this.lblDisc4);
			this.Controls.Add(this.lblDisc3);
			this.Controls.Add(this.lblDisc2);
			this.Controls.Add(this.txtDisc5);
			this.Controls.Add(this.txtDisc4);
			this.Controls.Add(this.txtDisc3);
			this.Controls.Add(this.txtDisc2);
			this.Controls.Add(this.txtDisc1);
			this.Controls.Add(this.lblDisc1);
			this.Controls.Add(this.txtSearch1);
			this.Controls.Add(this.lblSearch1);
			this.Controls.Add(this.dgvDeaCust1);
			this.Controls.Add(this.btnDelete1);
			this.Controls.Add(this.btnUpdate1);
			this.Controls.Add(this.btnAdd1);
			this.Controls.Add(this.txtAddress1);
			this.Controls.Add(this.txtContact1);
			this.Controls.Add(this.txtEmail1);
			this.Controls.Add(this.cmbType);
			this.Controls.Add(this.txtName1);
			this.Controls.Add(this.txtDeaCustID1);
			this.Controls.Add(this.lblAddress1);
			this.Controls.Add(this.lblContact1);
			this.Controls.Add(this.lblEmail1);
			this.Controls.Add(this.lblName1);
			this.Controls.Add(this.lblType);
			this.Controls.Add(this.lblDeaCustID);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblProducts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmDeaCust";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.frmDeaCust_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDeaCust1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Label lblDeaCust;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblContact;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txtDeaCustID;
		private System.Windows.Forms.ComboBox cmbDeaCust;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtContact;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.DataGridView dgvDeaCust;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.Label lblProducts;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblDeaCustID;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.Label lblName1;
		private System.Windows.Forms.Label lblEmail1;
		private System.Windows.Forms.Label lblAddress1;
		private System.Windows.Forms.Label lblContact1;
		private System.Windows.Forms.TextBox txtDeaCustID1;
		private System.Windows.Forms.TextBox txtName1;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.TextBox txtEmail1;
		private System.Windows.Forms.TextBox txtContact1;
		private System.Windows.Forms.TextBox txtAddress1;
		private System.Windows.Forms.Button btnAdd1;
		private System.Windows.Forms.Button btnUpdate1;
		private System.Windows.Forms.Button btnDelete1;
		private System.Windows.Forms.DataGridView dgvDeaCust1;
		private System.Windows.Forms.TextBox txtSearch1;
		private System.Windows.Forms.Label lblSearch1;
		private System.Windows.Forms.Label lblDisc1;
		private System.Windows.Forms.TextBox txtDisc1;
		private System.Windows.Forms.TextBox txtDisc2;
		private System.Windows.Forms.TextBox txtDisc3;
		private System.Windows.Forms.TextBox txtDisc4;
		private System.Windows.Forms.TextBox txtDisc5;
		private System.Windows.Forms.Label lblDisc2;
		private System.Windows.Forms.Label lblDisc3;
		private System.Windows.Forms.Label lblDisc4;
		private System.Windows.Forms.Label lblDisc5;
	}
}