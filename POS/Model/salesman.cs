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
   public class salesman
    {
        public int SID { get; set; }
        public string sname { get; set; }
        public string cell { get; set; }
        public string address { get; set; }
        
        public salesman()
        {
            SID = -1;
            sname = null;
            cell = null;
            address = null;
        }
        public salesman(string n, string p, string ad)
        {

            sname = n;
            cell = p;
            address = ad;

        }
        //public Supplier( string p, string ad)
        //{


        //    phone = p;
        //    address = ad;

        //}
        public string AddNew()
        {
            if (this.sname == null || this.sname == string.Empty)
                return "Error = supplier name is required";
            if (this.cell == null || this.cell == string.Empty)
                return "Error = phone number is required";
            if (this.address == null || this.address == string.Empty)
                return "Error =  Address is required";

            try
            {
                string query = "Insert Into tblsalesman(sname,cell,address)Values(@name,@phone,@address)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@name", this.sname);
                cmd.Parameters.AddWithValue("@phone", this.cell);
                cmd.Parameters.AddWithValue("@address", this.address);
                DatabaseHandler db = new DatabaseHandler();
                if (db.InsertData(cmd) > 0)
                {
                    return "salesman add successfully";

                }
                else
                {
                    return " Error ---  supplier not add try again";
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            return " ";
        }
        public salesman(int id)
        {
            try
            {
                string query = "select * from tblsalesman where SID= @SID ";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@SID", id);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);
                if (dt.Rows.Count > 0)
                {
                    SID = dt.Rows[0].Field<int>("SID");

                    sname = dt.Rows[0].Field<string>("sname");

                    cell = dt.Rows[0].Field<string>("cell");

                    address = dt.Rows[0].Field<string>("address");
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
        public string Update()
        {
            if (this.sname == null || this.sname == String.Empty)
                return "ERROR...  supplier Name Required";
            if (this.address == null || this.address == String.Empty)
                return "ERROR...  address Name Required";
            if (this.cell == null || this.cell == String.Empty)
                return "ERROR...  phone Name Required";
            try
            {

                string query = "Update tblsalesman set sname = @name, cell = @phone, address = @address where sid = @sid";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@sid", this.SID);
                cmd.Parameters.AddWithValue("@name", this.sname);
                cmd.Parameters.AddWithValue("@phone", this.cell);
                cmd.Parameters.AddWithValue("@address", this.address);



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
        public static void Salesmanlist(ComboBox cbo)
        {
            try
            {
                string qry = "Select * from  tblsalesman Order By sname ASC";
                SqlCommand cmd = new SqlCommand(qry);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);

                DataRow dr = dt.NewRow();
                dr["SID"] = -1;

                if (dt.Rows.Count > 0)
                {
                    dr["sname"] = "Select a salesman";
                }
                else
                {
                    dr["sname"] = "No salesman Exist.";
                }

                dt.Rows.InsertAt(dr, 0);
                cbo.ValueMember = "SID";
                cbo.DisplayMember = "sname";
                cbo.DataSource = dt;
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
        

    }
}
