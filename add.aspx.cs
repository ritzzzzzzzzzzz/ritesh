using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class add : System.Web.UI.Page
{
    //product c = new product();
    inventory in1 = new inventory();
    public SqlConnection con = new SqlConnection(@"Data Source=RISHU\SQLSERVER2;Initial Catalog=ass1;User ID=sa;Password=pass");
    public SqlCommand cmd = new SqlCommand();
    public DataSet ds = new DataSet();
    public SqlDataAdapter adp = new SqlDataAdapter();
    public SqlCommandBuilder scb = new SqlCommandBuilder();
    public DataRow dr;
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        product c = new product(TextBox1.Text,TextBox2.Text,TextBox3.Text,100000,1001);
       int s= in1.add(c);
       // cmd.CommandType = CommandType.StoredProcedure;
       // cmd.CommandText = "c_ad";
       // cmd.Connection = con;
       // cmd.Parameters.AddWithValue("@pid", 0);
       // cmd.Parameters.AddWithValue("@cname", TextBox1.Text);
       // cmd.Parameters.AddWithValue("@Colors", TextBox2.Text);
       // cmd.Parameters.AddWithValue("@description", TextBox3.Text);
       // cmd.Parameters.AddWithValue("@price", TextBox4.Text);
       // cmd.Parameters.AddWithValue("@ctid", TextBox5.Text);
       // cmd.Parameters.AddWithValue("@Isactive", TextBox6.Text);
       // cmd.Parameters["@pid"].Direction = ParameterDirection.Output;
       //int s1 = cmd.ExecuteNonQuery();
       // con.Close();
       // int ii = 1;
       Response.Write("<script>alert('hello'+'"+s+"')</script>");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        DataTable ds1 = in1.dss();
        GridView1.DataSource = ds1;
        GridView1.DataBind();
    }
}