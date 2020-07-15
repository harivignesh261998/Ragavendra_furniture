namespace FurtinureMart.UI
{
	partial class frmTransaction
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaction));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTop = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblTransaction = new System.Windows.Forms.Label();
			this.btnShow = new System.Windows.Forms.Button();
			this.dgvTransation = new System.Windows.Forms.DataGridView();
			this.cmbTransaction = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTransation)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.lblTop);
			this.panel1.Location = new System.Drawing.Point(0, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(871, 50);
			this.panel1.TabIndex = 0;
			// 
			// lblTop
			// 
			this.lblTop.AutoSize = true;
			this.lblTop.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTop.Location = new System.Drawing.Point(352, 7);
			this.lblTop.Name = "lblTop";
			this.lblTop.Size = new System.Drawing.Size(154, 30);
			this.lblTop.TabIndex = 0;
			this.lblTop.Text = "TRANSACTION";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(839, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(29, 27);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// lblTransaction
			// 
			this.lblTransaction.AutoSize = true;
			this.lblTransaction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTransaction.Location = new System.Drawing.Point(13, 86);
			this.lblTransaction.Name = "lblTransaction";
			this.lblTransaction.Size = new System.Drawing.Size(105, 17);
			this.lblTransaction.TabIndex = 1;
			this.lblTransaction.Text = "Transaction Type";
			// 
			// btnShow
			// 
			this.btnShow.Location = new System.Drawing.Point(502, 86);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(119, 25);
			this.btnShow.TabIndex = 3;
			this.btnShow.Text = "Show All";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// dgvTransation
			// 
			this.dgvTransation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTransation.Location = new System.Drawing.Point(12, 135);
			this.dgvTransation.Name = "dgvTransation";
			this.dgvTransation.Size = new System.Drawing.Size(846, 378);
			this.dgvTransation.TabIndex = 4;
			// 
			// cmbTransaction
			// 
			this.cmbTransaction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTransaction.FormattingEnabled = true;
			this.cmbTransaction.Items.AddRange(new object[] {
            "Purchase",
            "Sales"});
			this.cmbTransaction.Location = new System.Drawing.Point(125, 86);
			this.cmbTransaction.Name = "cmbTransaction";
			this.cmbTransaction.Size = new System.Drawing.Size(335, 25);
			this.cmbTransaction.TabIndex = 5;
			this.cmbTransaction.SelectedIndexChanged += new System.EventHandler(this.cmbTransaction_SelectedIndexChanged);
			// 
			// frmTransaction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(870, 525);
			this.Controls.Add(this.cmbTransaction);
			this.Controls.Add(this.dgvTransation);
			this.Controls.Add(this.btnShow);
			this.Controls.Add(this.lblTransaction);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmTransaction";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TRANSACTIONS";
			this.Load += new System.EventHandler(this.frmTransaction_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTransation)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblTop;
		private System.Windows.Forms.Label lblTransaction;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.DataGridView dgvTransation;
		private System.Windows.Forms.ComboBox cmbTransaction;
	}
}