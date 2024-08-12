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
    public partial class frmpaymentReceived : Form
    {
        public frmpaymentReceived()
        {
            InitializeComponent();
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            DateTime d = dtpicker1.Value.Date;
           
            //MessageBox.Show(sd.ToString() + ed.ToString());

            Varibale.date = d;
           
            //MessageBox.Show(Varibale.sdate.ToString() + Varibale.edate.ToString());
            PaymentReceivedForm frm = new PaymentReceivedForm();
            frm.Show();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmpaymentReceived_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
