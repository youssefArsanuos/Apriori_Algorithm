namespace Apriori_Algorithm
{
    partial class frmShowAssociationRules
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
            this.dvgShowAssoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgShowAssoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgShowAssoc
            // 
            this.dvgShowAssoc.AllowUserToAddRows = false;
            this.dvgShowAssoc.AllowUserToDeleteRows = false;
            this.dvgShowAssoc.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgShowAssoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgShowAssoc.Location = new System.Drawing.Point(18, 24);
            this.dvgShowAssoc.Name = "dvgShowAssoc";
            this.dvgShowAssoc.ReadOnly = true;
            this.dvgShowAssoc.RowHeadersWidth = 51;
            this.dvgShowAssoc.RowTemplate.Height = 24;
            this.dvgShowAssoc.Size = new System.Drawing.Size(891, 371);
            this.dvgShowAssoc.TabIndex = 48;
            // 
            // frmShowAssociationRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 416);
            this.Controls.Add(this.dvgShowAssoc);
            this.Name = "frmShowAssociationRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowAssociationRules";
            this.Load += new System.EventHandler(this.frmShowAssociationRules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgShowAssoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgShowAssoc;
    }
}