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
    public partial class frmsalesman : Form
    {
        public frmsalesman()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string n = txtname.Text;
                string p = txtcontact.Text;
                string ad = txtaddress.Text;
                salesman obj = new salesman(n, p, ad);
                string msg = obj.AddNew();
                MessageBox.Show(msg);
                txtaddress.Clear();
                txtcontact.Clear();
                txtname.Clear();
                
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbsupplier1.SelectedValue);

            salesman obj = new salesman(id);

            txtcon.Text = obj.cell;
            txtupdatesupplier.Text = obj.sname;
            txtlocation.Text = obj.address;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cbsupplier1.SelectedValue);

                salesman obj = new salesman(id);
                obj.SID = id;
                obj.cell = txtcon.Text;
                obj.sname = txtupdatesupplier.Text;
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
                salesman.Salesmanlist(cbsupplier1);
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmsalesman_Load(object sender, EventArgs e)
        {
            salesman.Salesmanlist(cbsupplier1);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtaddress.Clear();
            txtcontact.Clear();
            txtname.Clear();
            txtupdatesupplier.Clear();
            txtaddress.Clear();
            txtcontact.Clear();
            txtname.Clear();
            txtcon.Clear();
            txtlocation.Clear();
            cbsupplier1.SelectedIndex = -1;
        }
    }
}
