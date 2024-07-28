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

        public Payment()
        {
            PYID = -1;

        }

        public Payment(DateTime d1, Customer cus)
        {
            date = d1;

            
            customer = cus;

        }

        public Payment(User us,Customer cus, int amt, DateTime d)
        {
            user = us;
            customer = cus;
            amount = amt;
            date = d;
            

        }
        //public Payment(DateTime d, int amount, string p, Supplier sup)
        //{
        //    date = d;
        //    pamount = amount;
        //    pmethod = p;
        //    supplier = sup;

        //}
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
                else
                {
                    PYID = -1;
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
                string query = "Insert into tblpayment(UID,CID,amount,date)values(@uid,@cid,@amount,@date)";
                SqlCommand cmd = new SqlCommand(query);

                cmd.Parameters.AddWithValue("@uid", this.user.UID);
                cmd.Parameters.AddWithValue("@cid", this.customer.CID);
                cmd.Parameters.AddWithValue("@date", this.date);
                cmd.Parameters.AddWithValue("@amount", this.amount);


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
        //public  DataTable CheckPayment()
        //{
        //    string query = "select * from paymenttable where date =@date AND pmethod  = @pmethod AND supid = @supid";
        //    //string query = "select p.date AS Date, p.pamount AS Amount,p.pmethod AS Method, s.name AS Supplier "+ 
        //    //                "from paymenttable p inner join suppliertable s  on p.supid=s.supid" +
        //    //                "where p.date =@date AND p.pmethod  = @pmethod AND s.supid = @supid";

        //    SqlCommand cmd = new SqlCommand(query);
        //    cmd.Parameters.AddWithValue("@date", this.date);
        //    cmd.Parameters.AddWithValue("@pmethod", this.pmethod);
        //    cmd.Parameters.AddWithValue("@supid", this.supplier.SupId);
        //    DatabaseHandler db = new DatabaseHandler();
        //    DataTable dt =  db.GetData(cmd);
        //    if(dt.Rows.Count>0)
        //    {
        //        PId = dt.Rows[0].Field<int>("PId");
        //        date = dt.Rows[0].Field<DateTime>("date");
        //        supplier = new Supplier(dt.Rows[0].Field<int>("SupId"));
        //        pamount = dt.Rows[0].Field<int>("pamount");
        //        pmethod = dt.Rows[0].Field<string>("pmethod");

        //        return dt;
        //    }

        //    return null;
        //}

        //public void CashPayment()
        //{
        //    if (supplier.SupId < 0)
        //        MessageBox.Show("Error Supplier name is required");

        //    try
        //    {


        //        string query = "select SUM(pamount) AS sum1 from paymenttable where supid = @supid AND pmethod = @pmethod AND date BETWEEN @sdate AND @edate";
        //        SqlCommand cmd = new SqlCommand(query);
        //        cmd.Parameters.AddWithValue("@supid", this.supplier.SupId);
        //        cmd.Parameters.AddWithValue("@pmethod", this.pmethod);
        //        cmd.Parameters.AddWithValue("@sdate", this.sdate);
        //        cmd.Parameters.AddWithValue("@edate", this.edate);
        //        DatabaseHandler db = new DatabaseHandler();
        //        DataTable dt = db.GetData(cmd);
        //        if (dt.Rows.Count > 0)
        //        {
        //            if (dt.Rows[0].Field<decimal?>("sum1") == null)
        //            {
        //                sum = 0;
        //            }
        //            else
        //            {

        //                sum = dt.Rows[0].Field<decimal>("sum1");
        //            }



        //        }

        //    }
        //    catch (Exception obj)
        //    {
        //        MessageBox.Show(obj.Message);
        //    }

        //}
        //public void CreditPayment()
        //{
        //    if (supplier.SupId < 0)
        //        MessageBox.Show("Error Supplier name is required");

        //    try
        //    {
        //        string query = "select SUM(pamount) AS sum2 from paymenttable where supid = @supid AND pmethod = @pmethod AND date BETWEEN @sdate AND @edate";
        //        SqlCommand cmd = new SqlCommand(query);
        //        cmd.Parameters.AddWithValue("@supid", this.supplier.SupId);
        //        cmd.Parameters.AddWithValue("@pmethod", this.pmethod);
        //        cmd.Parameters.AddWithValue("@sdate", this.sdate);
        //        cmd.Parameters.AddWithValue("@edate", this.edate);
        //        DatabaseHandler db = new DatabaseHandler();
        //        DataTable dt = db.GetData(cmd);
        //        if (dt.Rows.Count > 0)
        //        {
        //            if (dt.Rows[0].Field<decimal?>("sum2") == null)
        //            {
        //                creditsum = -1;
        //            }
        //            else
        //            {

        //                creditsum = dt.Rows[0].Field<decimal>("sum2");
        //            }



        //        }

        //    }
        //    catch (Exception obj)
        //    {
        //        MessageBox.Show(obj.Message);
        //    }

        //}// end credit payment

        public string Update()
        {
            string query = "Update tblpayment set uid = @uid,cid=@cid, date = @date, amount = @amount  where pyid = @pid ";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@pid", this.PYID);
            cmd.Parameters.AddWithValue("@date", this.date);
            cmd.Parameters.AddWithValue("@amount", this.amount);
            cmd.Parameters.AddWithValue("@uid", this.user.UID);
            cmd.Parameters.AddWithValue("@cid", this.customer.CID);



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
        //public DataTable Amount()
        //{
        //    string query = "select pamount AS Amount, pmethod AS Method, date,PId from paymenttable where supid = @supid  AND date = @date AND pmethod = @pmethod";
        //    SqlCommand cmd = new SqlCommand(query);

        //    cmd.Parameters.AddWithValue("@supid", this.supplier.SupId);
        //    cmd.Parameters.AddWithValue("@pmethod", this.pmethod);
        //    cmd.Parameters.AddWithValue("@date", this.date);

        //    DatabaseHandler db = new DatabaseHandler();
        //    DataTable dt = db.GetData(cmd);
        //    if (dt.Rows.Count > 0)
        //    {
        //        //supplier = new Supplier(dt.Rows[0].Field<int>("SupId"));

        //        //date = dt.Rows[0].Field<DateTime>("date");
        //        //pamount = dt.Rows[0].Field<decimal>("pamount");
        //        //pmethod = dt.Rows[0].Field<string>("pmethod");
        //        //PId = dt.Rows[0].Field<int>("PId");
        //        return dt;
        //    }
        //    return dt;
        //}
        //public decimal supplierpay(DateTime d1)
        //{
        //    try
        //    {
        //        string query = "select SUM(pamount) AS pay from paymenttable where date = @sdate AND pmethod = 'cash' ";
        //        SqlCommand cmd = new SqlCommand(query);
        //        cmd.Parameters.AddWithValue("@sdate", d1);

        //        DatabaseHandler db = new DatabaseHandler();
        //        DataTable dt = db.GetData(cmd);
        //        if (dt.Rows[0].Field<decimal?>("pay") == null)
        //        {
        //            return -1;
        //        }
        //        else
        //        {

        //            totalpay = dt.Rows[0].Field<decimal>("pay");
        //            return totalpay;

        //        }

        //    }
        //    catch (Exception obj)
        //    {
        //        MessageBox.Show(obj.Message);
        //    }
        //    return -1;
        //}
        //public decimal supplierpaydate(DateTime d1, DateTime d2)
        //{
        //    try
        //    {
        //        string query = "select SUM(pamount) AS pay from paymenttable where date BETWEEN @sdate AND @edate AND pmethod = 'cash' ";
        //        SqlCommand cmd = new SqlCommand(query);
        //        cmd.Parameters.AddWithValue("@sdate", d1);
        //        cmd.Parameters.AddWithValue("@edate", d2);
        //        DatabaseHandler db = new DatabaseHandler();
        //        DataTable dt = db.GetData(cmd);
        //        if (dt.Rows[0].Field<decimal?>("pay") == null)
        //        {
        //            return -1;
        //        }
        //        else
        //        {

        //            totalpay = dt.Rows[0].Field<decimal>("pay");
        //            return totalpay;

        //        }

        //    }
        //    catch (Exception obj)
        //    {
        //        MessageBox.Show(obj.Message);
        //    }
        //    return -1;
        //}
    }
}
