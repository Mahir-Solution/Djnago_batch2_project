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
using System.Data.SqlClient;

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
            int cid = Convert.ToInt32(cbcustomer.SelectedValue);
            if (cid<0)
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
                int randnumber = obj.Next(1, 50000);
                txtrandnumber.Text = randnumber.ToString();
                cbcustomer.Enabled = false;
                cbsalesman.Enabled = false;
                panel2.Visible = true;

                string onum = txtrandnumber.Text;
                DateTime dt = dateTimePicker1.Value.Date;
                int uid = frmMenu.USERID_ST;

                //insert data into order table
                Order obj1 = new Order(new salesman(salemanId), new Customer(cid), new User(uid), onum, dt);
                string msg = obj1.AddNew();
                //MessageBox.Show(msg);

                // fetch order id on the base of order number
                Order obj2 = new Order(onum);
                txtoid.Text = obj2.OID.ToString();

                // fetch balance of individual customer
                //1)  get customer sale amount in order detail table
               
                OrderDetail obj3 = new OrderDetail();
                int total_sale = obj3.Customer_Total_Sale(cid);
                //MessageBox.Show(total_sale.ToString());


                //2) get customer payment in payment table
                Payment obj4 = new Payment();
                int total_payment = obj4.Customer_Total_Payment(cid);
                //MessageBox.Show(total_payment.ToString());
                int balance = total_sale - total_payment;
                txtpreiousbalance.Text = balance.ToString();
                //MessageBox.Show(balance.ToString());
                int x = 0;
                txtamountreceived.Text = x.ToString();
                txtreturn.Text = x.ToString();
                txtordertotal.Text = x.ToString();
                txtgrandtotal.Text = x.ToString();
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
                DateTime dt = dateTimePicker1.Value.Date;
                int uid = frmMenu.USERID_ST;
                string onum = txtrandnumber.Text;
                //MessageBox.Show(msg3);


                //insert payment
                string source = cbsource.Text;
                int amount = Convert.ToInt32(txtamountreceived.Text);
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
                txtamountreceived.Clear();
                txtreturn.Clear();
                panel2.Visible = false;
                txtoid.Clear();
                cbsource.Items.Clear();
                dataGridView1.DataSource = null;
                dateTimePicker1.Value = DateTime.Now;





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
            txtamountreceived.Clear();
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

        private void txtreturn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtreceived_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbsalesman_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtordertotal_TextChanged(object sender, EventArgs e)
        {

            decimal balance = Convert.ToDecimal(txtpreiousbalance.Text);
            decimal ordertotal = Convert.ToDecimal(txtordertotal.Text);
            decimal gtotal = balance + ordertotal;
            txtgrandtotal.Text = gtotal.ToString();
        }

        private void cbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int pid = -1;
            //try
            //{
            //    pid = Convert.ToInt32(cbproduct.SelectedValue);
            //}
            //catch (Exception)
            //{
            //    pid = -1;
            //}


            try
            {
                int pid = Convert.ToInt32(cbproduct.SelectedValue);
                if (pid > 0)
                {
                    

                    //get stock from stock table
                    Stock obj1 = new Stock();
                    int stock = obj1.total_stock(pid);
                    // MessageBox.Show(stock.ToString());

                    //get sale stock quanity from order detail table
                    OrderDetail obj2 = new OrderDetail();
                    int sale_stock = obj2.Total_Sale_Qty(pid);
                    //MessageBox.Show(sale_stock.ToString());
                    // show stock at the the of sale
                    int final_stock = stock - sale_stock;
                    txtstock.Text = final_stock.ToString();
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int pid = Convert.ToInt32(cbproduct.SelectedValue);
                if (pid < 0)
                {
                    MessageBox.Show("Proudct must be selected");
                }
                else
                {
                    //insert data in order detail table

                    int cid = Convert.ToInt32(cbcustomer.SelectedValue);
                    int sid = Convert.ToInt32(cbsalesman.SelectedValue);
                    int oid = Convert.ToInt32(txtoid.Text);
                    int qty = Convert.ToInt32(txtdeliver.Text);
                    int total = Convert.ToInt32(txttotal.Text);
                    DateTime dt = dateTimePicker1.Value.Date;
                    decimal stock = Convert.ToDecimal(txtstock.Text);
                    int price = Convert.ToInt32(txtprice.Text);
                    
                    if (stock > 0 && qty <= stock)
                    {
                        OrderDetail obj2 = new OrderDetail(new Order(oid), new Product(pid),price, qty, total, dt);
                        string msg1 = obj2.AddNew();
                        
                        //put data into data grid view
                        OrderDetail obj3 = new OrderDetail();
                        DataTable tab = obj3.fetch_order_detail(oid);
                        dataGridView1.DataSource = tab;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                      

                        //fetch totoal of the specifice order
                        OrderDetail obj4 = new OrderDetail();
                        int ordertotal = obj4.Order_Total(oid);
                        txtordertotal.Text = ordertotal.ToString();

                        // insert bottle into bottle table
                        int rb = Convert.ToInt32(txtreturn.Text);
                        if (rb > 0)
                        {
                            bool tf = false;
                            int dl = Convert.ToInt32(txtdeliver.Text);
                            Bottle rbotal = new Bottle(rb,  dl, new Customer(cid), new salesman(sid), dt);
                            string msg3 = rbotal.AddNew();
                            txtreturn.Clear();
                        }


                        txtstock.Clear();
                        txtdeliver.Clear();
                        txttotal.Clear();
                        txtprice.Clear();
                        int x = 0;
                        txtreturn.Text = x.ToString();
                     
                    }
                    else
                    {
                        MessageBox.Show("stock out of boundry");
                    }
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Show the button
                btnremove.Visible = true;
            }
            else
            {
                // Hide the button
                btnremove.Visible = false;
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow();
            //fetch totoal of the specifice order
            int oid = Convert.ToInt32(txtoid.Text);
            OrderDetail obj4 = new OrderDetail();
            int ordertotal = obj4.Order_Total(oid);
            txtordertotal.Text = ordertotal.ToString();
        }
        private void DeleteSelectedRow()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Assuming the first column is the unique identifier for the row
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                // SQL query to delete the row from the database
                string deleteQuery = "DELETE FROM tbleorderdetail WHERE odid = @ID";

                using (SqlConnection connection = new SqlConnection(DatabaseHandler.ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ID", id);
                            command.ExecuteNonQuery();
                        }

                        // Remove the row from the DataGridView
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbsource_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
