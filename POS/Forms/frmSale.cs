﻿using System;
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
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            Customer.Customerlist(cbcustomer);
            salesman.Salesmanlist(cbsalesman);
            Product.ProductList(cbproduct);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            

        }

        private void btorder_Click(object sender, EventArgs e)
        {
            int salemanId = Convert.ToInt32(cbsalesman.SelectedValue);
            int cId = Convert.ToInt32(cbcustomer.SelectedValue);
            if (cId<0)
            {
                MessageBox.Show("Customer must be selected");
            }
            else if (salemanId < 0)
            
            {
                MessageBox.Show("salesman must be selected");
            }

            else
            {

                Random obj = new Random();
                int randnumber = obj.Next(1, 20000);
                txtrandnumber.Text = randnumber.ToString();
                cbcustomer.Enabled = false;
                cbsalesman.Enabled = false;
                panel2.Visible = true;
                decimal x = 0;
                txtreceived.Text = x.ToString();
                txtreturn.Text = x.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdeliver_TextChanged(object sender, EventArgs e)
        {
            
                try
                {

                    int price = 0;
                    int deliver = 0;
                    if (txtprice.Text != "")
                    {
                        price = Convert.ToInt32(txtprice.Text);
                    }



                    if (txtdeliver.Text != "")
                    {
                        deliver = Convert.ToInt32(txtdeliver.Text);
                    }

                    int result = price * deliver;

                    txttotal.Text = result.ToString();
                }
                catch (Exception obj)
                {
                    MessageBox.Show(obj.Message);
                }
        }

        private void btnfinishorder_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(cbproduct.SelectedValue);
            if (pid > 0)
            {

                int cid = Convert.ToInt32(cbcustomer.SelectedValue);
                int sid = Convert.ToInt32(cbsalesman.SelectedValue);
                string onum = txtrandnumber.Text;
                DateTime dt = dateTimePicker1.Value.Date;
                int uid = frmMenu.USERID_ST;

                //insert data into order table
                Order obj = new Order(new salesman(sid), new Customer(cid), new User(uid), onum, dt);
                string msg = obj.AddNew();
                //MessageBox.Show(msg);
                // fetch order id on the base of order number
                Order obj1 = new Order(onum);
                txtoid.Text = obj1.OID.ToString();

                //insert data in order detail table
                int oid = Convert.ToInt32(txtoid.Text);
               // int pid = Convert.ToInt32(cbproduct.SelectedValue);
                int pr = Convert.ToInt32(txtprice.Text);
                int qty = Convert.ToInt32(txtdeliver.Text);
                int total = Convert.ToInt32(txttotal.Text);


                OrderDetail obj2 = new OrderDetail(new Order(oid), new Product(pid), pr, qty, total, dt);
                string msg1 = obj2.AddNew();
                //MessageBox.Show(msg1);


                // insert bottle into bottle table
                int rb = Convert.ToInt32(txtreturn.Text);
                if (rb > 0)
                {
                    bool tf = false;
                    int dl = Convert.ToInt32(txtdeliver.Text);
                    Bottle obj3 = new Bottle(rb, tf, dl, new Customer(cid), new salesman(sid), dt);
                    string msg3 = obj3.AddNew();
                }
                //MessageBox.Show(msg3);


                //insert payment
                string source = "cash";
                int amount = Convert.ToInt32(txtreceived.Text);
                if (amount > 0)
                {
                    Payment obj4 = new Payment(new User(uid), new Customer(cid), amount, dt, source);
                    string msg4 = obj4.AddNew();
                }


                MessageBox.Show("Finish Order Complete Successfully");

                Varibale.ordernumber = onum;
                saleform sl = new saleform();
                sl.Show();
                cbsalesman.Enabled = true;
                cbcustomer.Enabled = true;


                cbcustomer.SelectedIndex = -1;
                cbsalesman.SelectedIndex = -1;
                txtrandnumber.Clear();
                cbproduct.SelectedIndex = -1;
                txtprice.Clear();
                txtdeliver.Clear();
                txttotal.Clear();
                txtreceived.Clear();
                txtreturn.Clear();
                panel2.Visible = false;
            }
            else
            {
                MessageBox.Show("please select the product");
            }




        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cbcustomer.SelectedIndex = -1;
            cbsalesman.SelectedIndex = -1;
            txtrandnumber.Clear();
            cbproduct.SelectedIndex = -1;
            txtprice.Clear();
            txtdeliver.Clear();
            txttotal.Clear();
            txtreceived.Clear();
            txtreturn.Clear();
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdeliver_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtreceived_KeyPress(object sender, KeyPressEventArgs e)
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