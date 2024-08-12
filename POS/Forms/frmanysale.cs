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
    public partial class frmanysale : Form
    {
        public frmanysale()
        {
            InitializeComponent();
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            DateTime sd = dtpickerstart.Value.Date;
            DateTime ed = dtpickerend.Value.Date;
            //MessageBox.Show(sd.ToString() + ed.ToString());
            Varibale.sdate = sd;
            Varibale.edate = ed;
           // MessageBox.Show(Varibale.sdate.ToString() + Varibale.edate.ToString());
            DailyMonthlyAnySaleform frm = new DailyMonthlyAnySaleform();
            frm.Show();

        }
    }
}
