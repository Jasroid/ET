using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyToken
{
    public partial class ViewToken : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tokenid = Request.QueryString["T"];
            lblname.Text = Classes.Tokens.GetCusname(tokenid);
            lblappointment.Text= Classes.Tokens.GetAppointment(tokenid);
            lblmedication.Text = Classes.Tokens.GetMedication(tokenid);
            lbldocnotes.Text = Classes.Tokens.GetDocNotes(tokenid);

            string username = Request.Cookies["Username"].Value;
            imgpic.ImageUrl = Classes.UserAccounts.GetPic(username);
            imgpic.Width = 300;
           
            imgpic.Height = 500;
        }
    }
}