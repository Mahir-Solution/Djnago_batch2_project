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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            Customer.Customerlist(cbcustomer);
            Customer.Customerlist(cbupdatecustomer);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value.Date;
            int uid = 1;
            int cid = Convert.ToInt32(cbcustomer.SelectedValue);
            int amount = Convert.ToInt32(txtamount.Text);
            Payment obj = new Payment(new User(uid), new Customer(cid), amount, dt);
            string msg = obj.AddNew();
            MessageBox.Show(msg);
            dateTimePicker1.Value = DateTime.Now;
            cbcustomer.SelectedIndex = -1;
            txtamount.Clear();
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dateTimePicker2.Value.Date;
                int cid = Convert.ToInt32(cbupdatecustomer.SelectedValue);
                Payment obj = new Payment(date, new Customer(cid));
                obj.FetchPayment();
                txtupdatepayment.Text = obj.amount.ToString();
                txtpid.Text = obj.PYID.ToString();    
            }
            catch(Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(txtpid.Text);
            Payment obj = new Payment(pid);
            obj.amount = Convert.ToInt32(txtupdatepayment.Text);
            string msg = obj.Update();
            MessageBox.Show(msg);
            txtupdatepayment.Clear();


        }
    }
}
