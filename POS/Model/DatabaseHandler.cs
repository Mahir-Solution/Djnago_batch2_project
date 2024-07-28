using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class DatabaseHandler
    {
        public static string ConnectionString;

        public static void SetConnection(string server, string instance, string catalog, string userid, string password)
        {
            ConnectionString = $@"Data Source = {server}\{instance}; Initial Catalog = {catalog}; Integrated Security = false; USER ID={userid}; Password={password};";
        }
        public static void SetNetworkConnection(string server, string instance, string catalog, string userid, string password)
        {
            ConnectionString = $@"Data Source = tcp:{server}\{instance},41434; Initial Catalog = {catalog}; Integrated Security = false; USER ID={userid}; Password={password};";
        }

        SqlDataAdapter sda;
        SqlCommandBuilder cb;

        public static void StartTransaction()
        {


        }

        public static void EndTransaction()
        {

        }
        public DataTable GetData(SqlCommand cmd)
        {
            SqlConnection con = null;
            DataTable dt = new DataTable();
            try
            {
                con = new SqlConnection(ConnectionString);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                con.Open();

                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.SelectCommand.CommandTimeout = 0;
                cb = new SqlCommandBuilder(sda);

                dt.Locale = System.Globalization.CultureInfo.InvariantCulture;

                sda.Fill(dt);
                con.Close();
                con.Dispose();

            }
            catch (Exception)
            {
                //e catched
                //MessageBox.Show(e.ToString());
            }

            finally
            {
                if (con != null) con.Close();
            }

            return dt;
        }

        public int InsertData(SqlCommand cmd, CommandType type = CommandType.Text)
        {
            int result = 0;
            SqlConnection con = new SqlConnection(ConnectionString);

            cmd.CommandType = type;
            cmd.Connection = con;
            sda = new SqlDataAdapter();
            sda.InsertCommand = cmd;
            con.Open();

            result = cmd.ExecuteNonQuery();

            con.Close();
            con.Dispose();
            return result;

        }

        public int UpdateData(SqlCommand cmd, CommandType type = CommandType.Text)
        {
            int result = 0;
            SqlConnection con = new SqlConnection(ConnectionString);

            cmd.CommandType = type;
            cmd.Connection = con;

            con.Open();

            int effectedRows = cmd.ExecuteNonQuery();
            if (effectedRows > 0) { result = effectedRows; }

            con.Close();
            con.Dispose();
            return result;

        }

        public string GetDatabaseStatus()
        {
            string status = "Oooops.. Connection to Database Lost!";

            string qry = "select 1";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = qry;

            var connection = GetData(cmd);
            if (connection.Rows.Count > 0)
            { status = "Connected to Database"; }

            return status;
        }

    }
}