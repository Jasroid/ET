using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyToken
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            string uid = Request.Cookies["UserID"].Value;

            if (Request.Cookies["UserType"].Value == "1")
            {
                
                lblActiveTokens.Text = Classes.Tokens.ManActiveTokens(uid);
            
            }
            else
            {
                lblActiveTokens.Text = Classes.Tokens.UserActiveTokens(uid);
             
            }

        }

      
    }
}