using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyToken
{
    public partial class ETMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (Request.Cookies["UserType"].Value == "1")
            {
                lblcreate.Visible = true;
            }
            else
            {
                lblcreate.Visible = false;

            }
            lbluser.Text = Request.Cookies["Username"].Value;

        }

    
    }
}