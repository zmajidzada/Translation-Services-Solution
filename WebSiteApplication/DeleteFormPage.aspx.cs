using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteApplication.FormManagementServiceReference;
namespace WebSiteApplication
{
    public partial class DeleteFormPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
             lblDelete.ForeColor = System.Drawing.Color.Red;   

         }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            var client = new FormManagmentServiceClient();
            int formId = Convert.ToInt32(Request.QueryString["FormId"]);
            client.DeleteForm(formId);
            Response.Redirect("formPage.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("formPage.aspx");
        }
    }
}