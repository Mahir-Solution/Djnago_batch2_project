namespace POS
{
    partial class CustomerBottleForm
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
            this.CustomerBottleDataSet = new POS.CustomerBottleDataSet();
            this.SalesmanViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesmanViewTableAdapter = new POS.CustomerBottleDataSetTableAdapters.SalesmanViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBottleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesmanViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CustomerBottleDataSet";
            reportDataSource1.Value = this.SalesmanViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS.CustomerBottleReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(842, 477);
            this.reportViewer1.TabIndex = 0;
            // 
            // CustomerBottleDataSet
            // 
            this.CustomerBottleDataSet.DataSetName = "CustomerBottleDataSet";
            this.CustomerBottleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalesmanViewBindingSource
            // 
            this.SalesmanViewBindingSource.DataMember = "SalesmanView";
            this.SalesmanViewBindingSource.DataSource = this.CustomerBottleDataSet;
            // 
            // SalesmanViewTableAdapter
            // 
            this.SalesmanViewTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerBottleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 477);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CustomerBottleForm";
            this.Text = "CustomerBottleForm";
            this.Load += new System.EventHandler(this.CustomerBottleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBottleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesmanViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalesmanViewBindingSource;
        private CustomerBottleDataSet CustomerBottleDataSet;
        private CustomerBottleDataSetTableAdapters.SalesmanViewTableAdapter SalesmanViewTableAdapter;
    }
}