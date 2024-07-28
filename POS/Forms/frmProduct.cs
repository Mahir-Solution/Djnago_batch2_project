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
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
    }
}
