using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Forms
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // Define the connection string (replace with your server name, database name, and authentication method)
            string connectionString = "Server=DESKTOP-KFIITTP;Database=waterdb;User Id=sa;Password=wasi786;";

            // Define the backup directory and file name
            string backupDirectory = @"F:\RW_Backups";
            string backupFileReliance = $"{backupDirectory}\\waterdb_{DateTime.Now:yyyyMMdd_HHmmss}.bak";

            // Create the backup directory if it does not exist
            if (!System.IO.Directory.Exists(backupDirectory))
            {
                System.IO.Directory.CreateDirectory(backupDirectory);
            }

            // Define the SQL backup command
            string backupCommandText = $"BACKUP DATABASE waterdb TO DISK = '{backupFileReliance}'";

            try
            {
                btnbackup.Enabled = false; // Disable the button during the backup process
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(backupCommandText, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show($"Database backup successful! at Google Cloud Thanks Using Our Best Services", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL error during backup: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database backup failed! Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnbackup.Enabled = true; // Re-enable the button after the backup process
            }
        }
    }
    }

