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
                string p = txtcontact.Text;
                string ad = txtaddress.Text;
                Customer obj = new Customer(n, p, ad);
                string msg = obj.AddNew();
                MessageBox.Show(msg);
                txtaddress.Clear();
                txtcontact.Clear();
                txtname.Clear();
                Customer.Customerlist(cbsupplier1);

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
                obj.cname = txtupdatesupplier.Text;
                obj.address = txtlocation.Text;


                string msg = obj.Update();
                MessageBox.Show(msg);



                txtupdatesupplier.Clear();
                txtaddress.Clear();
                txtcontact.Clear();
                txtname.Clear();
                txtcon.Clear();
                txtlocation.Clear();
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
    }
}
