using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Default2 : System.Web.UI.Page
{
    string s1 = @"Data Source=RISHU\SQLSERVER2;Initial Catalog=ass1;User ID=sa;Password=pass";
 public   SqlConnection con = new SqlConnection();
 SqlCommand cmd = new SqlCommand();
 SqlDataAdapter adp = new SqlDataAdapter();
 SqlCommandBuilder scb = new SqlCommandBuilder();
 DataSet ds = new DataSet();
 DataRow dr;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            //ddlclass.Items.Insert(0,"prep");
            ddlclass.Items.Add("1");
            ddlclass.Items.Add("2");
            ddlclass.Items.Add("3");
            // c.ddlbind(ddlclass, "select class,id from stu", "Class", "id");
            rblgender.Items.Add("Male");
            rblgender.Items.Add("FeMale");
        }


    }

    protected void Btnadd_Click(object sender, EventArgs e)
    {
        con.ConnectionString = s1;
        cmd.Connection = con;
        cmd.CommandText = "select * from stu";
        adp.SelectCommand = cmd;
        adp.Fill(ds, "vt");
        dr=ds.Tables["vt"].NewRow();
        dr["name"] = txtname.Text;
        dr["class"] = ddlclass.SelectedValue;
        dr["gender"] = rblgender.SelectedValue.ToString();
        ds.Tables["vt"].Rows.Add(dr);
        scb.DataAdapter = adp;
        adp.Update(ds, "vt");
       Response.Write("<script>Alert('inserted sucesfully')</script>");
    }
}