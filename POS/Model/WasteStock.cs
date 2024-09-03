using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Model;
using System.Data.SqlClient;

namespace POS.Model
{
    public class WasteStock
    {
        public int WID { get; set; }
        public Product product { get; set; }

        public DateTime date { get; set; }

        public int qty { get; set; }
        public string reason { get; set; }

        public WasteStock()
        {
            WID = -1;
        }
        public WasteStock(Product pd,DateTime dt, int q , string r )
        {
            product = pd;
            date = dt;
            qty = q;
            reason = r;
        }
        public string AddNew()
        {


            try
            {

                string query = " Insert into tblwastestock(PID,date,qty,reason)values(@pid,@d,@qt,@r)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@pid", this.product.PID);
                cmd.Parameters.AddWithValue("@r", this.reason);
                cmd.Parameters.AddWithValue("@d", this.date);
                cmd.Parameters.AddWithValue("@qt", this.qty);

                DatabaseHandler db = new DatabaseHandler();

                if (db.InsertData(cmd) > 0)
                {
                    return "stock waste done";

                }
                else
                {
                    return "Error stock waste";
                }
            }
            catch (Exception obj)
            {
                return obj.ToString();
            }


        }

    }
}
