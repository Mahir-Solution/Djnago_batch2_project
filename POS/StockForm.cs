﻿using System;
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
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StocksDataSet.tblproduct' table. You can move, or remove it, as needed.
            this.tblproductTableAdapter.Fill(this.StocksDataSet.tblproduct);

            this.reportViewer1.RefreshReport();
        }
    }
}