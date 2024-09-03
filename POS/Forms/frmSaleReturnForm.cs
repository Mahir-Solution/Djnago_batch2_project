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
    public partial class frmSaleReturnForm : Form
    {
        public frmSaleReturnForm()
        {
            InitializeComponent();
        }

        private void btreturn_Click(object sender, EventArgs e)
        {
            try
            {
                string ron = txtreturnordernumber.Text;
                DateTime date = dtpickerreturn.Value.Date;
                Order obj = new Order(ron, date);
                txtreturncustomer.Text = obj.customer.cname;
                txtorderdetailid.Text = obj.OID.ToString();// the txtorderdetailid contain order id 

                //put data into data grid view
                int oid = Convert.ToInt32(txtorderdetailid.Text);
                OrderDetail obj3 = new OrderDetail();
                DataTable tab = obj3.fetch_order_detail(oid);
                dataGridView1.DataSource = tab;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow();
        }
        private void DeleteSelectedRow()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Assuming the first column is the unique identifier for the row
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                // SQL query to delete the row from the database
                string deleteQuery = "DELETE FROM tbleorderdetail WHERE odid = @ID";

                using (SqlConnection connection = new SqlConnection(DatabaseHandler.ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ID", id);
                            command.ExecuteNonQuery();
                        }

                        // Remove the row from the DataGridView
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Show the button
                btnremove.Visible = true;
            }
            else
            {
                // Hide the button
                btnremove.Visible = false;
            }
        }
    }
}
