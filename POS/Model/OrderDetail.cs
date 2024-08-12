using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using POS.Model;
using POS.Forms;
using System.Windows.Forms;
namespace POS.Model
{
   public class OrderDetail
    {
        public int ODID { get; set; }
        public Order order { get; set; }
        public Product product { get; set; }
        
        public int price { get; set; }
        public int qty { get; set; }
        public int total { get; set; }
        public DateTime date { get; set; }

        public decimal Total_Order_Customer { get; set; }
        public OrderDetail()
        {
            ODID = -1;
        }
        public OrderDetail(Order od, Product pd, int p, int q, int t, DateTime dt)
        {
            order = od;
            product = pd;
            price = p;
            qty = q;
            total = t;
            date = dt;
        }
        public OrderDetail(int id)
        {
            try
            {
                string query = "select * from tblorderdetail where odid = @odid";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@odid", id);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);
                if (dt.Rows.Count > 0)
                {
                    ODID = id;
                    date = dt.Rows[0].Field<DateTime>("date");
                    price = dt.Rows[0].Field<int>("price");
                    qty = dt.Rows[0].Field<int>("qty");
                    total = dt.Rows[0].Field<int>("total");
                    order = new Order(dt.Rows[0].Field<int>("OID"));
                    product = new Product(dt.Rows[0].Field<int>("PID"));
                    



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
                string query = "Insert into tbleorderdetail(OID,PID,price,qty,total,date)values(@oid,@pid,@p,@q,@t,@date)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@oid", this.order.OID);
                cmd.Parameters.AddWithValue("@pid", this.product.PID);
                cmd.Parameters.AddWithValue("@p", this.price);
                cmd.Parameters.AddWithValue("@date", this.date);
                cmd.Parameters.AddWithValue("@q", this.qty);
                cmd.Parameters.AddWithValue("@t", this.total);

                DatabaseHandler db = new DatabaseHandler();
                db.InsertData(cmd);
                return "Order detail Insert Successfully  ";
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            return " ";
        }
        public decimal Customer_Total_Sale()
        {

            try
            {
                string query = "select c.cname SUM(od.total) as TOTAL from tblcustomer c inner join tblorder o on c.CID = o.CID inner join tbleorderdetail od on od.OID = o.OID GROUP BY  c.cname";
                SqlCommand cmd = new SqlCommand(query);
                
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);
                if (dt.Rows.Count > 0 && dt.Rows[0]["TOTAL"] != DBNull.Value)
                {
                    decimal? Total_Order_Customer = dt.Rows[0].Field<decimal?>("TOTAL");
                    return Total_Order_Customer ?? 0;
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
