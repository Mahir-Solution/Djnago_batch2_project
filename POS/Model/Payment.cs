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
   public class Payment
    {
        public int PYID { get; set; }
        public DateTime date { get; set; }
        public DateTime sdate { get; set; }
        public DateTime edate { get; set; }
        public int amount { get; set; }
        
        public User user { get; set; }
        public Customer customer { get; set; }

        public decimal sum { get; set; }
        public decimal creditsum { get; set; }
        public decimal totalpay { get; set; }
        
        public string source { get; set; }
        public decimal Total_Customer_Payment { get; set; }
        public Payment()
        {
            PYID = -1;

        }

        public Payment(DateTime d1, Customer cus)
        {
            date = d1;

            
            customer = cus;

        }

        public Payment(User us,Customer cus, int amt, DateTime d,string s)
        {
            user = us;
            customer = cus;
            amount = amt;
            date = d;
            source = s;
            

        }
      
        public void FetchPayment()
        {
            try
            {
                string query = "select * from tblpayment where cid = @cid  AND date = @date";
                SqlCommand cmd = new SqlCommand(query);

                cmd.Parameters.AddWithValue("@cid", this.customer.CID);

                cmd.Parameters.AddWithValue("@date", this.date);
                

                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);
                if (dt.Rows.Count > 0)
                {
                    customer = new Customer(dt.Rows[0].Field<int>("CID"));

                    date = dt.Rows[0].Field<DateTime>("date");
                    amount = dt.Rows[0].Field<int>("amount");
                    PYID = dt.Rows[0].Field<int>("PYID");
                }
                
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }

        }
        public Payment(int id)
        {
            try
            {
                string query = "select * from tblpayment where pyid = @pid";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@pid", id);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);
                if (dt.Rows.Count > 0)
                {
                    PYID = id;
                    date = dt.Rows[0].Field<DateTime>("date");
                    amount = dt.Rows[0].Field<int>("amount");
                    
                    customer = new Customer(dt.Rows[0].Field<int>("CID"));
                    user = new User(dt.Rows[0].Field<int>("UID"));

                    

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
                string query = "Insert into tblpayment(UID,CID,amount,date,source)values(@uid,@cid,@amount,@date,@source)";
                SqlCommand cmd = new SqlCommand(query);

                cmd.Parameters.AddWithValue("@uid", this.user.UID);
                cmd.Parameters.AddWithValue("@cid", this.customer.CID);
                cmd.Parameters.AddWithValue("@date", this.date);
                cmd.Parameters.AddWithValue("@amount", this.amount);
                cmd.Parameters.AddWithValue("@source", this.source);

                DatabaseHandler db = new DatabaseHandler();
                db.InsertData(cmd);
                return "Payment Insert Successfully  ";
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            return " ";
        }
        

        public string Update()
        {
            string query = "Update tblpayment set uid = @uid,cid=@cid, date = @date, amount = @amount  where pyid = @pid ";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@pid", this.PYID);
            cmd.Parameters.AddWithValue("@date", this.date);
            cmd.Parameters.AddWithValue("@amount", this.amount);
            cmd.Parameters.AddWithValue("@uid", this.user.UID);
            cmd.Parameters.AddWithValue("@cid", this.customer.CID);
            //cmd.Parameters.AddWithValue("@s", this.source);



            DatabaseHandler db = new DatabaseHandler();

            if (db.UpdateData(cmd) > 0)
            {
                return "update successfully";
            }
            else
            {
                return " Error Not update Data";
            }
        }
        public decimal Customer_Total_Payment()
        {
            try
            {
                string query = "select SUM(p.amount) as AMOUNT from tblpayment p inner join tblcustomer c on c.CID = p.CID where c.CID = @cid";
                SqlCommand cmd = new SqlCommand(query);
                
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);
                if (dt.Rows.Count > 0)
                {
                    decimal? Total_Customer_Payment = dt.Rows[0].Field<decimal?>("AMOUNT");
                    return Total_Customer_Payment ?? 0;
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            return 0;
        }
    }
}
