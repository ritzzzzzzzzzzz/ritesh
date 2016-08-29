using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Databaselayer;
namespace buisnesslayer
{
    public class Clsbuisness
    {

        public string emplogin(int userid, string password)
        {
            Clsdatalayer objdatalayer = new Clsdatalayer();
            return objdatalayer.emplogin(userid, password);
        }
        public DataTable viewall()
        {
            DataTable dt;
            Clsdatalayer datalayer = new Clsdatalayer();
            dt = datalayer.Viewapp();

            return dt;
        }
        public DataTable detailsviewapplication(string s)
        {
            DataTable dt;
            Clsdatalayer datalayer = new Clsdatalayer();
            dt = datalayer.detailsviewapplication(s);

            return dt;
        }
    }
}