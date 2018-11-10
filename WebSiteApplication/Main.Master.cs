using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseDrivinApplication
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Url.ToString().ToLower().IndexOf("OperatorAuth.aspx") > -1 || (Request.Url.ToString().ToLower().IndexOf(".aspx") == -1))
            {


                pnMenu.Visible = false;
            }
            else
            {
                pnMenu.Visible = true;
                lblUser.ForeColor = System.Drawing.Color.White;
                lblUser.Text = "Hi, " + Session["user"].ToString();
            }
        }
    }
}