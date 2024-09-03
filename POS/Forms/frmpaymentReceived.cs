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
namespace POS.Forms
{
    public partial class frmpaymentReceived : Form
    {
        public frmpaymentReceived()
        {
            InitializeComponent();
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            DateTime sd = dtpicker1.Value.Date;
            DateTime ed = dtpicker2.Value.Date;
            int cid = Convert.ToInt32(cbcutomer.SelectedValue);
            Varibale.sdate = sd;
            Varibale.edate = ed;
            Varibale.cid = cid;
            PaymentReceivedForm obj = new PaymentReceivedForm();
            obj.Show();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmpaymentReceived_Load(object sender, EventArgs e)
        {
            Customer.Customerlist(cbcutomer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void txtsupsearch_TextChanged(object sender, EventArgs e)
        {
            CustomerSearch();
        }
        public void CustomerSearch()
        {
            try
            {
                DataTable dataTable = Customer.CustomerSearch(this.txtsupsearch.Text.Trim());
                DataRow dataRow = dataTable.NewRow();

                dataTable.Rows.InsertAt(dataRow, 0);
                this.cbcutomer.ValueMember = "CID";
                this.cbcutomer.DisplayMember = "cname";
                this.cbcutomer.DataSource = dataTable;
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

    }
}
