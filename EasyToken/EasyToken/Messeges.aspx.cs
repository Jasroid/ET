using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyToken
{
    public partial class Messeges : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblmessagelist.Text = Classes.Messege.getMessegeList(Request.Cookies["UserID"].Value);
            lblinboxnum.Text = Classes.Messege.numinbox(Request.Cookies["UserID"].Value);
            lblsentnum.Text = Classes.Messege.numsent(Request.Cookies["UserID"].Value);

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