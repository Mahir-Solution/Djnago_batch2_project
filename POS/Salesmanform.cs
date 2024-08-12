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
    public partial class Salesmanform : Form
    {
        public Salesmanform()
        {
            InitializeComponent();
        }

        private void Salesmanform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SalesmanDataSet.SalesmanView' table. You can move, or remove it, as needed.
            this.SalesmanViewTableAdapter.Fill(this.SalesmanDataSet.SalesmanView,Varibale.sid);

            this.reportViewer1.RefreshReport();
        }
    }
}
