namespace İsDeneme
{
    partial class FrmMyBelgesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMyBelgesi));
            this.label2 = new System.Windows.Forms.Label();
            this.AdobeMYAc = new AxAcroPDFLib.AxAcroPDF();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdobeMYAc)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(238, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mesleki Yeterlilik Belgesi";
            // 
            // AdobeMYAc
            // 
            this.AdobeMYAc.Enabled = true;
            this.AdobeMYAc.Location = new System.Drawing.Point(3, 44);
            this.AdobeMYAc.Name = "AdobeMYAc";
            this.AdobeMYAc.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AdobeMYAc.OcxState")));
            this.AdobeMYAc.Size = new System.Drawing.Size(878, 609);
            this.AdobeMYAc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(781, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmMyBelgesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdobeMYAc);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMyBelgesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesleki Yeterlilik Formu";
            this.Load += new System.EventHandler(this.FrmMyBelgesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdobeMYAc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private AxAcroPDFLib.AxAcroPDF AdobeMYAc;
        private System.Windows.Forms.Label label1;
    }
}