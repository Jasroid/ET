using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyToken
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if (Classes.UserAccounts.login(txtusername.Text, txtpassword.Text) > 0)
            {

                System.Web.HttpCookie usernameCookie = new HttpCookie("Username", Classes.UserAccounts.GetUsername(txtusername.Text));
                Response.Cookies.Add(usernameCookie);
                System.Web.HttpCookie useridCookie = new HttpCookie("UserID", Classes.UserAccounts.GetID(txtusername.Text));
                Response.Cookies.Add(usernameCookie);
                Response.Cookies.Add(useridCookie);
                Response.Redirect("Home.aspx");
            }


            else
            {
                lblerror.Visible = true;


            }
        }
    }
}