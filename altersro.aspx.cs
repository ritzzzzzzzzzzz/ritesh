using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class altersro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        GridView1.Visible = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        GridView1.Visible = false;
    }
    protected void doupdate(object sender, GridViewUpdateEventArgs e)
    {

        GridViewRow gr = GridView1.Rows[e.RowIndex];


        TextBox txtfname, txtlname, txtdob, txtgender, txtemail, txtadd, txtno, txtyoe, txtdoj, txtctc, txtpass, txtrole, txtplace, txtstatus = new TextBox();
        //txtid = (TextBox)gr.Cells[1].Controls[0];
        txtfname = (TextBox)gr.FindControl("TextBox1");
        txtlname = (TextBox)gr.FindControl("TextBox2");
        txtdob = (TextBox)gr.FindControl("TextBox3");
        txtgender = (TextBox)gr.FindControl("TextBox4");
        txtemail = (TextBox)gr.FindControl("TextBox5");
        txtno = (TextBox)gr.FindControl("TextBox7");
        txtadd = (TextBox)gr.FindControl("TextBox6");
        txtyoe = (TextBox)gr.FindControl("TextBox8");
        txtdoj = (TextBox)gr.FindControl("TextBox9");
        txtctc = (TextBox)gr.FindControl("TextBox10");
        txtpass = (TextBox)gr.FindControl("TextBox11");
        txtrole = (TextBox)gr.FindControl("TextBox12");
        txtplace = (TextBox)gr.FindControl("TextBox13");
        txtstatus = (TextBox)gr.FindControl("TextBox14");
        // Label l = (Label)gr.FindControl("Label1");

        //FileStream fs = new FileStream(ss, FileMode.Open, FileAccess.Read);
        //int nBytes = (int)fs.Length;
        //byte[] ByteArray = new byte[nBytes + 1];
        RadioButtonList rdb1 = gr.FindControl("RadioButtonList1") as RadioButtonList;
        GridView1.EditIndex = -1;


    }
    protected void docancel(object sender, GridViewCancelEditEventArgs e)
    {

        GridView1.EditIndex = -1;


    }

    protected void doedit(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;


    }
    protected void dodelete(object sender, GridViewDeleteEventArgs e)
    {

        GridView1.EditIndex = -1;
    }
}