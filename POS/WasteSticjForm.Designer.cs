namespace POS
{
    partial class WasteSticjForm
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
            this.WasteStockViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WasteStockDataSet = new POS.WasteStockDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.WasteStockViewTableAdapter = new POS.WasteStockDataSetTableAdapters.WasteStockViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.WasteStockViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WasteStockDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // WasteStockViewBindingSource
            // 
            this.WasteStockViewBindingSource.DataMember = "WasteStockView";
            this.WasteStockViewBindingSource.DataSource = this.WasteStockDataSet;
            // 
            // WasteStockDataSet
            // 
            this.WasteStockDataSet.DataSetName = "WasteStockDataSet";
            this.WasteStockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "WasteStockDataSet";
            reportDataSource1.Value = this.WasteStockViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS.WasteStockReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(789, 465);
            this.reportViewer1.TabIndex = 0;
            // 
            // WasteStockViewTableAdapter
            // 
            this.WasteStockViewTableAdapter.ClearBeforeFill = true;
            // 
            // WasteSticjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 465);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WasteSticjForm";
            this.Text = "WasteSticjForm";
            this.Load += new System.EventHandler(this.WasteSticjForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WasteStockViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WasteStockDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource WasteStockViewBindingSource;
        private WasteStockDataSet WasteStockDataSet;
        private WasteStockDataSetTableAdapters.WasteStockViewTableAdapter WasteStockViewTableAdapter;
    }
}