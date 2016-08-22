using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class _Default : System.Web.UI.Page
{
    Class1 c = new Class1();
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
        c.ds.Clear();
        c.cmd.CommandType = CommandType.StoredProcedure;
        c.cmd.CommandText = "insertt";
       // c.dr = c.ds.Tables["vt"].NewRow();
        c.cmd.Parameters.AddWithValue("@name", txtname.Text);
        c.cmd.Parameters.AddWithValue("@class", ddlclass.SelectedValue.ToString());
        c.cmd.Parameters.AddWithValue("@gender", rblgender.SelectedValue.ToString());
        c.adp.Fill(c.ds, "vt");     
       //c.ds.Tables["vt"].Rows.Add(c.dr);
       //c.scb.DataAdapter = c.adp;
       //c.adp.Update(c.ds.Tables["vt"]);
        c.con.Open();
        c.cmd.ExecuteNonQuery();
        c.con.Close();
       Response.Write("<script>alert('Inserted Succesfully')</script>");
    }
    protected void Search_Click(object sender, EventArgs e)
    {
        c.ds.Clear();
        c.cmd.Parameters.AddWithValue("@id", txtid.Text);
        c.cmd.CommandType = CommandType.StoredProcedure;
        c.cmd.CommandText = "update1";
      //c.dr = c.ds.Tables["vt"].NewRow();     
        c.cmd.Parameters.AddWithValue("@name", txtname.Text);
        c.cmd.Parameters.AddWithValue("@class", ddlclass.SelectedValue.ToString());
        c.cmd.Parameters.AddWithValue("@gender", rblgender.SelectedValue.ToString());
        c.adp.Fill(c.ds, "vt");
        c.con.Open();
        c.cmd.ExecuteNonQuery();
        c.con.Close();
        Response.Write("<script>alert('updated Succesfully')</script>");
    }
    protected void Btnsearch_Click(object sender, EventArgs e)
    {
        c.ds.Clear();
        c.cmd.Parameters.AddWithValue("@id", txtid.Text);
        c.cmd.CommandType = CommandType.StoredProcedure;
        c.cmd.CommandText = "srch";

        c.adp.Fill(c.ds, "vt");
        if (c.ds.Tables["vt"].Rows.Count > 0)
        {
            txtname.Text = c.ds.Tables["vt"].Rows[0][1].ToString();
            ddlclass.SelectedValue = c.ds.Tables["vt"].Rows[0][2].ToString();
            rblgender.SelectedValue = c.ds.Tables["vt"].Rows[0][3].ToString();
        }
        else
        {
            Response.Write("<script>alert('no data found')</script>");
        }
        //c.con.Open();
        //c.cmd.ExecuteNonQuery();
        //c.con.Close();
        
    }
}