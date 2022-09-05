namespace Midterm
{
    partial class listAllCustomers
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
            this.dGrdView = new System.Windows.Forms.DataGridView();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGrdView)).BeginInit();
            this.SuspendLayout();
            // 
            // dGrdView
            // 
            this.dGrdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrdView.Location = new System.Drawing.Point(0, 0);
            this.dGrdView.Name = "dGrdView";
            this.dGrdView.RowTemplate.Height = 25;
            this.dGrdView.Size = new System.Drawing.Size(800, 304);
            this.dGrdView.TabIndex = 0;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(377, 321);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // listAllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 356);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dGrdView);
            this.Name = "listAllCustomers";
            this.Text = "List All Customers";
            this.Load += new System.EventHandler(this.listAllCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGrdView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dGrdView;
        private Button btnclose;
    }
}