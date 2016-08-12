using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void Login_Click(object sender, EventArgs e)
    {
        //Response.Redirect("www.google.com");
        
        string s = @"Data Source=inchnilpdb02\mssqlserver1;Initial Catalog=CHN12_MMS73_TEST;User ID=mms73user;Password=mms73user"; 
        SqlConnection con = new SqlConnection(s);
        con.Open();
        
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
       
                 SqlDataAdapter adp = new SqlDataAdapter();
        adp.SelectCommand = cmd;
        DataSet ds=new DataSet();
        //DataRow dr;
        cmd.CommandText = "select * from employeee1 where username='" + txtid.Text.Trim() + "' and pass='" + txtpass.Text.Trim() + "'";

        adp.Fill(ds,"vt");
        if (ds.Tables["vt"].Rows.Count>0)
        {
            // MessageBox.Show("Invalid Login please check username and password");
            Response.Write("<script>alert('entry')</script>");

        }
        else
        {
            Response.Write("<script>alert('wrong entry')</script>");
        }

        con.Close();
    }
}
