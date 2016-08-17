using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    SqlCommand cmd = new SqlCommand();


    SqlCommandBuilder scb = new SqlCommandBuilder();
    SqlDataAdapter adp = new SqlDataAdapter();
    DataSet ds = new DataSet();
    DataRow dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //con.ConnectionString = @"Data Source=inchnilpdb02\mssqlserver1;Initial Catalog=CHN12_MMS73_TEST;User ID=mms73user;Password=mms73user";
        //cmd.Connection = con;
        //adp.SelectCommand = cmd;
        //cmd.CommandText = "select * from claim_dd";
        //adp.Fill(ds, "vt");
        
        //scb.DataAdapter = adp;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.ConnectionString = @"Data Source=inchnilpdb02\mssqlserver1;Initial Catalog=CHN12_MMS73_TEST;User ID=mms73user;Password=mms73user";
        cmd.Connection = con;
        adp.SelectCommand = cmd;

        cmd.CommandText = "select * from claim_dd";
        adp.Fill(ds, "vt");
        ds.Tables["vt"].Constraints.Add("pk_id", ds.Tables["vt"].Columns[0], true);
        if (ds.Tables["vt"].Rows.Contains(TextBox1.Text))
        {
            DataRow dr = ds.Tables["vt"].Rows.Find(TextBox1.Text);
            TextBox2.Text = dr["model_no"].ToString();
        }
        else
        {

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
       

        con.ConnectionString = @"Data Source=inchnilpdb02\mssqlserver1;Initial Catalog=CHN12_MMS73_TEST;User ID=mms73user;Password=mms73user";
        cmd.Connection = con;
        adp.SelectCommand = cmd;
        cmd.CommandText = "select * from claim_dd";
        adp.Fill(ds, "vt");
        dr = ds.Tables["vt"].NewRow();
        dr["id"] = TextBox1.Text;

        dr["model_no"] = TextBox2.Text;
        dr["model_type"] = RadioButtonList1.SelectedItem.Value;
        dr["part_id"] = DropDownList1.SelectedItem.Value;
        dr["cost"] = TextBox4.Text;
        dr["labor"] = TextBox5.Text;
        dr["status"] = DropDownList2.SelectedItem.Value;
        ds.Tables["vt"].Rows.Add(dr);
        scb.DataAdapter = adp;
        adp.Update(ds, "vt");
        Response.Write("<script>alert('done')</script>");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        con.ConnectionString = @"Data Source=inchnilpdb02\mssqlserver1;Initial Catalog=CHN12_MMS73_TEST;User ID=mms73user;Password=mms73user";
        cmd.Connection = con;
        adp.SelectCommand = cmd;

        cmd.CommandText = "select * from claim_dd";
        adp.Fill(ds, "vt");
        ds.Tables["vt"].Constraints.Add("pk_id", ds.Tables["vt"].Columns[0], true);
       DataRow dr = ds.Tables["vt"].Rows.Find(this.TextBox1.Text);
        dr.BeginEdit();
        dr[1] = TextBox2.Text;
        
        dr.EndEdit();
        adp.Update(ds);
          
        
    }
}