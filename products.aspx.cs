using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class products : System.Web.UI.Page
{
    inventory in1=new inventory();
    protected void Page_Load(object sender, EventArgs e)
    {
      List<category> io= in1.det();
       DropDownList1.DataValueField = "cid";
        DropDownList1.DataTextField = "cname";
        DropDownList1.DataSource = io;
        DropDownList1.DataBind();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}