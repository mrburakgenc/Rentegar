namespace İsDeneme
{
    partial class SfEvrakDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SfEvrakDuzenle));
            this.TxtEvrakDosyaYoluEkle = new System.Windows.Forms.TextBox();
            this.AdobeEvrakEkle = new AxAcroPDFLib.AxAcroPDF();
            this.BtnEKEkle = new System.Windows.Forms.Button();
            this.BtnIsBEkle = new System.Windows.Forms.Button();
            this.BtnASEkle = new System.Windows.Forms.Button();
            this.BtnMyEkle = new System.Windows.Forms.Button();
            this.BtnSrcEkle = new System.Windows.Forms.Button();
            this.BtnIkEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdobeEvrakEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtEvrakDosyaYoluEkle
            // 
            this.TxtEvrakDosyaYoluEkle.Enabled = false;
            this.TxtEvrakDosyaYoluEkle.Location = new System.Drawing.Point(111, 138);
            this.TxtEvrakDosyaYoluEkle.Name = "TxtEvrakDosyaYoluEkle";
            this.TxtEvrakDosyaYoluEkle.Size = new System.Drawing.Size(689, 30);
            this.TxtEvrakDosyaYoluEkle.TabIndex = 0;
            this.TxtEvrakDosyaYoluEkle.Text = ".";
            // 
            // AdobeEvrakEkle
            // 
            this.AdobeEvrakEkle.Enabled = true;
            this.AdobeEvrakEkle.Location = new System.Drawing.Point(7, 174);
            this.AdobeEvrakEkle.Name = "AdobeEvrakEkle";
            this.AdobeEvrakEkle.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AdobeEvrakEkle.OcxState")));
            this.AdobeEvrakEkle.Size = new System.Drawing.Size(799, 529);
            this.AdobeEvrakEkle.TabIndex = 1;
            // 
            // BtnEKEkle
            // 
            this.BtnEKEkle.BackColor = System.Drawing.Color.Crimson;
            this.BtnEKEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEKEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEKEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEKEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEKEkle.Location = new System.Drawing.Point(10, 10);
            this.BtnEKEkle.Name = "BtnEKEkle";
            this.BtnEKEkle.Size = new System.Drawing.Size(378, 34);
            this.BtnEKEkle.TabIndex = 2;
            this.BtnEKEkle.Text = "Ehliyet-Kimlik Bilgisi Ekle";
            this.BtnEKEkle.UseVisualStyleBackColor = false;
            this.BtnEKEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnIsBEkle
            // 
            this.BtnIsBEkle.BackColor = System.Drawing.Color.Crimson;
            this.BtnIsBEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIsBEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIsBEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnIsBEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnIsBEkle.Location = new System.Drawing.Point(424, 50);
            this.BtnIsBEkle.Name = "BtnIsBEkle";
            this.BtnIsBEkle.Size = new System.Drawing.Size(376, 34);
            this.BtnIsBEkle.TabIndex = 3;
            this.BtnIsBEkle.Text = "İş Başvuru Formu Ekle";
            this.BtnIsBEkle.UseVisualStyleBackColor = false;
            this.BtnIsBEkle.Click += new System.EventHandler(this.BtnIsBEkle_Click);
            // 
            // BtnASEkle
            // 
            this.BtnASEkle.BackColor = System.Drawing.Color.Crimson;
            this.BtnASEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnASEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnASEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnASEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnASEkle.Location = new System.Drawing.Point(424, 10);
            this.BtnASEkle.Name = "BtnASEkle";
            this.BtnASEkle.Size = new System.Drawing.Size(376, 34);
            this.BtnASEkle.TabIndex = 4;
            this.BtnASEkle.Text = "Adli Sicil Kaydı Ekle";
            this.BtnASEkle.UseVisualStyleBackColor = false;
            this.BtnASEkle.Click += new System.EventHandler(this.BtnASEkle_Click);
            // 
            // BtnMyEkle
            // 
            this.BtnMyEkle.BackColor = System.Drawing.Color.Crimson;
            this.BtnMyEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMyEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMyEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMyEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMyEkle.Location = new System.Drawing.Point(10, 90);
            this.BtnMyEkle.Name = "BtnMyEkle";
            this.BtnMyEkle.Size = new System.Drawing.Size(378, 34);
            this.BtnMyEkle.TabIndex = 5;
            this.BtnMyEkle.Text = "Mesleki Yeterlilik Belgesi Ekle";
            this.BtnMyEkle.UseVisualStyleBackColor = false;
            this.BtnMyEkle.Click += new System.EventHandler(this.BtnMyEkle_Click);
            // 
            // BtnSrcEkle
            // 
            this.BtnSrcEkle.BackColor = System.Drawing.Color.Crimson;
            this.BtnSrcEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSrcEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSrcEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSrcEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSrcEkle.Location = new System.Drawing.Point(10, 50);
            this.BtnSrcEkle.Name = "BtnSrcEkle";
            this.BtnSrcEkle.Size = new System.Drawing.Size(378, 34);
            this.BtnSrcEkle.TabIndex = 6;
            this.BtnSrcEkle.Text = "SRC Belgesi Ekle";
            this.BtnSrcEkle.UseVisualStyleBackColor = false;
            this.BtnSrcEkle.Click += new System.EventHandler(this.BtnSrcEkle_Click);
            // 
            // BtnIkEkle
            // 
            this.BtnIkEkle.BackColor = System.Drawing.Color.Crimson;
            this.BtnIkEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIkEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIkEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnIkEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnIkEkle.Location = new System.Drawing.Point(424, 90);
            this.BtnIkEkle.Name = "BtnIkEkle";
            this.BtnIkEkle.Size = new System.Drawing.Size(376, 34);
            this.BtnIkEkle.TabIndex = 7;
            this.BtnIkEkle.Text = "Yerleşim Yeri (İkametgah) Ekle";
            this.BtnIkEkle.UseVisualStyleBackColor = false;
            this.BtnIkEkle.Click += new System.EventHandler(this.BtnIkEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dosya Yolu:";
            // 
            // SfEvrakDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(812, 704);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIkEkle);
            this.Controls.Add(this.BtnSrcEkle);
            this.Controls.Add(this.BtnMyEkle);
            this.Controls.Add(this.BtnASEkle);
            this.Controls.Add(this.BtnIsBEkle);
            this.Controls.Add(this.BtnEKEkle);
            this.Controls.Add(this.AdobeEvrakEkle);
            this.Controls.Add(this.TxtEvrakDosyaYoluEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SfEvrakDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evrak Kontrol Paneli";
            this.Load += new System.EventHandler(this.SfEvrakDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdobeEvrakEkle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEvrakDosyaYoluEkle;
        private AxAcroPDFLib.AxAcroPDF AdobeEvrakEkle;
        private System.Windows.Forms.Button BtnEKEkle;
        private System.Windows.Forms.Button BtnIsBEkle;
        private System.Windows.Forms.Button BtnASEkle;
        private System.Windows.Forms.Button BtnMyEkle;
        private System.Windows.Forms.Button BtnSrcEkle;
        private System.Windows.Forms.Button BtnIkEkle;
        private System.Windows.Forms.Label label1;
    }
}