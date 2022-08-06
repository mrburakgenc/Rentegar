namespace İsDeneme
{
    partial class AnaSayfaRapor
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
            this.DenemeİsDtRapor = new İsDeneme.DenemeİsDtRapor();
            this.Tbl_RentegarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tbl_RentegarTableAdapter = new İsDeneme.DenemeİsDtRaporTableAdapters.Tbl_RentegarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DenemeİsDtRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_RentegarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetAnaRapor";
            reportDataSource1.Value = this.Tbl_RentegarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "İsDeneme.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1015, 720);
            this.reportViewer1.TabIndex = 0;
            // 
            // DenemeİsDtRapor
            // 
            this.DenemeİsDtRapor.DataSetName = "DenemeİsDtRapor";
            this.DenemeİsDtRapor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tbl_RentegarBindingSource
            // 
            this.Tbl_RentegarBindingSource.DataMember = "Tbl_Rentegar";
            this.Tbl_RentegarBindingSource.DataSource = this.DenemeİsDtRapor;
            // 
            // Tbl_RentegarTableAdapter
            // 
            this.Tbl_RentegarTableAdapter.ClearBeforeFill = true;
            // 
            // AnaSayfaRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 720);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnaSayfaRapor";
            this.Text = "AnaSayfaRapor";
            this.Load += new System.EventHandler(this.AnaSayfaRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DenemeİsDtRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_RentegarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tbl_RentegarBindingSource;
        private DenemeİsDtRapor DenemeİsDtRapor;
        private DenemeİsDtRaporTableAdapters.Tbl_RentegarTableAdapter Tbl_RentegarTableAdapter;
    }
}