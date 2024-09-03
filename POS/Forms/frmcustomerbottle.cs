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
    public partial class frmcustomerbottle : Form
    {
        public frmcustomerbottle()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerpanel_Paint(object sender, PaintEventArgs e)
        {
            Customer.Customerlist(cbcutomer);
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
           
        }

        private void txtsupsearch_TextChanged(object sender, EventArgs e)
        {
            CustomerSearch();
        }
       

        private void frmcustomerbottle_Load(object sender, EventArgs e)
        {
            Customer.Customerlist(cbcutomer);
        }

        private void txtsupsearch_TextChanged_1(object sender, EventArgs e)
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

        private void btnfetch_Click_1(object sender, EventArgs e)
        {
            DateTime sd = dateTimePicker1.Value.Date;
            DateTime ed = dateTimePicker2.Value.Date;
            int cid = Convert.ToInt32(cbcutomer.SelectedValue);
            Varibale.sdate = sd;
            Varibale.edate = ed;
            Varibale.cid = cid;
            CustomerBottleForm obj = new CustomerBottleForm();
            obj.Show();
        }
    }
}
