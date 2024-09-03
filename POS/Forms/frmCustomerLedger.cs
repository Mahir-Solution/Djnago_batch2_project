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
    public partial class frmCustomerLedger : Form
    {
        public frmCustomerLedger()
        {
            InitializeComponent();
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cbsupplier1.SelectedValue);
            DateTime sd = sdate.Value.Date;
            DateTime ed = edate.Value.Date;
            LoadData(cid, sd, ed);
        }

        private void CustomerLedgerForm_Load(object sender, EventArgs e)
        {
            Customer.Customerlist(cbsupplier1);
        }
        private void LoadData(int cid, DateTime sd, DateTime ed)
        {
            
            string query = @"
    WITH CombinedData AS (
        -- Combine order and payment data
        SELECT 
            [date],
            SUM(pending) AS pending,
            SUM(cash) AS cash
        FROM 
        (
            -- Orders Section
            SELECT 
                o.date,
                SUM(od.total) AS pending,
                0 AS cash
            FROM 
                tblorder o
            INNER JOIN 
                tbleorderdetail od ON o.oid = od.oid
            WHERE 
                o.cid = @cid
            GROUP BY 
                o.date
            
            UNION ALL
            
            -- Payments Section
            SELECT 
                p.date,
                0 AS pending,
                SUM(p.amount) AS cash
            FROM 
                tblpayment p
            WHERE 
                p.cid = @cid
            GROUP BY 
                p.date
        ) AS combined_data
        WHERE 
            [date] BETWEEN @sd AND @ed
        GROUP BY 
            [date]
    ),
    OrderedData AS (
        -- Calculate cumulative balance
        SELECT
            [date],
            pending,
            cash,
            SUM(pending) OVER (ORDER BY [date] ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW) AS running_pending,
            SUM(cash) OVER (ORDER BY [date] ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW) AS running_cash
        FROM CombinedData
    )
    SELECT 
        [date],
        pending,
        cash,
        (running_pending - running_cash) AS balance
    FROM OrderedData
    ORDER BY 
        [date];";



            using (SqlDataAdapter adapter = new SqlDataAdapter(query, DatabaseHandler.ConnectionString))
            {
                // Add parameters to the query
                adapter.SelectCommand.Parameters.AddWithValue("@cid", cid);
                adapter.SelectCommand.Parameters.AddWithValue("@sd", sd);
                adapter.SelectCommand.Parameters.AddWithValue("@ed", ed);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

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

            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            CustomerSearch();
        }
        public void CustomerSearch()
        {
            try
            {
                DataTable dataTable = Customer.CustomerSearch(this.txtsearch.Text.Trim());
                DataRow dataRow = dataTable.NewRow();

                dataTable.Rows.InsertAt(dataRow, 0);
                this.cbsupplier1.ValueMember = "CID";
                this.cbsupplier1.DisplayMember = "cname";
                this.cbsupplier1.DataSource = dataTable;
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
    }
}
