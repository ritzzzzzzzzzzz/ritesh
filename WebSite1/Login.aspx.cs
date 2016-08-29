using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;
using System.Configuration;
using buisnesslayer;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!String.IsNullOrWhiteSpace(Request.Params["logout"]))
        {
            FormsAuthentication.SignOut();
            Response.Redirect("./");
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if(RadioButtonList1.SelectedItem.Value=="Employee")
        {
        Clsbuisness objbl = new Clsbuisness();

        string emp = objbl.emplogin(Convert.ToInt32(txtUserName.Text), txtPwd.Text);

        Session["emp"] = txtUserName.Text;

        if (emp == string.Empty)
        {
            Response.Write("<script>alert('Invalid Login credentails')</script>");
            popUpPanel.Visible = true;
        }
        else if (emp == "SR")
        {

            Response.Redirect("SR.aspx");

        }
        else
        {
            Response.Redirect("SR_Assistant.aspx");
        }
        }
        else
        {
            Response.Write("<script>alert('choose right option')</script>");
        }
    }
}