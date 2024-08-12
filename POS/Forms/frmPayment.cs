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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            Customer.Customerlist(cbcustomer);
            Customer.Customerlist(cbupdatecustomer);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value.Date;
            int uid = frmMenu.USERID_ST ;
            int cid = Convert.ToInt32(cbcustomer.SelectedValue);
            int amount = Convert.ToInt32(txtamount.Text);
            string source = cbsource.Text;
            Payment obj = new Payment(new User(uid), new Customer(cid), amount, dt,source);
            string msg = obj.AddNew();
            MessageBox.Show(msg);
            dateTimePicker1.Value = DateTime.Now;
            cbcustomer.SelectedIndex = -1;
            txtamount.Clear();
            cbsource.SelectedIndex = -1;
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dateTimePicker2.Value.Date;
                int cid = Convert.ToInt32(cbupdatecustomer.SelectedValue);
                Payment obj = new Payment(date, new Customer(cid));
                obj.FetchPayment();
                txtupdatepayment.Text = obj.amount.ToString();
                txtpid.Text = obj.PYID.ToString();    
            }
            catch(Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(txtpid.Text);
                Payment obj = new Payment(pid);
                obj.amount = Convert.ToInt32(txtupdatepayment.Text);
                string msg = obj.Update();
                MessageBox.Show(msg);
                txtupdatepayment.Clear();
            }
            catch(Exception obj)
            {
                MessageBox.Show(obj.Message);
            }


        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtupdatepayment_KeyPress(object sender, KeyPressEventArgs e)
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
            dateTimePicker1.Value = DateTime.Now;
            cbcustomer.SelectedIndex = -1;
            txtamount.Clear();
            cbsource.SelectedIndex = -1;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtupdatepayment_TextChanged(object sender, EventArgs e)
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
                this.cbcustomer.ValueMember = "CID";
                this.cbcustomer.DisplayMember = "cname";
                this.cbcustomer.DataSource = dataTable;
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CustomerSearch1();
        }
        public void CustomerSearch1()
        {
            try
            {
                DataTable dataTable = Customer.CustomerSearch(this.textBox1.Text.Trim());
                DataRow dataRow = dataTable.NewRow();

                dataTable.Rows.InsertAt(dataRow, 0);
                this.cbupdatecustomer.ValueMember = "CID";
                this.cbupdatecustomer.DisplayMember = "cname";
                this.cbupdatecustomer.DataSource = dataTable;
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
    }
}
