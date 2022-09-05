namespace Midterm
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUpdateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersHvingTheirBirthdaysTodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUpdateCustomerToolStripMenuItem,
            this.listAllCustomersToolStripMenuItem,
            this.customersHvingTheirBirthdaysTodayToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // addUpdateCustomerToolStripMenuItem
            // 
            this.addUpdateCustomerToolStripMenuItem.Name = "addUpdateCustomerToolStripMenuItem";
            this.addUpdateCustomerToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.addUpdateCustomerToolStripMenuItem.Text = "Add/Update Customer";
            this.addUpdateCustomerToolStripMenuItem.Click += new System.EventHandler(this.addUpdateCustomerToolStripMenuItem_Click);
            // 
            // listAllCustomersToolStripMenuItem
            // 
            this.listAllCustomersToolStripMenuItem.Name = "listAllCustomersToolStripMenuItem";
            this.listAllCustomersToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.listAllCustomersToolStripMenuItem.Text = "List All Customers";
            this.listAllCustomersToolStripMenuItem.Click += new System.EventHandler(this.listAllCustomersToolStripMenuItem_Click);
            // 
            // customersHvingTheirBirthdaysTodayToolStripMenuItem
            // 
            this.customersHvingTheirBirthdaysTodayToolStripMenuItem.Name = "customersHvingTheirBirthdaysTodayToolStripMenuItem";
            this.customersHvingTheirBirthdaysTodayToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.customersHvingTheirBirthdaysTodayToolStripMenuItem.Text = "Customers Having Their Birthdays Today";
            this.customersHvingTheirBirthdaysTodayToolStripMenuItem.Click += new System.EventHandler(this.customersHvingTheirBirthdaysTodayToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 46);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem addUpdateCustomerToolStripMenuItem;
        private ToolStripMenuItem listAllCustomersToolStripMenuItem;
        private ToolStripMenuItem customersHvingTheirBirthdaysTodayToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}