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
using POS.Forms;
namespace POS.Forms
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string n = txtname.Text;
                string c1 = txtcontact.Text;
                string c2 = txtcell2.Text;
                string c3 = txtcell3.Text;
                string ad = txtaddress.Text;

                Customer customer = new Customer();
                string msg = customer.Searchdata(n, c1);
                if ( msg != null )
                {
                    MessageBox.Show(msg);
                }
               
                else
                {
                    Customer obj = new Customer(n, c1, c2, c3, ad);
                    string msgs = obj.AddNew();
                    MessageBox.Show(msgs);
                    txtaddress.Clear();
                    txtcontact.Clear();
                    txtname.Clear();
                    txtcell2.Clear();
                    txtcell3.Clear();
                    Customer.Customerlist(cbsupplier1);
                }

            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbsupplier1.SelectedValue);

            Customer obj = new Customer(id);

            txtcon.Text = obj.cell;
            txtupdatecell2.Text = obj.cell2;
            txtupudatecell3.Text = obj.cell3;
            txtupdatesupplier.Text = obj.cname;
            txtlocation.Text = obj.address;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cbsupplier1.SelectedValue);

                Customer obj = new Customer(id);
                obj.CID = id;
                obj.cell = txtcon.Text;
                obj.cell2 = txtupdatecell2.Text;
                obj.cell3 = txtupudatecell3.Text;
                obj.cname = txtupdatesupplier.Text;
                obj.address = txtlocation.Text;


                string msg = obj.Update();
                MessageBox.Show(msg);



                txtupdatesupplier.Clear();
                txtlocation.Clear();
                txtcon.Clear();
                txtupdatecell2.Clear();
                txtupudatecell3.Clear();
                
                
                cbsupplier1.SelectedIndex = -1;
                Customer.Customerlist(cbsupplier1);
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Customer.Customerlist(cbsupplier1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetterOrDigit(ch) | ch == 8 | ch == 32)
            {
                e.Handled = false;

            }

            else
            {
                e.Handled = true;
            }
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcon_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtaddress.Clear();
            txtcontact.Clear();
            txtname.Clear();

            txtupdatesupplier.Clear();
            txtaddress.Clear();
            txtcell2.Clear();
            txtcell3.Clear();

            txtcon.Clear();
            txtlocation.Clear();
            cbsupplier1.SelectedIndex = -1;

        }

        private void txtupdatesupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetterOrDigit(ch) | ch == 8 | ch == 32)
            {
                e.Handled = false;

            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                this.cbsupplier1.ValueMember = "CID";
                this.cbsupplier1.DisplayMember = "cname";
                this.cbsupplier1.DataSource = dataTable;
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
    }
}
