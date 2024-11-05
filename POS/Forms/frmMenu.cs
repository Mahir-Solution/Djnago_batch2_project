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
    public partial class frmMenu : Form
    {
        public static int USERID_ST;

        public frmMenu()
        {
            InitializeComponent();         
        }
        public frmMenu(int uid)
        {
            
            //MessageBox.Show(uid.ToString());
            InitializeComponent();
            frmMenu.USERID_ST = uid;
            User obj = new User(frmMenu.USERID_ST);
            
            txtuid.Text = obj.UID.ToString();
            lblusername.Text = obj.uname;
            lbltype.Text = obj.utype;
            
        }
        

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmsalesman obj = new frmsalesman();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmUser obj = new frmUser();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            frmProduct obj = new frmProduct();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmCustomer obj = new frmCustomer();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmPayment obj = new frmPayment();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panelContainer.Controls.Clear();

            // Example of adding a DataGridView
            DataGridView dataGridView1 = new DataGridView
            {
                Name = "dataGridView1",
                Dock = DockStyle.Fill,
                BackgroundColor = Color.FromArgb(220, 226, 240), // Set your desired background color here
                AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.White, // Set the alternating rows' background color
                },
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.Blue, // Set the default rows' background color
                    ForeColor = Color.Black, // Set the default text color
                    Font = new Font("Arial", 12, FontStyle.Bold)
                },
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Arial", 14, FontStyle.Bold), // Bold font for header with size 14
                    ////BackColor = Color.LightGray, // Background color for headers
                    ////ForeColor = Color.Black // Text color for headers
                },
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            panelContainer.Controls.Add(dataGridView1);
            

            // panelContainer.Controls.Clear();
            try
            {

                string query = "SELECT date AS Date, cname AS Customer, pname AS Product, uname AS Users, qty as Qty, price AS Price, total AS Total  FROM SaleView WHERE date = @value";




                using (SqlConnection connection = new SqlConnection(DatabaseHandler.ConnectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@value", DateTime.Today);

                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch(Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            if (dataGridView1.Columns.Contains("Customer"))
            {
                dataGridView1.Columns["Customer"].Width = 250; // Set the desired width for the "Customer" column
            }
            if (dataGridView1.Columns.Contains("Product"))
            {
                dataGridView1.Columns["Product"].Width = 150; // Set the desired width for the "Customer" column
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmBottle obj = new frmBottle();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //frmBackup obj = new frmBackup();
            //obj.TopLevel = false;
            //panelContainer.Controls.Clear();
            //panelContainer.Controls.Add(obj);
            //panelContainer.BringToFront();
            //obj.StartPosition = FormStartPosition.CenterParent;
            //obj.Dock = DockStyle.Fill;
            //obj.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            frmSale obj = new frmSale();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frmReporting obj = new frmReporting();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            frmsupplier obj = new frmsupplier();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            frmSaleReturnForm obj = new frmSaleReturnForm();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            frmstock obj = new frmstock();
            obj.TopLevel = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(obj);
            panelContainer.BringToFront();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }
    }
}
