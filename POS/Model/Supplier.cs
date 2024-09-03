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
   public class Supplier
    {

        public int SupID { get; set; }
        public string sname { get; set; }
        public string cell { get; set; }
        public string address { get; set; }

        public string company { get; set; }
        public Supplier()
        {
            SupID = -1;
            sname = null;
            cell = null;
            address = null;
            company = null;
        }
        public Supplier(string n, string p, string ad, string com)
        {

            sname = n;
            cell = p;
            address = ad;
            company = com;
        }
        
        public string AddNew()
        {
            if (this.sname == null || this.sname == string.Empty)
                return "Error = supplier name is required";
            if (this.cell == null || this.cell == string.Empty)
                return "Error = phone number is required";
            if (this.address == null || this.address == string.Empty)
                return "Error =  Address is required";
            if (this.company == null || this.company == string.Empty)
                return "Error =  company is required";

            try
            {
                string query = "Insert Into tblSupplier(sname,cell,address,company)Values(@name,@phone,@address,@company)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@name", this.sname);
                cmd.Parameters.AddWithValue("@phone", this.cell);
                cmd.Parameters.AddWithValue("@address", this.address);
                cmd.Parameters.AddWithValue("@company", this.company);
                DatabaseHandler db = new DatabaseHandler();
                if (db.InsertData(cmd) > 0)
                {
                    return "Supplier add successfully";

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
        public Supplier(int id)
        {
            try
            {
                string query = "select * from tblSupplier where SupID= @SupID ";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@SupID", id);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);
                if (dt.Rows.Count > 0)
                {
                    SupID = dt.Rows[0].Field<int>("SupID");

                    sname = dt.Rows[0].Field<string>("sname");

                    cell = dt.Rows[0].Field<string>("cell");

                    address = dt.Rows[0].Field<string>("address");

                    company = dt.Rows[0].Field<string>("company");
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
            if (this.company == null || this.company == String.Empty)
                return "ERROR...  company Name Required";
            try
            {

                string query = "Update tblSupplier set sname = @name, cell = @phone, address = @address, company = @company where SupID = @SupID";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@SupID", this.SupID);
                cmd.Parameters.AddWithValue("@name", this.sname);
                cmd.Parameters.AddWithValue("@phone", this.cell);
                cmd.Parameters.AddWithValue("@address", this.address);
                cmd.Parameters.AddWithValue("@company", this.company);


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
        public static void Supplierlist(ComboBox cbo)
        {
            try
            {
                string qry = "Select * from  tblSupplier Order By sname ASC";
                SqlCommand cmd = new SqlCommand(qry);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);

                DataRow dr = dt.NewRow();
                dr["SupID"] = -1;

                if (dt.Rows.Count > 0)
                {
                    dr["sname"] = "Select a supplier";
                }
                else
                {
                    dr["sname"] = "No supplier Exist.";
                }

                dt.Rows.InsertAt(dr, 0);
                cbo.ValueMember = "SupID";
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
