using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using buisnesslayer;
using empbo;
public partial class viewapplications : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Btnall_Click(object sender, EventArgs e)
    {
        bindgrid();
    }
    private void bindgrid()
    {
        Clsbuisness objapp = new Clsbuisness();
        DataTable dt = objapp.viewall();
        if (dt != null)
        {
            if (dt.Rows.Count == 0)
            {
                lblmsg.Visible = true;
                lblmsg.Text = "No applications  to display";
            }
            else
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
        else
        {
            lblmsg.Visible = true;
            lblmsg.Text = "Error in dispalying applications ";
        }

    }
   
   
  
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Clsbuisness objapp = new Clsbuisness();
        string s = GridView1.SelectedValue.ToString();
        DataTable dt = objapp.detailsviewapplication(s);
     

                dvviewdetails.DataSource = dt;
                dvviewdetails.DataBind();
                mpe.Show();
       
    }
   public void  searchdetails()
    {
        Clsbuisness objapp = new Clsbuisness();
        System.Text.StringBuilder s = new System.Text.StringBuilder();
        s.AppendFormat("select * from view1 where 1=1");
        
        
        if (!String.IsNullOrEmpty(txtid.Text))
        {
            s.AppendFormat(" AND application_no ="+txtid.Text);
            
        }
        if (!String.IsNullOrEmpty(txtloc.Text))
        {
            s.AppendFormat(" AND location =" + txtloc.Text);
          
        }
        if (!String.IsNullOrEmpty(txthusband.Text))
        {
            s.AppendFormat(" AND husbandname =" + txthusband.Text);
          
        }
        if (!String.IsNullOrEmpty(txtwife.Text))
        {
            s.AppendFormat(" AND wifename =" + txtwife.Text);
         
        }
        DataTable dt = objapp.Viewfilter(s.ToString());
        if (dt != null)
        {
            if (dt.Rows.Count == 0)
            {
                lblmsg.Visible = true;
                lblmsg.Text = "No applications  to display";
            }
            else
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
        else
        {
            lblmsg.Visible = true;
            lblmsg.Text = "Error in dispalying applications ";
        }
    }
}