using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Model
{
   public class User
    {
        public int UID { get; set; }
        public string uname { get; set; }
        public string password { get; set; }
        public string utype { get; set; }
        public User()
        {
            UID = -1;
            uname = null;
            password = null;
            utype = null;
        }
        public User(string n, string p, string ut)
        {

            uname = n;
            password = p;
            utype = ut;
        }
        public User(int id, string n, string p, string ut)
        {
            UID = id;
            uname = n;
            password = p;
            utype = ut;
        }
        public int getuserId()
        {
           
            
                string query = "select * from tbluser where uname = @uname AND password = @pwd AND utype = @utype";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@uname", this.uname);
                cmd.Parameters.AddWithValue("@pwd", this.password);
                cmd.Parameters.AddWithValue("@utype", this.utype);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);

                if (dt.Rows.Count > 0)
                {
                    UID = dt.Rows[0].Field<int>("UID");
                    uname = dt.Rows[0].Field<string>("uname");
                    return UID;
                }

                 return UID;
                   
            
        }
        public User(int id)
        {
            if (id > 0)
            {
                string query = "select * from tbluser where UID = @UID";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@UID", id);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);

                if (dt.Rows.Count > 0)
                {
                    UID = id;
                    uname = dt.Rows[0].Field<string>("uname");
                    password = dt.Rows[0].Field<string>("password");
                    utype = dt.Rows[0].Field<string>("utype");
                    UID = dt.Rows[0].Field<int>("UID");
                }
                else
                {
                    UID = -1;
                    uname = null;
                    password = null;
                    utype = null;
                }
            }
        }

        public string AddNew()
        {
            if (this.utype == null || this.utype == string.Empty)
                return "Error = User Type  is required";


            if (this.uname == null || this.uname == string.Empty)
                return "Error = user name is required";

            if (this.password == null || this.password == string.Empty)
                return "Error = password  is required";


            try
            {
                string query = "Insert Into tbluser(uname,password,utype)values(@uname,@password,@utype)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@uname", this.uname);
                cmd.Parameters.AddWithValue("@password", this.password);
                cmd.Parameters.AddWithValue("@utype", this.utype);

                DatabaseHandler db = new DatabaseHandler();

                if (db.InsertData(cmd) > 0)
                {
                    return "Add successfully";
                }
                else
                {
                    return " Error -- try again";
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            return " ";
        }
        //public static User SearchItem(string Username)
        //{
        //    try
        //    {
        //        string query = "select * from usertable where uname = @uname";
        //        SqlCommand cmd = new SqlCommand(query);
        //        cmd.Parameters.AddWithValue("@uname", Username);
        //        DatabaseHandler db = new DatabaseHandler();
        //        DataTable dt = db.GetData(cmd);

        //        if (dt.Rows.Count > 0)
        //        {
        //            int id = dt.Rows[0].Field<int>("UID");
        //            return new User(id);
        //        }
        //        else
        //            return null;
        //    }
        //    catch (Exception obj)
        //    {
        //        MessageBox.Show(obj.Message);
        //    }
        //    return null;

        //}



        public string Update()
        {
            if (this.uname == null || this.uname == String.Empty)
                return "ERROR... User Name Required";
            try
            {
                string query = "Update tbluser set uname = @uname, password = @pwd, utype = @utype where UID = @UID";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@uname", this.uname);
                cmd.Parameters.AddWithValue("@pwd", this.password);
                cmd.Parameters.AddWithValue("@utype", this.utype);
                cmd.Parameters.AddWithValue("@UID", this.UID);


                DatabaseHandler db = new DatabaseHandler();
                if (db.UpdateData(cmd) > 0)
                {
                    return "successfully update data";
                }
                else
                {
                    return "could not updata try again";
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            return " ";
        }

        public string Login()
        {

            if (this.uname == null || this.uname == String.Empty)
                return "ERROR... User Name Required";
            if (this.password == null || this.password == String.Empty)
                return "ERROR... password Required";
            if (this.utype == null || this.utype == String.Empty)
                return "ERROR... User Type Required";



            //try
            //{

            string query = "select *  from tbluser where uname = @uname AND password = @password AND utype = @utype ";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@uname", this.uname);
            cmd.Parameters.AddWithValue("@password", this.password);
            cmd.Parameters.AddWithValue("@utype", this.utype);

            DatabaseHandler db = new DatabaseHandler();

            DataTable dt = db.GetData(cmd);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0].Field<string>("utype").Equals("Admin"))
                {
                    // return "valid user";
                    return "Admin";
                }
                else if (dt.Rows[0].Field<string>("utype").Equals("User"))
                {

                    //return "valid user";
                    return "User";

                }
                else
                {
                    return " Invalid User";
                }


            }

            //}
            //catch (Exception obj)
            //{
            //    MessageBox.Show(obj.Message);
            //}
            return null;
        }
        public static void Userlist(ComboBox cbo)
        {
            try
            {
                string qry = "Select * from  tbluser Order By uname ASC";
                SqlCommand cmd = new SqlCommand(qry);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);

                DataRow dr = dt.NewRow();
                dr["UID"] = -1;

                if (dt.Rows.Count > 0)
                {
                    dr["uname"] = "Select a User ";
                }
                else
                {
                    dr["uname"] = "No user Exist.";
                }

                dt.Rows.InsertAt(dr, 0);
                cbo.ValueMember = "UID";
                cbo.DisplayMember = "uname";
                cbo.DataSource = dt;
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
    }
}
