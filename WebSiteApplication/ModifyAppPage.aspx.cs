using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteApplication.ApplicationManagementServiceReference;
namespace WebSiteApplication
{
    public partial class ModifyAppPage : System.Web.UI.Page
    {

        protected void Page_Init(Object sender, EventArgs e)
        {

            GetData();


        }
    
        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ApplicationId"]);
            string user = (string)Session["user"];

            var client = new ApplicationManagementServiceClient();
            var appModel = new ApplicationModel();
            appModel.ApplicationName = txtUpdate.Text;
            client.UpdateApplication(id,appModel, user);
            Response.Redirect("ApplicationPage.aspx");
        }
         void GetData()
        {
            var applicationModel = new ApplicationModel();
            var client = new ApplicationManagementServiceClient();
            int id = Convert.ToInt32(Request.QueryString["ApplicationId"]);

            applicationModel = client.RetrieveApplication(id);
            txtUpdate.Text = applicationModel.ApplicationName;


        }
    }
    }
