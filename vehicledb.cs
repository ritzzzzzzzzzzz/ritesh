using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace empp
{
    public class vehicledb
    {
        string s11 = @"Data Source=inchnilpdb02\mssqlserver1;Initial Catalog=CHN12_MMS73_TEST;User ID=mms73user;Password=mms73user";



        public List<vehicle> viewd(string type)
        {
            SqlConnection con = new SqlConnection(s11);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "sp_details";
            List<vehicle> listt = new List<vehicle>();
            cmd.Parameters.AddWithValue("@type", type);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id1 = Convert.ToInt32(dr[0].ToString());
                int number = Convert.ToInt32(dr[2].ToString());
                vehicle obj = new vehicle(id1, number);
                listt.Add(obj);

            }
            return listt;
        }
        public int add(booking obj)
        {
            int check = 0;
            int s = 0;
            SqlConnection con = new SqlConnection(s11);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "sp_add";

            cmd.Parameters.AddWithValue("@book_id", 0);
            try
            {
                SqlCommand cmd1 = new SqlCommand("select num from vehicle where id=" + obj.Id, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    check = Convert.ToInt32(dr[0]);
                }
            }
            catch (SqlException ex)
            {

            }
                cmd.Parameters.AddWithValue("@id", obj.Id);
                cmd.Parameters.AddWithValue("@vehicles", obj.NumberofVehicles);
                cmd.Parameters.AddWithValue("@address1", obj.Address);
                cmd.Parameters["@book_id"].Direction = ParameterDirection.Output;
            if (check > obj.NumberofVehicles)
            {
                s = cmd.ExecuteNonQuery();
            }
            else
            {
                Console.WriteLine("number of vehicles error");
            }
                con.Close();
                if (s > 0)

                    return Convert.ToInt32(cmd.Parameters["@book_id"].Value);
                else
                    return s;
            }


        }
    }
 

