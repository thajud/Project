using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace Project
{
    public class Concls
    {

        SqlCommand cmd;
        SqlConnection con;
        public Concls()
        {
            con = new SqlConnection(@"server=DESKTOP-ST1FDE1\SQLEXPRESS;database=Project;integrated security=true");
        }
        public int fn_nonquery(string quer)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(quer, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string fn_exescalar(string quer)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(quer, con);
            con.Open();
            string i = cmd.ExecuteScalar().ToString();
            con.Close();
            return i;

        }
        public SqlDataReader fn_exe(string quer)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            cmd = new SqlCommand(quer, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }
        public DataSet fn_exeAdap(string quer)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            SqlDataAdapter da = new SqlDataAdapter(quer, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

    }
}
