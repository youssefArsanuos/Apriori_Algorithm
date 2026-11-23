namespace Apriori_Algorithm
{
    partial class frmSupportAndSets
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
            this.dvgSetsAndSupp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSetsAndSupp)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgSetsAndSupp
            // 
            this.dvgSetsAndSupp.AllowUserToAddRows = false;
            this.dvgSetsAndSupp.AllowUserToDeleteRows = false;
            this.dvgSetsAndSupp.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgSetsAndSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSetsAndSupp.Location = new System.Drawing.Point(26, 25);
            this.dvgSetsAndSupp.Name = "dvgSetsAndSupp";
            this.dvgSetsAndSupp.ReadOnly = true;
            this.dvgSetsAndSupp.RowHeadersWidth = 51;
            this.dvgSetsAndSupp.RowTemplate.Height = 24;
            this.dvgSetsAndSupp.Size = new System.Drawing.Size(891, 371);
            this.dvgSetsAndSupp.TabIndex = 47;
            // 
            // frmSupportAndSets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 422);
            this.Controls.Add(this.dvgSetsAndSupp);
            this.Name = "frmSupportAndSets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSupportAndSets";
            this.Load += new System.EventHandler(this.frmSupportAndSets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgSetsAndSupp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgSetsAndSupp;
    }
}