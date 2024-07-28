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
    public class Customer
    {
        public int CID { get; set; }
        public string cname { get; set; }
        public string cell { get; set; }
        public string address { get; set; }

        public Customer()
        {
            CID = -1;
            cname = null;
            cell = null;
            address = null;
        }
        public Customer(string n, string p, string ad)
        {

            cname = n;
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
            if (this.cname == null || this.cname == string.Empty)
                return "Error = supplier name is required";
            if (this.cell == null || this.cell == string.Empty)
                return "Error = phone number is required";
            if (this.address == null || this.address == string.Empty)
                return "Error =  Address is required";

            try
            {
                string query = "Insert Into tblcustomer(cname,cell,address)Values(@name,@phone,@address)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@name", this.cname);
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
        public Customer(int id)
        {
            try
            {
                string query = "select * from tblcustomer where CID= @CID ";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@CID", id);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);
                if (dt.Rows.Count > 0)
                {
                    CID = dt.Rows[0].Field<int>("CID");

                    cname = dt.Rows[0].Field<string>("cname");

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
            if (this.cname == null || this.cname == String.Empty)
                return "ERROR...  supplier Name Required";
            if (this.address == null || this.address == String.Empty)
                return "ERROR...  address Name Required";
            if (this.cell == null || this.cell == String.Empty)
                return "ERROR...  phone Name Required";
            try
            {

                string query = "Update tblcustomer set cname = @name, cell = @phone, address = @address where cid = @cid";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@cid", this.CID);
                cmd.Parameters.AddWithValue("@name", this.cname);
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
        //public static void Customerlist(ComboBox cbo)
        //{
        //    try
        //    {
        //        string qry = "Select * from tblcustomer Order By cname ASC";
        //        SqlCommand cmd = new SqlCommand(qry);
        //        DatabaseHandler db = new DatabaseHandler();
        //        DataTable dt = db.GetData(cmd);

        //        List<Customer> customers = new List<Customer>();

        //        // Add a default item at the beginning
        //        customers.Add(new Customer(-1, "Select a customer", string.Empty));

        //        // Populate the list with data from the DataTable
        //        foreach (DataRow row in dt.Rows)
        //        {
        //            int cid = Convert.ToInt32(row["CID"]);
        //            string cname = row["cname"].ToString();
        //            string cellno = row["cell"].ToString();

        //            customers.Add(new Customer(cid, cname, cellno));
        //        }

        //        // Bind the list to the ComboBox
        //        cbo.DataSource = customers;
        //        cbo.DisplayMember = "ToString"; // This will use the overridden ToString method
        //        cbo.ValueMember = "CID";
        //    }
        //    catch (Exception obj)
        //    {
        //        MessageBox.Show(obj.Message);
        //    }
        //}

        public static void Customerlist(ComboBox cbo)
        {
            try
            {
                string qry = "Select * from  tblcustomer Order By cname ASC";
                SqlCommand cmd = new SqlCommand(qry);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);

                DataRow dr = dt.NewRow();
                dr["CID"] = -1;

                if (dt.Rows.Count > 0)
                {
                    dr["cname"] = "Select a customer";
                }
                else
                {
                    dr["cname"] = "No customer Exist.";
                }

                dt.Rows.InsertAt(dr, 0);
                cbo.ValueMember = "CID";
                cbo.DisplayMember = "cname";
                cbo.DataSource = dt;
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }


        }
        public override string ToString()
        {
            return $"{cname} - {cell}";
        }
    }
}
