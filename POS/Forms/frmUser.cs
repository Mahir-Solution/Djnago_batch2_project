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
namespace POS.Forms
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtpassword.Clear();
            txtconfirmpassword.Clear();
            cbtype.SelectedIndex = -1;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtconfirmpassword.Text.Trim() != txtpassword.Text.Trim())
                {
                    MessageBox.Show("password not match");
                }

                else
                {

                    string uname = txtname.Text;
                    string pwd = txtpassword.Text;
                    string utype = cbtype.Text;
                    User obj = new User(uname, pwd, utype);
                    string msg = obj.AddNew();
                    MessageBox.Show(msg);
                    txtname.Clear();
                    txtpassword.Clear();
                    txtconfirmpassword.Clear();
                    cbtype.SelectedIndex = -1;
                    User.Userlist(cbupdateuser);
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            User.Userlist(cbupdateuser);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtupdatepassword.Text.Trim() != txtupdateconfirmpassword.Text.Trim())
                {
                    MessageBox.Show("password not match");
                }

                else
                {
                    int uid = Convert.ToInt32(txtuid.Text);
                    User obj = new User(uid);
                    obj.uname = txtuname.Text;
                    obj.password = txtupdatepassword.Text;
                    obj.utype = cbupdateusertype.Text;
                    string msg = obj.Update();
                    MessageBox.Show(msg);
                    txtuname.Clear();
                    txtupdatepassword.Clear();
                    txtupdateconfirmpassword.Clear();
                    cbupdateusertype.SelectedIndex = -1;
                    User.Userlist(cbupdateuser);
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void btnfetchdata_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbupdateuser.SelectedValue);



            User obj =  new  User(id);
            if (obj != null)
            {
                txtuid.Text = obj.UID.ToString();
                txtuname.Text = obj.uname;
                txtupdatepassword.Text = obj.password;
                cbupdateusertype.Text = obj.utype;
            }
            else
            {
                MessageBox.Show("user does not exist");
            }


        }
    }
}
