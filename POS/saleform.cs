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
    public partial class saleform : Form
    {
        public saleform()
        {
            InitializeComponent();
        }

        private void saleform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SaleDataSet.SaleView' table. You can move, or remove it, as needed.
            this.SaleViewTableAdapter.Fill(this.SaleDataSet.SaleView,Varibale.ordernumber);

            this.reportViewer1.RefreshReport();
        }
    }
}
