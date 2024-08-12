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
    public partial class frmsalesmanreport : Form
    {
        public frmsalesmanreport()
        {
            InitializeComponent();
        }

        private void frmsalesmanreport_Load(object sender, EventArgs e)
        {
            salesman.Salesmanlist(cbsupplier1);
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(cbsupplier1.SelectedValue);
            Varibale.sid = sid;
            Salesmanform frm = new Salesmanform();
            frm.Show();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cbsupplier1.SelectedIndex = -1;
        }
    }
}
