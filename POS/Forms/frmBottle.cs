using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Forms;
using POS.Model;
namespace POS.Forms
{
    public partial class frmBottle : Form
    {
        public frmBottle()
        {
            InitializeComponent();
        }

        private void frmBottle_Load(object sender, EventArgs e)
        {
            Customer.Customerlist(cbcustomer);
            salesman.Salesmanlist(cbsalesman);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value.Date;
            int cid = Convert.ToInt32(cbcustomer.SelectedValue);
            int sid = Convert.ToInt32(cbsalesman.SelectedValue);
            int r = Convert.ToInt32(txtreturn.Text);
            bool ischecked = checkBox1.Checked;
            
            Bottle obj = new Bottle(r, ischecked, new Customer(cid), new salesman(sid),date);
            string msg = obj.AddNew();
            MessageBox.Show(msg);
            cbcustomer.SelectedIndex = -1;
            cbsalesman.SelectedIndex = -1;
            txtreturn.Clear();
            checkBox1.Checked = false;
            dateTimePicker1.Value = DateTime.Now;


        }

        private void txtreturn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) | ch == 8 | ch == 32)
            {
                e.Handled = false;

            }

            else
            {
                e.Handled = true;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cbcustomer.SelectedIndex = -1;
            cbsalesman.SelectedIndex = -1;
            txtreturn.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                this.cbcustomer.ValueMember = "CID";
                this.cbcustomer.DisplayMember = "cname";
                this.cbcustomer.DataSource = dataTable;
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
    }
}
