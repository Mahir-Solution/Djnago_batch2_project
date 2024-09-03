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
    public partial class frmcustomerbill : Form
    {
        public frmcustomerbill()
        {
            InitializeComponent();
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            

        }

        private void frmcustomerbill_Load(object sender, EventArgs e)
        {
            Customer.Customerlist(cbsupplier1);
        }

        private void btnfetch_Click_1(object sender, EventArgs e)
        {
            DateTime sd = dateTimePicker1.Value.Date;
            DateTime ed = dateTimePicker2.Value.Date;
            int cid = Convert.ToInt32(cbsupplier1.SelectedValue);
            Varibale.sdate = sd;
            Varibale.edate = ed;
            Varibale.cid = cid;
            Anysaleform obj = new Anysaleform();
            obj.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime sd = dateTimePicker1.Value.Date;
            DateTime ed = dateTimePicker2.Value.Date;
            int cid = Convert.ToInt32(cbsupplier1.SelectedValue);
            Varibale.sdate = sd;
            Varibale.edate = ed;
            Varibale.cid = cid;
            AnySaleThermalForm obj = new AnySaleThermalForm();
            obj.Show();
        } 
    }
}
