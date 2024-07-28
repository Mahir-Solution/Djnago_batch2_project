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
using POS.Forms;
using System.Data.SqlClient;

namespace POS.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //for check data base conncetion
            //DatabaseHandler db = new DatabaseHandler();
            //MessageBox.Show(db.GetDatabaseStatus());
            //  for user login authentication

            string username = txtname.Text;
            string password = txtpassword.Text;
            string type = cbtype.Text;

            User user = new User(username, password, type);
            string check = user.Login();
            int uid = user.getuserId();
            
            if (check == "Admin")
            {
                frmMenu frm = new frmMenu(uid);
                frm.ShowDialog();
            }
            else if (check == "User")
            {
                frmMenu frm = new frmMenu(uid);
                
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Error --- Wrong user name annd password");
            }
            txtname.Clear();
            txtpassword.Clear();
            cbtype.SelectedIndex = -1;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }
    }
}
