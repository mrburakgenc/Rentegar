namespace İsDeneme
{
    partial class FrmAracRapor
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
            this.DenemeİsDataSetArac = new İsDeneme.DenemeİsDataSetArac();
            this.Tbl_AraclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tbl_AraclarTableAdapter = new İsDeneme.DenemeİsDataSetAracTableAdapters.Tbl_AraclarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DenemeİsDataSetArac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_AraclarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetArac";
            reportDataSource1.Value = this.Tbl_AraclarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "İsDeneme.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(783, 636);
            this.reportViewer1.TabIndex = 0;
            // 
            // DenemeİsDataSetArac
            // 
            this.DenemeİsDataSetArac.DataSetName = "DenemeİsDataSetArac";
            this.DenemeİsDataSetArac.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tbl_AraclarBindingSource
            // 
            this.Tbl_AraclarBindingSource.DataMember = "Tbl_Araclar";
            this.Tbl_AraclarBindingSource.DataSource = this.DenemeİsDataSetArac;
            // 
            // Tbl_AraclarTableAdapter
            // 
            this.Tbl_AraclarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAracRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(783, 636);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmAracRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Rapor";
            this.Load += new System.EventHandler(this.FrmAracRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DenemeİsDataSetArac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_AraclarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tbl_AraclarBindingSource;
        private DenemeİsDataSetArac DenemeİsDataSetArac;
        private DenemeİsDataSetAracTableAdapters.Tbl_AraclarTableAdapter Tbl_AraclarTableAdapter;
    }
}