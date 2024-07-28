﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using POS.Forms;
using POS.Model;
namespace POS.Model
{
   public class Order
    {
        public int OID { get; set; }
        public salesman slman { get; set; }
        public Customer customer { get; set; }
        public User user { get; set; }
        public string onumber { get; set; }
        public DateTime date { get; set; }

        public Order()
        {
            OID = -1;
        }
        public Order(salesman sl,Customer cus, User u,string on,DateTime dt)
        {
            slman = sl;
            customer = cus;
            user = u;
            onumber = on;
            date = dt;
        }
        public Order(int id)
        {
            try
            {
                string query = "select * from tblorder where oid = @oid";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@oid", id);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);
                if (dt.Rows.Count > 0)
                {
                    OID = id;
                    date = dt.Rows[0].Field<DateTime>("date");
                    onumber = dt.Rows[0].Field<string>("onumber");
                    slman = new salesman(dt.Rows[0].Field<int>("SID"));
                    customer = new Customer(dt.Rows[0].Field<int>("CID"));
                    user = new User(dt.Rows[0].Field<int>("UID"));



                }
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
        public Order(string on)
        {
            try
            {
                string query = "select * from tblorder where onumber = @on";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@on", on);
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = db.GetData(cmd);
                if (dt.Rows.Count > 0)
                {
                    OID = dt.Rows[0].Field<int>("OID");
                    //date = dt.Rows[0].Field<DateTime>("date");
                    //onumber = dt.Rows[0].Field<string>("onumber");
                    //slman = new salesman(dt.Rows[0].Field<int>("SID"));
                    //customer = new Customer(dt.Rows[0].Field<int>("CID"));
                    //user = new User(dt.Rows[0].Field<int>("UID"));



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
                string query = "Insert into tblorder(SID,CID,onumber,date,UID)values(@sid,@cid,@onumber,@date,@uid)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@sid", this.slman.SID);
                cmd.Parameters.AddWithValue("@uid", this.user.UID);
                cmd.Parameters.AddWithValue("@cid", this.customer.CID);
                cmd.Parameters.AddWithValue("@date", this.date);
                cmd.Parameters.AddWithValue("@onumber", this.onumber);


                DatabaseHandler db = new DatabaseHandler();
                db.InsertData(cmd);
                return "order Insert Successfully  ";
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            return " ";
        }

    }
}