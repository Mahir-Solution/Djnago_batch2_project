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
namespace POS
{
    public partial class PaymentReceivedForm : Form
    {
        public PaymentReceivedForm()
        {
            InitializeComponent();
        }

        private void PaymentReceivedForm_Load(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(Varibale.sdate.ToString() + Varibale.edate.ToString());
                // TODO: This line of code loads data into the 'PaymentReceivedDataSet.PaymentView' table. You can move, or remove it, as needed.
                this.PaymentViewTableAdapter.Fill(this.PaymentReceivedDataSet.PaymentView,Varibale.date);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
    }
}
