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
    public class Stock
    {
        public int STID { get; set; }
        public Product product { get; set; }
        public Supplier slman { get; set; }
        public int qty { get; set; }
        public DateTime date { get; set; }

        public int T_Stock { get; set; }




        public Stock()
        {
            STID = -1;

        }
        public Stock(Supplier sl, Product p, DateTime dt, int q)
        {
            slman = sl;
            product = p;
            date = dt;
            qty = q;


        }
        public Stock(int id)
        {
            try
            {
                string query = "select * from tblStock where STID = @id";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);

                if (dt.Rows.Count > 0)
                {
                    STID = id;
                    slman = new Supplier(dt.Rows[0].Field<int>("SupID"));
                    product = new Product(dt.Rows[0].Field<int>("PID"));
                    date = dt.Rows[0].Field<DateTime>("date");
                    qty = dt.Rows[0].Field<int>("qty");

                }



            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
        public Stock(Product pd, Supplier sup, DateTime date)
        {
            try
            {
                string query = "select STID,qty from tblstock where  pid = @pid AND supid = @supid  AND date = @d";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@pid", pd.PID);
                cmd.Parameters.AddWithValue("@supid", sup.SupID);
                cmd.Parameters.AddWithValue("@d", date);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);

                if (dt.Rows.Count > 0)
                {

                    STID = dt.Rows[0].Field<int>("STID");
                    qty = dt.Rows[0].Field<int>("qty");

                }



            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        public int total_stock(int pid)
        {

            try
            {

                string query = "select SUM(qty) AS T_Stock from tblstock s inner join tblproduct p on s.PID = p.PID where s.pid = @pid";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@pid", pid);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);
                if (dt.Rows.Count > 0)
                {
                    int? T_Stock = dt.Rows[0].Field<int?>("T_Stock");
                    return T_Stock ?? 0;

                }

            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            return 0;
        }
        public string AddNew()
        {


            try
            {

                string query = " Insert into tblStock(PID,SupID,date,qty)values(@pid,@supid,@d,@qt)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@pid", this.product.PID);
                cmd.Parameters.AddWithValue("@supid", this.slman.SupID);
                cmd.Parameters.AddWithValue("@d", this.date);
                cmd.Parameters.AddWithValue("@qt", this.qty);

                DatabaseHandler db = new DatabaseHandler();

                if (db.InsertData(cmd) > 0)
                {
                    return "successfully add Stock";
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
        public string Update()
        {

            try
            {

                string query = "Update tblStock set qty = @q where stid = @stid";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@stid", this.STID);
                cmd.Parameters.AddWithValue("@q", this.qty);


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



    }
}
