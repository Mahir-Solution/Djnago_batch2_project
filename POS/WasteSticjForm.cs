using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class WasteSticjForm : Form
    {
        public WasteSticjForm()
        {
            InitializeComponent();
        }

        private void WasteSticjForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'WasteStockDataSet.WasteStockView' table. You can move, or remove it, as needed.
            this.WasteStockViewTableAdapter.Fill(this.WasteStockDataSet.WasteStockView);

            this.reportViewer1.RefreshReport();
        }
    }
}
