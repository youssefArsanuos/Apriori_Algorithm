namespace Apriori_Algorithm
{
    partial class frmShowVisualizations
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSupport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartSupport)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSupport
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSupport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSupport.Legends.Add(legend1);
            this.chartSupport.Location = new System.Drawing.Point(12, 31);
            this.chartSupport.Name = "chartSupport";
            this.chartSupport.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSupport.Series.Add(series1);
            this.chartSupport.Size = new System.Drawing.Size(1493, 743);
            this.chartSupport.TabIndex = 0;
            this.chartSupport.Text = "chartSupport";
            // 
            // frmShowVisualizations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 786);
            this.Controls.Add(this.chartSupport);
            this.Name = "frmShowVisualizations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowVisualizations";
            this.Load += new System.EventHandler(this.frmShowVisualizations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSupport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSupport;
    }
}