using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyToken
{
    public partial class ViewSentMessege : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mid = Request.QueryString["SM"];
            lblMessege.Text = Classes.Messege.viewmessege(mid);
        }
    }
}