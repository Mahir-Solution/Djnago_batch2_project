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
            Customer.Customerlist(cbupdatecustomer);
            salesman.Salesmanlist(cbupdatesalesman);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value.Date;
            int cid = Convert.ToInt32(cbcustomer.SelectedValue);
            int sid = Convert.ToInt32(cbsalesman.SelectedValue);
            int r = Convert.ToInt32(txtreturn.Text);
            
            
            Bottle obj = new Bottle(r, new Customer(cid), new salesman(sid),date);
            string msg = obj.AddNew();
            MessageBox.Show(msg);
            cbcustomer.SelectedIndex = -1;
            cbsalesman.SelectedIndex = -1;
            txtreturn.Clear();
            
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

        private void cbcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcustomersearch_TextChanged(object sender, EventArgs e)
        {
            CustomerupdateSearch();
        }
        public void CustomerupdateSearch()
        {
            try
            {
                DataTable dataTable = Customer.CustomerSearch(this.txtcustomersearch.Text.Trim());
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

        private void btnfetch_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value.Date;
            int cid = Convert.ToInt32(cbupdatecustomer.SelectedValue);
            int sid = Convert.ToInt32(cbupdatesalesman.SelectedValue);
            Bottle obj = new Bottle(new Customer(cid), new salesman(sid), dt);
            txtupdatereturn.Text = obj.rbottle.ToString();
            txtbid.Text = obj.BID.ToString();
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtbid.Text);
                Bottle obj = new Bottle(id);
                obj.rbottle = Convert.ToInt32(txtupdatereturn.Text);
                string msg = obj.UpdateData();
                MessageBox.Show(msg);
                txtbid.Clear();
                txtupdatereturn.Clear();
                
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }

        }
    }
}
