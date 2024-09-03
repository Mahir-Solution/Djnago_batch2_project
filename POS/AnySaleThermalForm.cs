using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Model;
namespace POS
{
    public partial class AnySaleThermalForm : Form
    {
        public AnySaleThermalForm()
        {
            InitializeComponent();
        }

        private void AnySaleThermalForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CustomerbillDataSet.SaleView' table. You can move, or remove it, as needed.
            this.SaleViewTableAdapter.Fill(this.CustomerbillDataSet.SaleView,Varibale.cid,Varibale.sdate,Varibale.edate);
            // TODO: This line of code loads data into the 'BalanceDataSet.tblorder' table. You can move, or remove it, as needed.
            this.tblorderTableAdapter.Fill(this.BalanceDataSet.tblorder,Varibale.cid);

            this.reportViewer1.RefreshReport();
        }
    }
}
