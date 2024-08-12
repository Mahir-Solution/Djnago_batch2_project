namespace POS
{
    partial class Salesmanform
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
            this.SalesmanDataSet = new POS.SalesmanDataSet();
            this.SalesmanViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesmanViewTableAdapter = new POS.SalesmanDataSetTableAdapters.SalesmanViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SalesmanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesmanViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SalesmanDataSet";
            reportDataSource1.Value = this.SalesmanViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS.SalesmanReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(658, 525);
            this.reportViewer1.TabIndex = 0;
            // 
            // SalesmanDataSet
            // 
            this.SalesmanDataSet.DataSetName = "SalesmanDataSet";
            this.SalesmanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalesmanViewBindingSource
            // 
            this.SalesmanViewBindingSource.DataMember = "SalesmanView";
            this.SalesmanViewBindingSource.DataSource = this.SalesmanDataSet;
            // 
            // SalesmanViewTableAdapter
            // 
            this.SalesmanViewTableAdapter.ClearBeforeFill = true;
            // 
            // Salesmanform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 525);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Salesmanform";
            this.Text = "Salesmanform";
            this.Load += new System.EventHandler(this.Salesmanform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesmanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesmanViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalesmanViewBindingSource;
        private SalesmanDataSet SalesmanDataSet;
        private SalesmanDataSetTableAdapters.SalesmanViewTableAdapter SalesmanViewTableAdapter;
    }
}