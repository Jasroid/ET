using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyToken
{
    public partial class ViewMessege : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mid = Request.QueryString["M"];
            lblMessege.Text = Classes.Messege.viewmessege(mid);
            Classes.Messege.UpdateStatus("<span class='work'>Opened</span>", mid);
        }

        protected void btnsend_Click(object sender, EventArgs e)
        {
            string mid = Request.QueryString["M"];
            string subject = Classes.Messege.getreplysubject(mid);
            string to = Classes.Messege.gettoid(mid);
            string ton = Classes.Messege.gettoname(mid);
            string from = Classes.Messege.getfromid(mid);
            string fromn = Classes.Messege.getfromname(mid);

            Classes.Messege.SendMessege(to, ton, from, fromn, subject, txtbody.Text, DateTime.Now.ToString());
            Response.Redirect("Messeges.aspx");
        }
    }
    }
