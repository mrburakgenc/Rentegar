namespace İsDeneme
{
    partial class FrmEhliyetKimlik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEhliyetKimlik));
            this.AdobeEhliyetKimlikAc = new AxAcroPDFLib.AxAcroPDF();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdobeEhliyetKimlikAc)).BeginInit();
            this.SuspendLayout();
            // 
            // AdobeEhliyetKimlikAc
            // 
            this.AdobeEhliyetKimlikAc.Enabled = true;
            this.AdobeEhliyetKimlikAc.Location = new System.Drawing.Point(3, 49);
            this.AdobeEhliyetKimlikAc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdobeEhliyetKimlikAc.Name = "AdobeEhliyetKimlikAc";
            this.AdobeEhliyetKimlikAc.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AdobeEhliyetKimlikAc.OcxState")));
            this.AdobeEhliyetKimlikAc.Size = new System.Drawing.Size(877, 613);
            this.AdobeEhliyetKimlikAc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(807, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(232, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ehliyet - Kimlik Bilgileri";
            // 
            // FrmEhliyetKimlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdobeEhliyetKimlikAc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmEhliyetKimlik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ehliyet-Kimlik Paneli";
            this.Load += new System.EventHandler(this.FrmEhliyetKimlik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdobeEhliyetKimlikAc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF AdobeEhliyetKimlikAc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}