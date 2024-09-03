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
    public partial class frmstock : Form
    {
        public frmstock()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(cbproduct.SelectedValue);
            int supid = Convert.ToInt32(cbsupplier.SelectedValue);
            int qt = Convert.ToInt32(txtqty.Text);
            DateTime dt = dateTimePicker1.Value.Date;
            Stock obj = new Stock(new Supplier(supid), new Product(pid), dt, qt);
            string msg = obj.AddNew();
            MessageBox.Show(msg);
            cbproduct.SelectedIndex = -1;
            cbsupplier.SelectedIndex = -1;
            txtqty.Clear();
            
        }

        private void frmstock_Load(object sender, EventArgs e)
        {
            Supplier.Supplierlist(cbsupplier);
            Supplier.Supplierlist(cbsupplerupdate);
            Product.ProductList(cbproduct);
            Product.ProductList(cbproductupdate);
            Product.ProductList(cbwasteproduct);

        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(cbproductupdate.SelectedValue);
            int supid = Convert.ToInt32(cbsupplerupdate.SelectedValue);
            DateTime dt = dateTimePicker1.Value.Date;
            Stock obj = new Stock(new Product(pid), new Supplier(supid), dt);
            txtqtyupdate.Text = obj.qty.ToString();
            txtstid.Text = obj.STID.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtstid.Text);
                Stock obj = new Stock(id);
                obj.qty = Convert.ToInt32(txtqtyupdate.Text);
                string msg = obj.Update();
                MessageBox.Show(msg);
                txtstid.Clear();
                txtqtyupdate.Clear();
                cbproductupdate.SelectedIndex = -1;
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
                int pid = Convert.ToInt32(cbwasteproduct.SelectedValue);
                
                int qt = Convert.ToInt32(txtwasteqty.Text);
                string reason = txtreason.Text;
                DateTime dt = dateTimePicker1.Value.Date;
               
                WasteStock obj = new WasteStock(new Product(pid), dt, qt, reason);
                string msg = obj.AddNew();
                MessageBox.Show(msg);
                cbwasteproduct.SelectedIndex = -1;
                txtreason.Clear();
                txtwasteqty.Clear();
            }
            catch(Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
    }
}
