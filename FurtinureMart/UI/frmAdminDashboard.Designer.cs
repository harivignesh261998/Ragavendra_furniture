namespace FurtinureMart
{
	partial class frmAdminDashboard
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
			this.paneFooter = new System.Windows.Forms.Panel();
			this.lblFooter = new System.Windows.Forms.Label();
			this.menuStripTop = new System.Windows.Forms.MenuStrip();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dealerAndCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblUser = new System.Windows.Forms.Label();
			this.lblLoggedInUser = new System.Windows.Forms.Label();
			this.lblAppFName = new System.Windows.Forms.Label();
			this.lblLName = new System.Windows.Forms.Label();
			this.lblSHead = new System.Windows.Forms.Label();
			this.paneFooter.SuspendLayout();
			this.menuStripTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// paneFooter
			// 
			this.paneFooter.BackColor = System.Drawing.Color.Teal;
			this.paneFooter.Controls.Add(this.lblFooter);
			this.paneFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.paneFooter.Location = new System.Drawing.Point(0, 390);
			this.paneFooter.Name = "paneFooter";
			this.paneFooter.Size = new System.Drawing.Size(1256, 44);
			this.paneFooter.TabIndex = 0;
			// 
			// lblFooter
			// 
			this.lblFooter.AutoSize = true;
			this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFooter.ForeColor = System.Drawing.Color.White;
			this.lblFooter.Location = new System.Drawing.Point(3, 18);
			this.lblFooter.Name = "lblFooter";
			this.lblFooter.Size = new System.Drawing.Size(0, 17);
			this.lblFooter.TabIndex = 0;
			// 
			// menuStripTop
			// 
			this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.inventryToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.dealerAndCustomerToolStripMenuItem});
			this.menuStripTop.Location = new System.Drawing.Point(0, 0);
			this.menuStripTop.Name = "menuStripTop";
			this.menuStripTop.Size = new System.Drawing.Size(1256, 24);
			this.menuStripTop.TabIndex = 1;
			this.menuStripTop.Text = "menuStrip1";
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.usersToolStripMenuItem.Text = "Users";
			this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
			// 
			// categoryToolStripMenuItem
			// 
			this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
			this.categoryToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
			this.categoryToolStripMenuItem.Text = "Categories";
			this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
			// 
			// productsToolStripMenuItem
			// 
			this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
			this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.productsToolStripMenuItem.Text = "Products";
			this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
			// 
			// inventryToolStripMenuItem
			// 
			this.inventryToolStripMenuItem.Name = "inventryToolStripMenuItem";
			this.inventryToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.inventryToolStripMenuItem.Text = "Inventry";
			this.inventryToolStripMenuItem.Click += new System.EventHandler(this.inventryToolStripMenuItem_Click);
			// 
			// transactionToolStripMenuItem
			// 
			this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
			this.transactionToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.transactionToolStripMenuItem.Text = "Transaction";
			this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
			// 
			// dealerAndCustomerToolStripMenuItem
			// 
			this.dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
			this.dealerAndCustomerToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
			this.dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
			this.dealerAndCustomerToolStripMenuItem.Click += new System.EventHandler(this.dealerAndCustomerToolStripMenuItem_Click);
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblUser.Location = new System.Drawing.Point(0, 28);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(38, 17);
			this.lblUser.TabIndex = 2;
			this.lblUser.Text = "User:";
			this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
			// 
			// lblLoggedInUser
			// 
			this.lblLoggedInUser.AutoSize = true;
			this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLoggedInUser.ForeColor = System.Drawing.Color.LimeGreen;
			this.lblLoggedInUser.Location = new System.Drawing.Point(35, 28);
			this.lblLoggedInUser.Name = "lblLoggedInUser";
			this.lblLoggedInUser.Size = new System.Drawing.Size(0, 17);
			this.lblLoggedInUser.TabIndex = 3;
			// 
			// lblAppFName
			// 
			this.lblAppFName.AutoSize = true;
			this.lblAppFName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppFName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblAppFName.Location = new System.Drawing.Point(760, 320);
			this.lblAppFName.Name = "lblAppFName";
			this.lblAppFName.Size = new System.Drawing.Size(158, 37);
			this.lblAppFName.TabIndex = 4;
			this.lblAppFName.Text = "Ragavendra";
			// 
			// lblLName
			// 
			this.lblLName.AutoSize = true;
			this.lblLName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLName.Location = new System.Drawing.Point(909, 320);
			this.lblLName.Name = "lblLName";
			this.lblLName.Size = new System.Drawing.Size(135, 37);
			this.lblLName.TabIndex = 5;
			this.lblLName.Text = "Furniture";
			// 
			// lblSHead
			// 
			this.lblSHead.AutoSize = true;
			this.lblSHead.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSHead.Location = new System.Drawing.Point(754, 357);
			this.lblSHead.Name = "lblSHead";
			this.lblSHead.Size = new System.Drawing.Size(314, 25);
			this.lblSHead.TabIndex = 6;
			this.lblSHead.Text = "Billing And Inventory Management";
			this.lblSHead.Click += new System.EventHandler(this.lblSHead_Click);
			// 
			// frmAdminDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1256, 434);
			this.Controls.Add(this.lblSHead);
			this.Controls.Add(this.lblLName);
			this.Controls.Add(this.lblAppFName);
			this.Controls.Add(this.lblLoggedInUser);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.paneFooter);
			this.Controls.Add(this.menuStripTop);
			this.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.MainMenuStrip = this.menuStripTop;
			this.Name = "frmAdminDashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminDashboard";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminDashboard_FormClosed);
			this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
			this.paneFooter.ResumeLayout(false);
			this.paneFooter.PerformLayout();
			this.menuStripTop.ResumeLayout(false);
			this.menuStripTop.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel paneFooter;
		private System.Windows.Forms.Label lblFooter;
		private System.Windows.Forms.MenuStrip menuStripTop;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inventryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblLoggedInUser;
		private System.Windows.Forms.Label lblAppFName;
		private System.Windows.Forms.Label lblLName;
		private System.Windows.Forms.Label lblSHead;
		private System.Windows.Forms.ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
	}
}

