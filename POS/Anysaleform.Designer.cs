namespace POS
{
    partial class Anysaleform
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SaleViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerbillDataSet = new POS.CustomerbillDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SaleViewTableAdapter = new POS.CustomerbillDataSetTableAdapters.SaleViewTableAdapter();
            this.BalanceDataSet = new POS.BalanceDataSet();
            this.tblorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblorderTableAdapter = new POS.BalanceDataSetTableAdapters.tblorderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SaleViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerbillDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SaleViewBindingSource
            // 
            this.SaleViewBindingSource.DataMember = "SaleView";
            this.SaleViewBindingSource.DataSource = this.CustomerbillDataSet;
            // 
            // CustomerbillDataSet
            // 
            this.CustomerbillDataSet.DataSetName = "CustomerbillDataSet";
            this.CustomerbillDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CustomerbillDataSet";
            reportDataSource1.Value = this.SaleViewBindingSource;
            reportDataSource2.Name = "BalanceDataSet";
            reportDataSource2.Value = this.tblorderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS.AnySaleReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(670, 557);
            this.reportViewer1.TabIndex = 0;
            // 
            // SaleViewTableAdapter
            // 
            this.SaleViewTableAdapter.ClearBeforeFill = true;
            // 
            // BalanceDataSet
            // 
            this.BalanceDataSet.DataSetName = "BalanceDataSet";
            this.BalanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblorderBindingSource
            // 
            this.tblorderBindingSource.DataMember = "tblorder";
            this.tblorderBindingSource.DataSource = this.BalanceDataSet;
            // 
            // tblorderTableAdapter
            // 
            this.tblorderTableAdapter.ClearBeforeFill = true;
            // 
            // Anysaleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 557);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Anysaleform";
            this.Text = "Anysaleform";
            this.Load += new System.EventHandler(this.Anysaleform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaleViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerbillDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblorderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SaleViewBindingSource;
        private CustomerbillDataSet CustomerbillDataSet;
        private CustomerbillDataSetTableAdapters.SaleViewTableAdapter SaleViewTableAdapter;
        private System.Windows.Forms.BindingSource tblorderBindingSource;
        private BalanceDataSet BalanceDataSet;
        private BalanceDataSetTableAdapters.tblorderTableAdapter tblorderTableAdapter;
    }
}