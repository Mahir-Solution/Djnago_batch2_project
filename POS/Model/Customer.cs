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
        public string cell2 { get; set; }
        public string cell3 { get; set; }
        public string address { get; set; }

        public Customer()
        {
            CID = -1;
            cname = null;
            cell = null;
            address = null;
        }
        public string Searchdata(string n,string c)
        {
            try
            {
                string query = "select cname,cell from tblcustomer where cname LIKE @n OR cell LIKE @c ";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@n", "%" + n + "%");
                cmd.Parameters.AddWithValue("@c", "%" + c + "%");
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);
                if (dt.Rows.Count > 0)
                {
                    return "this customer name or mobile nubmer is already exist";

                }
                
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            return null;
        }
        public Customer(string n, string p, string c2, string c3, string ad)
        {

            cname = n;
            cell = p;
            cell2 = c2;
            cell3 = c3;
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
           

            try
            {
                string query = "Insert Into tblcustomer(cname,cell,cell2,cell3,address)Values(@name,@phone,@phone2,@phone3,@address)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@name", this.cname);
                cmd.Parameters.AddWithValue("@phone", this.cell);
                cmd.Parameters.AddWithValue("@phone2", this.cell2);
                cmd.Parameters.AddWithValue("@phone3", this.cell3);
                cmd.Parameters.AddWithValue("@address", this.address);
                DatabaseHandler db = new DatabaseHandler();
                if (db.InsertData(cmd) > 0)
                {
                    return "Customer add successfully";

                }
                else
                {
                    return " Error ---  Customer not add try again";
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

                    cell2 = dt.Rows[0].Field<string>("cell2");

                    cell3 = dt.Rows[0].Field<string>("cell3");

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

                string query = "Update tblcustomer set cname = @name, cell = @phone, cell2 = @phone2,cell3 = @phone3, address = @address where cid = @cid";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@cid", this.CID);
                cmd.Parameters.AddWithValue("@name", this.cname);
                cmd.Parameters.AddWithValue("@phone", this.cell);
                cmd.Parameters.AddWithValue("@phone2", this.cell2);
                cmd.Parameters.AddWithValue("@phone3", this.cell3);
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
        public static DataTable CustomerSearch(string search)
        {
            DataTable dataTable;
            DatabaseHandler databaseHelper = new DatabaseHandler();
            string str = "Select CID, cname from tblcustomer  WHERE cname LIKE @searchCustomer ORDER BY cname ASC";
            string[] strArrays = search.Split(new char[] { ' ' });
            string str1 = "%";
            string[] strArrays1 = strArrays;
            for (int i = 0; i < (int)strArrays1.Length; i++)
            {
                str1 = string.Concat(str1, strArrays1[i], "%");
            }
            SqlCommand sqlCommand = new SqlCommand(str);
            sqlCommand.Parameters.AddWithValue("@searchCustomer", str1);
            DataTable data = databaseHelper.GetData(sqlCommand);
            if (data.Rows.Count <= 0)
            {
                DataRow dataRow = data.NewRow();
                dataRow["CID"] = -1;
                dataRow["cname"] = "No customer Found";
                data.Rows.InsertAt(dataRow, 0);
                dataTable = data;
            }
            else
            {
                dataTable = data;
            }
            return dataTable;
        }
    }
}
