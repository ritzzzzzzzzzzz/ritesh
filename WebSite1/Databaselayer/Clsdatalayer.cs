using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using empbo;
namespace Databaselayer
{
    public class Clsdatalayer
    {

        private string conn = @"Data Source=inchnilpdb02\mssqlserver1;Initial Catalog=CHN12_MMS73_TEST;User ID=mms73user;Password=mms73user";

        public void insertupdatedeletesqlstring(string sqlstring)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlstring, con);
            cmd.ExecuteNonQuery();
        }
        public object Executesqlstring(string sqlstring)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(sqlstring, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            return ds;
        }
        public string emplogin(int userid, string password)
        {
            DataTable dt = new DataTable();
            SqlConnection conn1 = new SqlConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();

                string str = @"Data Source=inchnilpdb02\mssqlserver1;Initial Catalog=CHN12_MMS73_TEST;User ID=mms73user;Password=mms73user";
                conn1.ConnectionString = str;
                conn1.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select role from tbl_omr_g6_employee where employee_id=@userid and password=@password";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@password", password);

                cmd.Connection = conn1;
                da.SelectCommand = cmd;
                da.Fill(dt);
                conn1.Close();
                if (dt.Rows.Count == 0)
                {
                    return string.Empty;
                }
                else
                {
                    return dt.Rows[0]["Role"].ToString();
                }


            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (conn1.State == ConnectionState.Open)
                {
                    conn1.Close();
                }
            }

        }
        public DataTable detailsviewapplication(string s)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                string d = s;
                string str = @"Data Source=inchnilpdb02\mssqlserver1;Initial Catalog=CHN12_MMS73_TEST;User ID=mms73user;Password=mms73user";
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from tbl_omr_g6_application where application_no='" + d + "' ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public DataTable Viewapp()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();

                string str = @"Data Source=inchnilpdb02\mssqlserver1;Initial Catalog=CHN12_MMS73_TEST;User ID=mms73user;Password=mms73user";
                //ConfigurationManager.ConnectionStrings["mine"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from viewapp";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }
    }
}