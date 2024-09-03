using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Model;
using System.Data.SqlClient;

namespace POS.Forms
{
    public partial class frmCustomerTrialbalance : Form
    {
        public frmCustomerTrialbalance()
        {
            InitializeComponent();
        }

        private void frmCustomerTrialbalance_Load(object sender, EventArgs e)
        {
            LoadData();
       
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            LoadData(txtCustomerSearch.Text.Trim());
        }
        private void LoadData(string searchTerm = "")
        {
            try
            {
                string query = @"
        SELECT 
            c.cname AS Customer,
            c.cell AS Mobile_Number1,
            c.cell2 AS Mobile_Number2,
            c.cell3 AS Mobile_Number3,
            COALESCE(o.UNPAID, 0) AS Pending,
            COALESCE(p.CASH, 0) AS CASH,
            
            COALESCE(o.UNPAID, 0) - COALESCE(p.CASH, 0) AS BALANCE
        FROM 
            tblcustomer c
        LEFT JOIN 
            (SELECT 
                 CID, 
                 SUM(amount) AS CASH
             FROM 
                 tblpayment
             GROUP BY 
                 CID) p ON c.CID = p.CID
        LEFT JOIN 
            (SELECT 
                 c.CID,
                 SUM(od.total) AS UNPAID
             FROM 
                 tblcustomer c
             INNER JOIN 
                 tblorder o ON c.CID = o.CID
             INNER JOIN 
                 tbleorderdetail od ON o.OID = od.OID
             GROUP BY 
                 c.CID) o ON c.CID = o.CID
        WHERE 
            (c.cname LIKE @SearchTerm OR @SearchTerm = '')
            OR (c.cell LIKE @SearchTerm OR @SearchTerm = '')
            OR (c.cell2 LIKE @SearchTerm OR @SearchTerm = '')
            OR (c.cell3 LIKE @SearchTerm OR @SearchTerm = '')
            
    ";

                using (SqlConnection connection = new SqlConnection(DatabaseHandler.ConnectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    //dataAdapter.SelectCommand.Parameters.AddWithValue("@CustomerName", "%" + customerName + "%");
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable; // Assuming you have a DataGridView named dataGridView1
                    dataGridView1.BackgroundColor = Color.FromArgb(220, 226, 240);
                    dataGridView1.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = Color.White,
                    };
                    dataGridView1.DefaultCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = Color.LightBlue,
                        ForeColor = Color.Black,
                        Font = new Font("Arial", 12, FontStyle.Bold)
                    };
                    dataGridView1.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                    {
                        Font = new Font("Arial", 14, FontStyle.Bold),
                    };
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    if (dataGridView1.Columns.Contains("Customer"))
                    {
                        dataGridView1.Columns["Customer"].Width = 300; // Set the desired width for the "Customer" column
                    }
                }
            }
            catch(Exception  obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
    }
}
