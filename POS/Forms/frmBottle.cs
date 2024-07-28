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
    public partial class frmBottle : Form
    {
        public frmBottle()
        {
            InitializeComponent();
        }

        private void frmBottle_Load(object sender, EventArgs e)
        {
            Customer.Customerlist(cbcustomer);
            salesman.Salesmanlist(cbsalesman);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value.Date;
            int cid = Convert.ToInt32(cbcustomer.SelectedValue);
            int sid = Convert.ToInt32(cbsalesman.SelectedValue);
            int r = Convert.ToInt32(txtreturn.Text);
            bool ischecked = checkBox1.Checked;
            
            Bottle obj = new Bottle(r, ischecked, new Customer(cid), new salesman(sid),date);
            string msg = obj.AddNew();
            MessageBox.Show(msg);
            cbcustomer.SelectedIndex = -1;
            cbsalesman.SelectedIndex = -1;
            txtreturn.Clear();
            checkBox1.Checked = false;
            dateTimePicker1.Value = DateTime.Now;


        }
    }
}
