namespace POS
{
    partial class PaymentReceivedForm
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
            this.PaymentReceivedDataSet = new POS.PaymentReceivedDataSet();
            this.PaymentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaymentViewTableAdapter = new POS.PaymentReceivedDataSetTableAdapters.PaymentViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentReceivedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PaymentReceivedDataSet";
            reportDataSource1.Value = this.PaymentViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS.PaymentReceivedReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(628, 509);
            this.reportViewer1.TabIndex = 0;
            // 
            // PaymentReceivedDataSet
            // 
            this.PaymentReceivedDataSet.DataSetName = "PaymentReceivedDataSet";
            this.PaymentReceivedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PaymentViewBindingSource
            // 
            this.PaymentViewBindingSource.DataMember = "PaymentView";
            this.PaymentViewBindingSource.DataSource = this.PaymentReceivedDataSet;
            // 
            // PaymentViewTableAdapter
            // 
            this.PaymentViewTableAdapter.ClearBeforeFill = true;
            // 
            // PaymentReceivedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 509);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PaymentReceivedForm";
            this.Text = "PaymentReceivedForm";
            this.Load += new System.EventHandler(this.PaymentReceivedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentReceivedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PaymentViewBindingSource;
        private PaymentReceivedDataSet PaymentReceivedDataSet;
        private PaymentReceivedDataSetTableAdapters.PaymentViewTableAdapter PaymentViewTableAdapter;
    }
}