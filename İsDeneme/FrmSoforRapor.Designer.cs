namespace İsDeneme
{
    partial class FrmSoforRapor
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
            this.Tbl_SoforlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DenemeİsDataSetSofor = new İsDeneme.DenemeİsDataSetSofor();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Tbl_SoforlerTableAdapter = new İsDeneme.DenemeİsDataSetSoforTableAdapters.Tbl_SoforlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_SoforlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DenemeİsDataSetSofor)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbl_SoforlerBindingSource
            // 
            this.Tbl_SoforlerBindingSource.DataMember = "Tbl_Soforler";
            this.Tbl_SoforlerBindingSource.DataSource = this.DenemeİsDataSetSofor;
            // 
            // DenemeİsDataSetSofor
            // 
            this.DenemeİsDataSetSofor.DataSetName = "DenemeİsDataSetSofor";
            this.DenemeİsDataSetSofor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            reportDataSource1.Name = "DataSetSofor";
            reportDataSource1.Value = this.Tbl_SoforlerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "İsDeneme.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1099, 651);
            this.reportViewer1.TabIndex = 0;
            // 
            // Tbl_SoforlerTableAdapter
            // 
            this.Tbl_SoforlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmSoforRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1099, 651);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmSoforRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şoför Rapor";
            this.Load += new System.EventHandler(this.FrmSoforRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_SoforlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DenemeİsDataSetSofor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tbl_SoforlerBindingSource;
        private DenemeİsDataSetSofor DenemeİsDataSetSofor;
        private DenemeİsDataSetSoforTableAdapters.Tbl_SoforlerTableAdapter Tbl_SoforlerTableAdapter;
    }
}