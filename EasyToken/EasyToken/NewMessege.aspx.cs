using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyToken
{
    public partial class NewMessege : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblinboxnum.Text = Classes.Messege.numinbox(Request.Cookies["UserID"].Value);
            lblsentnum.Text = Classes.Messege.numsent(Request.Cookies["UserID"].Value);
        }

        protected void btnsend_Click(object sender, EventArgs e)
        {
         

            Classes.Messege.SendMessege(Classes.UserAccounts.GetID(txtto.Text), Classes.UserAccounts.getname(txtto.Text), Request.Cookies["UserID"].Value, Classes.UserAccounts.getname(Request.Cookies["Username"].Value), txtsubject.Text, txtbody.Text, DateTime.Now.ToString());
            Response.Redirect("Messeges.aspx");
        }

        protected void btninbox_Click(object sender, EventArgs e)
        {
            Response.Redirect("Messeges.aspx");
        }

        protected void btnsent_Click(object sender, EventArgs e)
        {
            Response.Redirect("SentMesseges.aspx");
        }

    }
    
}