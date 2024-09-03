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

        public int Total_Order_Customer { get; set; }
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
        public int Customer_Total_Sale(int cid)
        {

            try
            {
                //string query = "select c.cname, SUM(od.total) as TOTAL from tblcustomer c inner join tblorder o on c.CID = o.CID inner join tbleorderdetail od on od.OID = o.OID GROUP BY  c.cname";
                string query = "select c.cid, SUM(od.total) as TOTAL from tblcustomer c inner join tblorder o on c.CID = o.CID inner join tbleorderdetail od on od.OID = o.OID where c.cid = @cid group by c.cid";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@cid", cid);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);
                if (dt.Rows.Count > 0 && dt.Rows[0]["TOTAL"] != DBNull.Value)
                {
                    int? Total_Order_Customer = dt.Rows[0].Field<int?>("TOTAL");
                    return Total_Order_Customer ?? 0;
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            return 0;
        }
        public int Total_Sale_Qty(int pid)
        {

            try
            {

                string query = "select SUM(qty) AS T_Sale_Stock from tbleorderdetail where pid = @pid";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@pid", pid);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);
                if (dt.Rows.Count > 0)
                {
                    int? T_Sale_Stock = dt.Rows[0].Field<int?>("T_Sale_Stock");
                    return T_Sale_Stock ?? 0;
                    ;
                }

            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            return 0;
        }
        public DataTable fetch_order_detail(int oid)
        {
            try
            {
                string query = "select od.odid AS ID, p.pname AS Product,od.qty AS Quantity,od.total AS Total from tblproduct p inner join tbleorderdetail od on p.PID = od.PID where od.OID = @oid";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@oid", oid);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);
                return dt;
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            return null;
        }
        public int Order_Total(int oid)
        {
            try
            {
                string query = "select SUM(total) as TOTAL from tbleorderdetail where OID = @oid";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@oid", oid);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);
                if (dt.Rows.Count > 0)
                {
                    int? order_total = dt.Rows[0].Field<int?>("TOTAL");
                    return order_total ?? 0;
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
