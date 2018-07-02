using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyToken
{
    public partial class CompanySignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            if (Classes.UserAccounts.checkusername(txtusername.Text) == 1)
            {
                lblexists.Visible = true;
                lblerror.Visible = false;
                lblmatch.Visible = false;
            }
            if (txtpassword.Text != txtConfirm.Text)
            {
                lblexists.Visible = false;
                lblerror.Visible = false;

                lblmatch.Visible = true;
            }
            else if (txtusername.Text == "" || txtConfirm.Text == "" || txtemail.Text == "" || txtName.Text == "" || txtpassword.Text == "")
            {
                lblexists.Visible = false;

                lblmatch.Visible = false;
                lblerror.Visible = true;
            }
            else
            {

                Classes.UserAccounts.CompanyReg(txtName.Text, txtusername.Text, txtemail.Text, txtpassword.Text,txtaddress.Text,txttelephone.Text);
                Response.Redirect("Login.aspx");
            }
        }
    }
}