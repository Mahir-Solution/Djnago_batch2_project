namespace POS
{
    partial class saleform
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
            this.SaleDataSet = new POS.SaleDataSet();
            this.SaleViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaleViewTableAdapter = new POS.SaleDataSetTableAdapters.SaleViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SaleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SaleDataSet";
            reportDataSource1.Value = this.SaleViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS.SaleReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(341, 387);
            this.reportViewer1.TabIndex = 0;
            // 
            // SaleDataSet
            // 
            this.SaleDataSet.DataSetName = "SaleDataSet";
            this.SaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaleViewBindingSource
            // 
            this.SaleViewBindingSource.DataMember = "SaleView";
            this.SaleViewBindingSource.DataSource = this.SaleDataSet;
            // 
            // SaleViewTableAdapter
            // 
            this.SaleViewTableAdapter.ClearBeforeFill = true;
            // 
            // saleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 387);
            this.Controls.Add(this.reportViewer1);
            this.Name = "saleform";
            this.Text = "saleform";
            this.Load += new System.EventHandler(this.saleform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SaleViewBindingSource;
        private SaleDataSet SaleDataSet;
        private SaleDataSetTableAdapters.SaleViewTableAdapter SaleViewTableAdapter;
    }
}