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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtitem.Clear();
            txtunit.Clear();
            txtprice.Clear();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                
                string pname = txtitem.Text;
                
                string unit = txtunit.Text;
                decimal pr =  Convert.ToDecimal(txtprice.Text);

                Product obj = new Product(pname, unit, pr);

                MessageBox.Show(obj.AddNew());

                txtitem.Clear();
                txtunit.Clear();
                txtprice.Clear();
                Product.ProductList(cbitem);
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void txtunit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) | ch == 8 | ch == 32)
            {
                e.Handled = false;

            }

            else
            {
                e.Handled = true;
            }
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

        private void frmProduct_Load(object sender, EventArgs e)
        {
            Product.ProductList(cbitem);
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(cbitem.SelectedValue);
            Product obj = new Product(pid);
            txtupdateunit.Text = obj.unit;
            txtupdateprice.Text = obj.price.ToString();
            txtpid.Text = obj.PID.ToString();
            txtretypeitem.Text = obj.pname;
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(txtpid.Text);
            Product obj = new Product(pid);
            obj.pname = txtretypeitem.Text;
            obj.unit = txtupdateunit.Text;
            obj.price = Convert.ToInt32(txtupdateprice.Text);
            string msg = obj.UpdateData();
            MessageBox.Show(msg);
            txtupdateprice.Clear();
            txtupdateunit.Clear();
            txtpid.Clear();
            txtretypeitem.Clear();
            Product.ProductList(cbitem);
        }

        private void txtretypeitem_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtupdateunit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) | ch == 8 | ch == 32)
            {
                e.Handled = false;

            }

            else
            {
                e.Handled = true;
            }
        }

        private void txtupdateprice_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
