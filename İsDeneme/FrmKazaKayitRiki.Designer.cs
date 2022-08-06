namespace İsDeneme
{
    partial class FrmKazaKayitRiki
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
            this.pictureZR2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZR2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureZR2
            // 
            this.pictureZR2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureZR2.Location = new System.Drawing.Point(0, 0);
            this.pictureZR2.Name = "pictureZR2";
            this.pictureZR2.Size = new System.Drawing.Size(984, 622);
            this.pictureZR2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureZR2.TabIndex = 0;
            this.pictureZR2.TabStop = false;
            // 
            // FrmKazaKayitRiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 622);
            this.Controls.Add(this.pictureZR2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKazaKayitRiki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resim 2";
            this.Load += new System.EventHandler(this.FrmKazaKayitRiki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureZR2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureZR2;
    }
}