﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Configuration;

public partial class registration : System.Web.UI.Page
{
    
    SqlConnection con = new SqlConnection();
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //RadioButtonList radioList = (RadioButtonList)Page.FindControl("rdb1");
            //radioList.Items.Add(new ListItem("MAle", "1"));
            //radioList.Items.Add(new ListItem("feMAle", "2"));
            //DropDownList ddl1=(DropDownList)Page.FindControl("ddl1");
            //ddl1.Items.Add("UP");
            //ddl1.Items.Add("TN");
        }

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        int a = 0;
        
        con.ConnectionString = @"Data Source=inchnilpdb02\mssqlserver1;Initial Catalog=CHN12_MMS73_TEST;User ID=mms73user;Password=mms73user";
        SqlCommand cmd = new SqlCommand("insertadd");
        SqlDataAdapter adp = new SqlDataAdapter();
        cmd.CommandType = CommandType.StoredProcedure;
      
        cmd.Parameters.AddWithValue("@username", txtname.Text);
        cmd.Parameters.AddWithValue("@pass", txtpass.Text);
        cmd.Parameters.AddWithValue("@email", txtemail.Text);
        cmd.Parameters.AddWithValue("@gender",rdb1.SelectedItem.ToString());
        cmd.Parameters.AddWithValue("@state", ddl1.SelectedItem.Value);
        cmd.Connection = con;
        con.Open();
        a =Convert.ToInt32(cmd.ExecuteScalar().ToString());

        con.Close();
        Session["id"] = a.ToString();
        //ClientScript.RegisterStartupScript(GetType(), "alert", "alert('added suceesfully');", true);
        Response.Write("<script>alert('added suceesfully')</script>" );
        Response.Redirect("default.aspx");
    }
}