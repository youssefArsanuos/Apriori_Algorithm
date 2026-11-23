namespace Apriori_Algorithm
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPCSave = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtSupp = new System.Windows.Forms.TextBox();
            this.txtConf = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gpxValues = new System.Windows.Forms.GroupBox();
            this.gpxDetails = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gpxValues.SuspendLayout();
            this.gpxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Support :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Confidence :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPCSave
            // 
            this.btnPCSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPCSave.Location = new System.Drawing.Point(12, 45);
            this.btnPCSave.Name = "btnPCSave";
            this.btnPCSave.Size = new System.Drawing.Size(207, 65);
            this.btnPCSave.TabIndex = 39;
            this.btnPCSave.Text = "Select Data File";
            this.btnPCSave.UseVisualStyleBackColor = true;
            this.btnPCSave.Click += new System.EventHandler(this.btnPCSave_Click);
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(744, 45);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(207, 65);
            this.btnRun.TabIndex = 40;
            this.btnRun.Text = "Run Apriori";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSupp
            // 
            this.txtSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupp.Location = new System.Drawing.Point(193, 56);
            this.txtSupp.Multiline = true;
            this.txtSupp.Name = "txtSupp";
            this.txtSupp.Size = new System.Drawing.Size(47, 34);
            this.txtSupp.TabIndex = 41;
            // 
            // txtConf
            // 
            this.txtConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConf.Location = new System.Drawing.Point(193, 128);
            this.txtConf.Multiline = true;
            this.txtConf.Name = "txtConf";
            this.txtConf.Size = new System.Drawing.Size(47, 34);
            this.txtConf.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(798, 608);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 65);
            this.button2.TabIndex = 43;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gpxValues
            // 
            this.gpxValues.Controls.Add(this.label4);
            this.gpxValues.Controls.Add(this.label1);
            this.gpxValues.Controls.Add(this.txtConf);
            this.gpxValues.Controls.Add(this.txtSupp);
            this.gpxValues.Enabled = false;
            this.gpxValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxValues.Location = new System.Drawing.Point(317, 26);
            this.gpxValues.Name = "gpxValues";
            this.gpxValues.Size = new System.Drawing.Size(321, 192);
            this.gpxValues.TabIndex = 44;
            this.gpxValues.TabStop = false;
            this.gpxValues.Text = "Values";
            // 
            // gpxDetails
            // 
            this.gpxDetails.Controls.Add(this.button4);
            this.gpxDetails.Controls.Add(this.button3);
            this.gpxDetails.Controls.Add(this.button1);
            this.gpxDetails.Enabled = false;
            this.gpxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxDetails.Location = new System.Drawing.Point(60, 224);
            this.gpxDetails.Name = "gpxDetails";
            this.gpxDetails.Size = new System.Drawing.Size(853, 368);
            this.gpxDetails.TabIndex = 45;
            this.gpxDetails.TabStop = false;
            this.gpxDetails.Text = "Details";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(298, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 65);
            this.button3.TabIndex = 47;
            this.button3.Text = "Show Association Rules";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(26, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 65);
            this.button1.TabIndex = 46;
            this.button1.Text = "Show Sets and Support";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(579, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 65);
            this.button4.TabIndex = 48;
            this.button4.Text = "Show Visualizations ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 717);
            this.Controls.Add(this.gpxDetails);
            this.Controls.Add(this.gpxValues);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnPCSave);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpxValues.ResumeLayout(false);
            this.gpxValues.PerformLayout();
            this.gpxDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPCSave;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtSupp;
        private System.Windows.Forms.TextBox txtConf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gpxValues;
        private System.Windows.Forms.GroupBox gpxDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

