namespace FurtinureMart
{
	partial class frmUserDashboard
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
			this.menuStripTop = new System.Windows.Forms.MenuStrip();
			this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dealerAndCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblSHead = new System.Windows.Forms.Label();
			this.lblLName = new System.Windows.Forms.Label();
			this.lblAppFName = new System.Windows.Forms.Label();
			this.lblLoggedInUser = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.paneFooter = new System.Windows.Forms.Panel();
			this.lblFooter = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblusername = new System.Windows.Forms.Label();
			this.menuStripTop.SuspendLayout();
			this.paneFooter.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripTop
			// 
			this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesFormsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.dealerAndCustomerToolStripMenuItem});
			this.menuStripTop.Location = new System.Drawing.Point(0, 0);
			this.menuStripTop.Name = "menuStripTop";
			this.menuStripTop.Size = new System.Drawing.Size(1256, 24);
			this.menuStripTop.TabIndex = 0;
			this.menuStripTop.Text = "menuStrip1";
			// 
			// purchaseToolStripMenuItem
			// 
			this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
			this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.purchaseToolStripMenuItem.Text = "Purchase";
			this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
			// 
			// salesFormsToolStripMenuItem
			// 
			this.salesFormsToolStripMenuItem.Name = "salesFormsToolStripMenuItem";
			this.salesFormsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.salesFormsToolStripMenuItem.Text = "Sales ";
			this.salesFormsToolStripMenuItem.Click += new System.EventHandler(this.salesFormsToolStripMenuItem_Click);
			// 
			// inventoryToolStripMenuItem
			// 
			this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
			this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.inventoryToolStripMenuItem.Text = "Inventory";
			this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
			// 
			// dealerAndCustomerToolStripMenuItem
			// 
			this.dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
			this.dealerAndCustomerToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
			this.dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
			this.dealerAndCustomerToolStripMenuItem.Click += new System.EventHandler(this.dealerAndCustomerToolStripMenuItem_Click);
			// 
			// lblSHead
			// 
			this.lblSHead.AutoSize = true;
			this.lblSHead.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSHead.ForeColor = System.Drawing.Color.LimeGreen;
			this.lblSHead.Location = new System.Drawing.Point(460, 291);
			this.lblSHead.Name = "lblSHead";
			this.lblSHead.Size = new System.Drawing.Size(314, 25);
			this.lblSHead.TabIndex = 12;
			this.lblSHead.Text = "Billing And Inventory Management";
			// 
			// lblLName
			// 
			this.lblLName.AutoSize = true;
			this.lblLName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLName.Location = new System.Drawing.Point(639, 254);
			this.lblLName.Name = "lblLName";
			this.lblLName.Size = new System.Drawing.Size(135, 37);
			this.lblLName.TabIndex = 11;
			this.lblLName.Text = "Furniture";
			// 
			// lblAppFName
			// 
			this.lblAppFName.AutoSize = true;
			this.lblAppFName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppFName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblAppFName.Location = new System.Drawing.Point(474, 254);
			this.lblAppFName.Name = "lblAppFName";
			this.lblAppFName.Size = new System.Drawing.Size(158, 37);
			this.lblAppFName.TabIndex = 10;
			this.lblAppFName.Text = "Ragavendra";
			// 
			// lblLoggedInUser
			// 
			this.lblLoggedInUser.AutoSize = true;
			this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLoggedInUser.ForeColor = System.Drawing.Color.LimeGreen;
			this.lblLoggedInUser.Location = new System.Drawing.Point(-99, 14);
			this.lblLoggedInUser.Name = "lblLoggedInUser";
			this.lblLoggedInUser.Size = new System.Drawing.Size(88, 17);
			this.lblLoggedInUser.TabIndex = 9;
			this.lblLoggedInUser.Text = "Hari Vignesh";
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblUser.Location = new System.Drawing.Point(-134, 14);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(38, 17);
			this.lblUser.TabIndex = 8;
			this.lblUser.Text = "User:";
			// 
			// paneFooter
			// 
			this.paneFooter.BackColor = System.Drawing.Color.Teal;
			this.paneFooter.Controls.Add(this.lblFooter);
			this.paneFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.paneFooter.Location = new System.Drawing.Point(0, 390);
			this.paneFooter.Name = "paneFooter";
			this.paneFooter.Size = new System.Drawing.Size(1256, 44);
			this.paneFooter.TabIndex = 7;
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
			this.lblFooter.Click += new System.EventHandler(this.lblFooter_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LimeGreen;
			this.label1.Location = new System.Drawing.Point(41, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 17);
			this.label1.TabIndex = 14;
			// 
			// lblusername
			// 
			this.lblusername.AutoSize = true;
			this.lblusername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblusername.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblusername.Location = new System.Drawing.Point(-3, 35);
			this.lblusername.Name = "lblusername";
			this.lblusername.Size = new System.Drawing.Size(38, 17);
			this.lblusername.TabIndex = 13;
			this.lblusername.Text = "User:";
			this.lblusername.Click += new System.EventHandler(this.label2_Click);
			// 
			// frmUserDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1256, 434);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblusername);
			this.Controls.Add(this.lblSHead);
			this.Controls.Add(this.lblLName);
			this.Controls.Add(this.lblAppFName);
			this.Controls.Add(this.lblLoggedInUser);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.paneFooter);
			this.Controls.Add(this.menuStripTop);
			this.MainMenuStrip = this.menuStripTop;
			this.Name = "frmUserDashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User Dashboard";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUserDashboard_FormClosed);
			this.Load += new System.EventHandler(this.frmUserDashboard_Load);
			this.menuStripTop.ResumeLayout(false);
			this.menuStripTop.PerformLayout();
			this.paneFooter.ResumeLayout(false);
			this.paneFooter.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripTop;
		private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salesFormsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
		private System.Windows.Forms.Label lblSHead;
		private System.Windows.Forms.Label lblLName;
		private System.Windows.Forms.Label lblAppFName;
		private System.Windows.Forms.Label lblLoggedInUser;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Panel paneFooter;
		private System.Windows.Forms.Label lblFooter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblusername;
		private System.Windows.Forms.ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
	}
}