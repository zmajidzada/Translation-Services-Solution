using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteApplication.FormManagementServiceReference;
namespace WebSiteApplication
{
    public partial class EditFormPage : System.Web.UI.Page
    {

        protected void Page_Init(Object sender, EventArgs e)
        {

            GetData();


        }
       
       void GetData()
        {
            var formModel = new FormModel();
            var client = new FormManagmentServiceClient();
            int id = Convert.ToInt32(Request.QueryString["FormId"]);
            formModel = client.RetrieveForm(id);
            txtFormName.Text = formModel.FormName;
            txtCategory.Text = formModel.FormCategory;
        }
         protected void BTNupdate_Click(object sender, EventArgs e)
        {
            var formModel = new FormModel();
            var client = new FormManagmentServiceClient();
            int id = Convert.ToInt32(Request.QueryString["FormId"]);
            formModel.FormName = txtFormName.Text;
            formModel.FormCategory = txtCategory.Text;
            string user = (string)Session["user"];

            client.UpdateForm(id, formModel, user);
            Response.Redirect("formPage.aspx");
        }
    }
}