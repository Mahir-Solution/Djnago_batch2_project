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
    public partial class frmsupplier : Form
    {
        public frmsupplier()
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
                string comp = txtcompany.Text;
                Supplier obj = new Supplier(n, p, ad, comp);
                string msg = obj.AddNew();
                MessageBox.Show(msg);
                txtaddress.Clear();
                txtcontact.Clear();
                txtname.Clear();
                txtcompany.Clear();
                Supplier.Supplierlist(cbsupplier1);
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbsupplier1.SelectedValue);

            Supplier obj = new Supplier(id);

            txtcon.Text = obj.cell;
            txtupdatesupplier.Text = obj.sname;
            txtlocation.Text = obj.address;
            txtupdatecompanay.Text = obj.company;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cbsupplier1.SelectedValue);

                Supplier obj = new Supplier(id);
                obj.SupID = id;
                obj.cell = txtcon.Text;
                obj.sname = txtupdatesupplier.Text;
                obj.address = txtlocation.Text;
                obj.company = txtupdatecompanay.Text;


                string msg = obj.Update();
                MessageBox.Show(msg);



                txtupdatesupplier.Clear();
                txtaddress.Clear();
                txtcontact.Clear();
                txtname.Clear();
                txtcon.Clear();
                txtlocation.Clear();
                txtupdatecompanay.Clear();
                cbsupplier1.SelectedIndex = -1;
                Supplier.Supplierlist(cbsupplier1);
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
    }
}
