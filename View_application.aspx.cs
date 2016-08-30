using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using empbusiness;
namespace omr_gropu6
{
    public partial class View_application : System.Web.UI.Page
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
            clsbuisness objapp = new clsbuisness();
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
            clsbuisness objapp = new clsbuisness();
            string s = GridView1.SelectedValue.ToString();
            DataTable dt = objapp.detailsviewapplication(s);


            dvviewdetails.DataSource = dt;
            dvviewdetails.DataBind();
            mpe.Show();

        }


        protected void Btnsearch_Click(object sender, EventArgs e)
        {
            clsbuisness objapp = new clsbuisness();

            System.Text.StringBuilder s = new System.Text.StringBuilder();
            s.AppendFormat("select * from tbl_omr_application where 1=1");


            if (!String.IsNullOrEmpty(txtid.Text))
            {
                s.AppendFormat(" AND application_no =" + txtid.Text);

            }
            if (!String.IsNullOrEmpty(txtloc.Text))
            {
                s.AppendFormat(" AND location =" + txtloc.Text);

            }
            //if (!String.IsNullOrEmpty(txthusband.Text))
            //{
            //    s.AppendFormat(" AND husbandname =" + txthusband.Text);

            //}
            //if (!String.IsNullOrEmpty(txtwife.Text))
            //{
            //    s.AppendFormat(" AND wifename =" + txtwife.Text);

            //}


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
}