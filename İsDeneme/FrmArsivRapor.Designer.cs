namespace İsDeneme
{
    partial class FrmArsivRapor
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DenemeİsDataSetArsiv = new İsDeneme.DenemeİsDataSetArsiv();
            this.Tbl_SoforlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tbl_SoforlerTableAdapter = new İsDeneme.DenemeİsDataSetArsivTableAdapters.Tbl_SoforlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DenemeİsDataSetArsiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_SoforlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetArsiv";
            reportDataSource1.Value = this.Tbl_SoforlerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "İsDeneme.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(714, 581);
            this.reportViewer1.TabIndex = 0;
            // 
            // DenemeİsDataSetArsiv
            // 
            this.DenemeİsDataSetArsiv.DataSetName = "DenemeİsDataSetArsiv";
            this.DenemeİsDataSetArsiv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tbl_SoforlerBindingSource
            // 
            this.Tbl_SoforlerBindingSource.DataMember = "Tbl_Soforler";
            this.Tbl_SoforlerBindingSource.DataSource = this.DenemeİsDataSetArsiv;
            // 
            // Tbl_SoforlerTableAdapter
            // 
            this.Tbl_SoforlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmArsivRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(714, 581);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmArsivRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arşiv Rapor";
            this.Load += new System.EventHandler(this.FrmArsivRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DenemeİsDataSetArsiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_SoforlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tbl_SoforlerBindingSource;
        private DenemeİsDataSetArsiv DenemeİsDataSetArsiv;
        private DenemeİsDataSetArsivTableAdapters.Tbl_SoforlerTableAdapter Tbl_SoforlerTableAdapter;
    }
}