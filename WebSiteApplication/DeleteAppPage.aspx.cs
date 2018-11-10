using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteApplication.ApplicationManagementServiceReference;
namespace WebSiteApplication
{
    public partial class DeleteAppPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            var client = new ApplicationManagementServiceClient();
            int id = Convert.ToInt32(Request.QueryString["ApplicationId"]);
            client.DeleteApplication(id);
            Response.Redirect("ApplicationPage.aspx");

        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("ApplicationPage.aspx");
        }
    }
}