namespace POS
{
    partial class DailyMonthlyAnySaleform
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
            this.DailyMonthlyAnySaleDataSet = new POS.DailyMonthlyAnySaleDataSet();
            this.SaleViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaleViewTableAdapter = new POS.DailyMonthlyAnySaleDataSetTableAdapters.SaleViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DailyMonthlyAnySaleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DailyMonthlyAnySaleDataSet";
            reportDataSource1.Value = this.SaleViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS.DailyMonthlyAnySaleReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(676, 509);
            this.reportViewer1.TabIndex = 0;
            // 
            // DailyMonthlyAnySaleDataSet
            // 
            this.DailyMonthlyAnySaleDataSet.DataSetName = "DailyMonthlyAnySaleDataSet";
            this.DailyMonthlyAnySaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaleViewBindingSource
            // 
            this.SaleViewBindingSource.DataMember = "SaleView";
            this.SaleViewBindingSource.DataSource = this.DailyMonthlyAnySaleDataSet;
            // 
            // SaleViewTableAdapter
            // 
            this.SaleViewTableAdapter.ClearBeforeFill = true;
            // 
            // DailyMonthlyAnySaleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 509);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DailyMonthlyAnySaleform";
            this.Text = "DailyMonthlyAnySaleform";
            this.Load += new System.EventHandler(this.DailyMonthlyAnySaleform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DailyMonthlyAnySaleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SaleViewBindingSource;
        private DailyMonthlyAnySaleDataSet DailyMonthlyAnySaleDataSet;
        private DailyMonthlyAnySaleDataSetTableAdapters.SaleViewTableAdapter SaleViewTableAdapter;
    }
}