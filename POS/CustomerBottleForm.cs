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
    public partial class CustomerBottleForm : Form
    {
        public CustomerBottleForm()
        {
            InitializeComponent();
        }

        private void CustomerBottleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CustomerBottleDataSet.SalesmanView' table. You can move, or remove it, as needed.
            this.SalesmanViewTableAdapter.Fill(this.CustomerBottleDataSet.SalesmanView,Varibale.cid,Varibale.sdate,Varibale.edate);
            // TODO: This line of code loads data into the 'SalesmanDataSet.SalesmanView' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }
    }
}
