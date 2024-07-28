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
            if (cbcustomer.SelectedItem.ToString() == "Select a customer")
            {
                MessageBox.Show("Customer must be selected");
            }
            else if (cbsalesman.SelectedItem.ToString() == "Select a salesman")
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
            int cid = Convert.ToInt32(cbcustomer.SelectedValue);
            int sid = Convert.ToInt32(cbsalesman.SelectedValue);
            string onum = txtrandnumber.Text;
            DateTime dt = dateTimePicker1.Value.Date;
            int uid = 1;

            //insert data into order table
            Order obj = new Order(new salesman(sid),new Customer(cid),new User(uid),onum,dt);
            string msg = obj.AddNew();
            //MessageBox.Show(msg);
            // fetch order id on the base of order number
            Order obj1 = new Order(onum);
            txtoid.Text = obj1.OID.ToString();

            //insert data in order detail table
            int oid = Convert.ToInt32(txtoid.Text);
            int pid = Convert.ToInt32(cbproduct.SelectedValue);
            int pr = Convert.ToInt32(txtprice.Text);
            int qty = Convert.ToInt32(txtdeliver.Text);
            int total = Convert.ToInt32(txttotal.Text);
            

            OrderDetail obj2 = new OrderDetail(new Order(oid),new Product(pid),pr,qty,total,dt);
            string msg1 = obj2.AddNew();
            //MessageBox.Show(msg1);

            // insert bottle into bottle table
            int rb = Convert.ToInt32(txtreturn.Text);
            bool tf = false;
            int dl = Convert.ToInt32(txtdeliver.Text);
            Bottle obj3 = new Bottle(rb,tf,dl,new Customer(cid),new salesman(sid),dt);
            string msg3 = obj3.AddNew();
            //MessageBox.Show(msg3);


            //insert payment
            int amount = Convert.ToInt32(txtreceived.Text);
            Payment obj4 = new Payment(new User(uid),new Customer(cid),amount,dt);
            string msg4 = obj4.AddNew();
            //MessageBox.Show(msg4);

            MessageBox.Show("Finish Order Complete Successfully");
            
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
    }
}
