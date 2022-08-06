namespace İsDeneme
{
    partial class FrmIkametBelgesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIkametBelgesi));
            this.label2 = new System.Windows.Forms.Label();
            this.AdobeIkametAc = new AxAcroPDFLib.AxAcroPDF();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdobeIkametAc)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(204, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yerleşim Yeri (İkametgah) Belgesi";
            // 
            // AdobeIkametAc
            // 
            this.AdobeIkametAc.Enabled = true;
            this.AdobeIkametAc.Location = new System.Drawing.Point(1, 51);
            this.AdobeIkametAc.Name = "AdobeIkametAc";
            this.AdobeIkametAc.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AdobeIkametAc.OcxState")));
            this.AdobeIkametAc.Size = new System.Drawing.Size(879, 602);
            this.AdobeIkametAc.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(816, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmIkametBelgesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdobeIkametAc);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmIkametBelgesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İkametgah Paneli";
            this.Load += new System.EventHandler(this.FrmIkametBelgesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdobeIkametAc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private AxAcroPDFLib.AxAcroPDF AdobeIkametAc;
        private System.Windows.Forms.Label label1;
    }
}