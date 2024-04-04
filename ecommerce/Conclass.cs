using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ecommerce
{
    public class Conclass
    {
        SqlConnection con;
        SqlCommand cmd;
        public Conclass()
        {
            con = new SqlConnection(@"server=DESKTOP-PRINK0F\SQLEXPRESS;database=ecommerce;Integrated Security=true");
        }
        public int fn_NonQuery(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }
        public string fn_Scalar(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            string k = cmd.ExecuteScalar().ToString();
            con.Close();
            return k;
        }
        public SqlDataReader fn_ExeReader(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {

                con.Close();
            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public DataSet fn_ExeAdapter(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }

}
    
