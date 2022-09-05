namespace Midterm
{
    partial class Birthdays
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
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGrdView)).BeginInit();
            this.SuspendLayout();
            // 
            // dGrdView
            // 
            this.dGrdView.AllowUserToAddRows = false;
            this.dGrdView.AllowUserToDeleteRows = false;
            this.dGrdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrdView.Location = new System.Drawing.Point(12, 12);
            this.dGrdView.Name = "dGrdView";
            this.dGrdView.ReadOnly = true;
            this.dGrdView.RowTemplate.Height = 25;
            this.dGrdView.Size = new System.Drawing.Size(699, 308);
            this.dGrdView.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(329, 341);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Birthdays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 376);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dGrdView);
            this.Name = "Birthdays";
            this.Text = "Customers Having Birthdays Today";
            this.Load += new System.EventHandler(this.Birthdays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGrdView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dGrdView;
        private Button btnClose;
    }
}