namespace POS
{
    partial class StockForm
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
            this.tblproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StocksDataSet = new POS.StocksDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblproductTableAdapter = new POS.StocksDataSetTableAdapters.tblproductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StocksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblproductBindingSource
            // 
            this.tblproductBindingSource.DataMember = "tblproduct";
            this.tblproductBindingSource.DataSource = this.StocksDataSet;
            // 
            // StocksDataSet
            // 
            this.StocksDataSet.DataSetName = "StocksDataSet";
            this.StocksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "StocksDataSet";
            reportDataSource1.Value = this.tblproductBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS.StocksReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(824, 486);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblproductTableAdapter
            // 
            this.tblproductTableAdapter.ClearBeforeFill = true;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 486);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockForm";
            this.Load += new System.EventHandler(this.StockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblproductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StocksDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblproductBindingSource;
        private StocksDataSet StocksDataSet;
        private StocksDataSetTableAdapters.tblproductTableAdapter tblproductTableAdapter;
    }
}