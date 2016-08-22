using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Default3 : System.Web.UI.Page
{
    Class2 obj = new Class2();

    protected void Page_Load(object sender, EventArgs e)
    {
        det();
        if (!IsPostBack)
        {
            det();
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
        TextBox txtname1 = new TextBox();

        obj.cmd.CommandText = "update stu set name='" + txtname.Text + "' where id='" + Convert.ToInt32(txtid.Text) + "'";
        int id = 0;
        obj.con.Open();
        id = Convert.ToInt32(obj.cmd.ExecuteScalar());
        obj.con.Close();
        //obj.dr["name"] = txtname.Text;
        //obj.dr["class"] = ddlclass.SelectedValue;
        //obj.dr["gender"] = rblgender.SelectedItem.Value;
        //obj.adp.Fill(obj.ds, "vt");
        //obj.scb.DataAdapter = obj.adp;
        //obj.adp.Update(obj.ds,"vt");
        obj.bindgrid(GridView1, "select * from stu where id='" + Convert.ToInt32(txtid.Text) + "'");

        Response.Write("<script>alert('agreed')</script>");
    }
    protected void Btnsearch_Click(object sender, EventArgs e)
    {
        det();
        obj.cmd.CommandText = "select * from stu where id='" + Convert.ToInt32(txtid.Text) + "'";
        obj.adp.Fill(obj.ds, "vt");
        if (obj.ds.Tables["vt"].Rows.Count > 0)
        {
            txtname.Text = obj.ds.Tables["vt"].Rows[0][1].ToString();
        }
        obj.bindgrid(GridView1, "select * from stu where id='" + Convert.ToInt32(txtid.Text) + "'");

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    public SqlConnection con = new SqlConnection(@"Data Source=RISHU\SQLSERVER2;Initial Catalog=ass1;User ID=sa;Password=pass");
    public SqlCommand cmd = new SqlCommand();
    public DataSet ds = new DataSet();
    public SqlDataAdapter adp = new SqlDataAdapter();
    public SqlCommandBuilder scb = new SqlCommandBuilder();
    public DataRow dr;
    public List<category> listt = new List<category>();
    public List<category> det()
    {

        cmd.Connection = con;
      
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "c_active";
        adp.SelectCommand = cmd;
        adp.Fill(ds, "vt");

        if (ds.Tables["vt"].Rows.Count > 0)
        {
            // dr = ds.Tables["vt"].NewRow();
            int id2 = Convert.ToInt32(ds.Tables["vt"].Rows[0][0].ToString());
            string name = ds.Tables["vt"].Rows[0][1].ToString();


            category c = new category(id2, name);
            listt.Add(c);

        }
        return listt;
        DropDownList1.DataValueField = "cid";
        DropDownList1.DataTextField = "cname";
        DropDownList1.DataSource = "listt";
        DropDownList1.DataBind();
    }
}