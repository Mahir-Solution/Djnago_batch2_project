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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();         
        }
        public frmMenu(int uid)
        {
            //MessageBox.Show(uid.ToString());
            InitializeComponent();
            User obj = new User(uid);
            //string name = obj.uname;
            //MessageBox.Show(obj.uname);
            textBox1.Text = obj.UID.ToString();
            lblusername.Text = obj.uname;
            

        }
        

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmsalesman obj = new frmsalesman();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmUser obj = new frmUser();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            frmProduct obj = new frmProduct();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmCustomer obj = new frmCustomer();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmPayment obj = new frmPayment();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmBottle obj = new frmBottle();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmBackup obj = new frmBackup();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            frmSale obj = new frmSale();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frmReporting obj = new frmReporting();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }
    }
}
