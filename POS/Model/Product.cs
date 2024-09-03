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
   public class Product
    {
        public int PID { get; set; }
        public string pname { get; set; }
        public string unit { get; set; }
        public decimal price { get; set; }

        
        public Product()
        {
            PID = -1;
            pname = null;
            unit= null;
            price = -1;
           
            
        }
        public Product(string itname,string un,decimal p)
        {
            pname = itname;
            unit = un;
            price = p;

        }
        public string AddNew()
        {
            if (this.pname == null || this.pname == string.Empty)
                return "Error = item name is required";
            
            if (this.unit == null || this.unit == string.Empty)
                return "Error =  Unit is required";
            
            try
            {

                string query = " Insert into tblproduct(pname,unit,price)values(@itemname,@unit,@price)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@itemname", this.pname);
                
                cmd.Parameters.AddWithValue("@unit", this.unit);
                cmd.Parameters.AddWithValue("@price", this.price);
                DatabaseHandler db = new DatabaseHandler();

                if (db.InsertData(cmd) > 0)
                {
                    return "successfully add product";
                }
                else
                {
                    return "not add  item try again";
                }
            }
            catch (Exception obj)
            {
                return obj.ToString();
            }


        }
        public Product(int id)
        {
            try
            {
                string query = "select * from tblproduct where PID = @itemid";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@itemid", id);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);

                if (dt.Rows.Count > 0)
                {
                    PID = id;
                    pname = dt.Rows[0].Field<string>("pname");
                    
                    unit = dt.Rows[0].Field<string>("unit");
                    price = dt.Rows[0].Field<int>("price");
                }
                else
                {
                    PID = -1;
                    pname = null;
                    
                    unit = null;
                    price = -1;

                }
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        //public static Item SearchItem(string itemName)
        //{
        //    try
        //    {
        //        string query = "select * from itemtable where itemName = @itemName";
        //        SqlCommand cmd = new SqlCommand(query);
        //        cmd.Parameters.AddWithValue("@itemName", itemName);
        //        DatabaseHandler db = new DatabaseHandler();
        //        DataTable dt = db.GetData(cmd);

        //        if (dt.Rows.Count > 0)
        //        {
        //            int id = dt.Rows[0].Field<int>("itemId");
        //            return new Item(id);
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

        public string UpdateData()
        {
            

            try
            {
                string query = "update tblproduct set pname = @name,unit = @unit , price = @price  where pid = @id";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@id", this.PID);
                cmd.Parameters.AddWithValue("@name", this.pname);
                cmd.Parameters.AddWithValue("@price", this.price);
                cmd.Parameters.AddWithValue("@unit", this.unit);
                
                DatabaseHandler db = new DatabaseHandler();
                if (db.UpdateData(cmd) > 0)
                {
                    return "successfully update data";

                }
                else
                {
                    return " not update try again";
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            return " ";
        }

        public static void ProductList(ComboBox cbo)
        {
            string qry = "Select * from tblproduct Order By pname ASC";
            SqlCommand cmd = new SqlCommand(qry);
            DatabaseHandler db = new DatabaseHandler();
            DataTable dt = db.GetData(cmd);

            DataRow dr = dt.NewRow();
            dr["PID"] = -1;

            if (dt.Rows.Count > 0)
            {
                dr["pname"] = "Select a Product ";
            }
            else
            {
                dr["pname"] = "No Item Exist.";
            }

            dt.Rows.InsertAt(dr, 0);
            cbo.ValueMember = "PID";
            cbo.DisplayMember = "pname";
            cbo.DataSource = dt;
        }
        //public static DataTable itemlist(string search)
        //{
        //    DataTable dataTable;
        //    DatabaseHandler databaseHelper = new DatabaseHandler();
        //    string str = "Select itemid, itemname from ItemTable  WHERE itemname LIKE @searchCustomer ORDER BY itemname ASC";
        //    string[] strArrays = search.Split(new char[] { ' ' });
        //    string str1 = "%";
        //    string[] strArrays1 = strArrays;
        //    for (int i = 0; i < (int)strArrays1.Length; i++)
        //    {
        //        str1 = string.Concat(str1, strArrays1[i], "%");
        //    }
        //    SqlCommand sqlCommand = new SqlCommand(str);
        //    sqlCommand.Parameters.AddWithValue("@searchCustomer", str1);
        //    DataTable data = databaseHelper.GetData(sqlCommand);
        //    if (data.Rows.Count <= 0)
        //    {
        //        DataRow dataRow = data.NewRow();
        //        dataRow["ItemId"] = -1;
        //        dataRow["itemname"] = "No Item Found";
        //        data.Rows.InsertAt(dataRow, 0);
        //        dataTable = data;
        //    }
        //    else
        //    {
        //        dataTable = data;
        //    }
        //    return dataTable;
        //}
    }
}
