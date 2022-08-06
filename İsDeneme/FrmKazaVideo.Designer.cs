namespace İsDeneme
{
    partial class FrmKazaVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKazaVideo));
            this.axMediaKazaVideo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axMediaKazaVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // axMediaKazaVideo
            // 
            this.axMediaKazaVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMediaKazaVideo.Enabled = true;
            this.axMediaKazaVideo.Location = new System.Drawing.Point(0, 0);
            this.axMediaKazaVideo.Name = "axMediaKazaVideo";
            this.axMediaKazaVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMediaKazaVideo.OcxState")));
            this.axMediaKazaVideo.Size = new System.Drawing.Size(890, 602);
            this.axMediaKazaVideo.TabIndex = 0;
            // 
            // FrmKazaVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 602);
            this.Controls.Add(this.axMediaKazaVideo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKazaVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kaza Video";
            this.Load += new System.EventHandler(this.FrmKazaVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axMediaKazaVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axMediaKazaVideo;
    }
}