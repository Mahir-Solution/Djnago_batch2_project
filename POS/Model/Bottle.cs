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
   public class Bottle
    {
        public int BID{ get; set; }
        public int rbottle { get; set; }
        
        public int deliver { get; set; }
        public Customer customer { get; set; }
        public salesman slman { get; set; }
        public DateTime date { get; set; }

        public Bottle()
        {
            rbottle = -1;
            
            deliver = -1;
            slman = null;
            
        }
        public Bottle(int rb,  Customer cus, salesman sm, DateTime dt)
        {
            rbottle = rb;
            
            customer = cus;
            slman = sm;
            date = dt;

        }
        public Bottle(int rb, int dl,  Customer cus, salesman sm, DateTime dt)
        {
            rbottle = rb;
           
            deliver = dl;
            customer = cus;
            slman = sm;
            date = dt;

        }
        public Bottle(Customer cus, salesman sm, DateTime dts)
        {
            try
            {
                string query = "select * from tblbottle where cid = @cid AND  sid = @sid AND date = @date";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@cid", cus.CID);
                cmd.Parameters.AddWithValue("@sid", sm.SID);
                cmd.Parameters.AddWithValue("@date",dts);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);

                if (dt.Rows.Count > 0)
                {
                    BID = dt.Rows[0].Field<int>("BID");
                    rbottle = dt.Rows[0].Field<int>("rbottle");
                    
                }
                else
                {
                    rbottle = -1;
                   

                }
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }

        }
        public string AddNew()
        {
            
            try
            {

                string query = " Insert into tblbottle(rbottle,deliver,CID,SID,date)values(@rb,@dl,@cid,@sid,@date)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@rb", this.rbottle);
                
                cmd.Parameters.AddWithValue("@dl", this.deliver);
                cmd.Parameters.AddWithValue("@cid", this.customer.CID);
                cmd.Parameters.AddWithValue("@sid", this.slman.SID);
                cmd.Parameters.AddWithValue("@date", this.date);
                DatabaseHandler db = new DatabaseHandler();

                if (db.InsertData(cmd) > 0)
                {
                    return "successfully add Bottle Record";
                }
                else
                {
                    return "not add bottle try again";
                }
            }
            catch (Exception obj)
            {
                return obj.ToString();
            }


        }
        public Bottle(int id)
        {
            try
            {
                string query = "select * from tblbottle where BID = @bid";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@bid", id);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);

                if (dt.Rows.Count > 0)
                {
                    BID = id;
                    rbottle = dt.Rows[0].Field<int>("rbottle");
                    
                    customer = new Customer(dt.Rows[0].Field<int>("CID"));
                    slman = new salesman(dt.Rows[0].Field<int>("SID"));
                    date = dt.Rows[0].Field<DateTime>("date");
                }
                else
                {
                    rbottle = -1;
                   
                    deliver = -1;
                    slman = null;
                    customer = null;

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
                string query = "update tblbottle set rbottle = @rb,date = @date  where BID = @bid";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@rb", this.rbottle);
                cmd.Parameters.AddWithValue("@bid", this.BID);
                //cmd.Parameters.AddWithValue("@dl", this.deliver);
                //cmd.Parameters.AddWithValue("@sid", this.slman.SID);
                cmd.Parameters.AddWithValue("@date", this.date);
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

        //public static void BottleList(ComboBox cbo)
        //{
        //    string qry = "Select * from tblbottle";
        //    SqlCommand cmd = new SqlCommand(qry);
        //    DatabaseHandler db = new DatabaseHandler();
        //    DataTable dt = db.GetData(cmd);

        //    DataRow dr = dt.NewRow();
        //    dr["BID"] = -1;

        //    if (dt.Rows.Count > 0)
        //    {
        //        dr["itemname"] = "Select a Item ";
        //    }
        //    else
        //    {
        //        dr["itemname"] = "No Item Exist.";
        //    }

        //    dt.Rows.InsertAt(dr, 0);
        //    cbo.ValueMember = "Itemid";
        //    cbo.DisplayMember = "itemName";
        //    cbo.DataSource = dt;
        //}
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
