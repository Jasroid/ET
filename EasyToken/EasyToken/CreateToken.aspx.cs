using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyToken
{
    public partial class CreateToken : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
        }

        protected void btncreate_Click(object sender, EventArgs e)
        {
            string userid = Classes.UserAccounts.GetID(cbusers.SelectedValue);
            string usname = Classes.UserAccounts.getname(cbusers.SelectedValue);
            Classes.Request.Req(userid,usname, Request.Cookies["Username"].Value,Request.Cookies["UserID"].Value,txtnote.Text,txtappointment.Text,txtMedication.Text);
            Response.Redirect("Dashboard.aspx");
        }
    }
}