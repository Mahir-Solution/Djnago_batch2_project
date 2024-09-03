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
namespace POS.Forms
{
    public partial class frmReporting : Form
    {
        public frmReporting()
        {
            InitializeComponent();
        }

        private void frmReporting_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmcustomerbill obj = new frmcustomerbill();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmsalesmanreport rpt = new frmsalesmanreport();
            rpt.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
           frmcustomerbill obj = new frmcustomerbill();
            obj.TopLevel = false;
            reportpanel.Controls.Clear();
            reportpanel.Controls.Add(obj);
            reportpanel.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmsalesmanreport obj = new frmsalesmanreport();
            obj.TopLevel = false;
            reportpanel.Controls.Clear();
            reportpanel.Controls.Add(obj);
            reportpanel.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmanysale obj = new frmanysale();
            obj.TopLevel = false;
            reportpanel.Controls.Clear();
            reportpanel.Controls.Add(obj);
            reportpanel.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmpaymentReceived obj = new frmpaymentReceived();
            obj.TopLevel = false;
            reportpanel.Controls.Clear();
            reportpanel.Controls.Add(obj);
            reportpanel.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmCustomerTrialbalance obj = new frmCustomerTrialbalance();
            obj.TopLevel = false;
            reportpanel.Controls.Clear();
            reportpanel.Controls.Add(obj);
            reportpanel.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmcustomerbottle obj = new frmcustomerbottle();
            obj.TopLevel = false;
            reportpanel.Controls.Clear();
            reportpanel.Controls.Add(obj);
            reportpanel.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StockForm obj = new StockForm();
            obj.TopLevel = false;
            reportpanel.Controls.Clear();
            reportpanel.Controls.Add(obj);
            reportpanel.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmCustomerLedger obj = new frmCustomerLedger();
            obj.TopLevel = false;
            reportpanel.Controls.Clear();
            reportpanel.Controls.Add(obj);
            reportpanel.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WasteSticjForm obj = new WasteSticjForm();
            obj.TopLevel = false;
            reportpanel.Controls.Clear();
            reportpanel.Controls.Add(obj);
            reportpanel.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }
    }
}
