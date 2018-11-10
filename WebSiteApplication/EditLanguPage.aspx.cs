using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteApplication.LangManagmentServiceReference;

namespace WebSiteApplication
{
    public partial class EditLanguPage : System.Web.UI.Page
    {

        protected void Page_Init(Object sender, EventArgs e)
        {

            GetData();


        }
       private void GetData()
        {
            int languageId = Convert.ToInt32(Request.QueryString["LanguageId"]);
            var client = new LanguageManagmentServiceClient();
            var languageModel = new LanguageModel();
            languageModel = client.RetrieveLanguage(languageId);
            txtBoxLanuage.Text = languageModel.LanguageName;
            txtBoxLCID.Text =Convert.ToString( languageModel.LanguageLCID);
        } 

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int languageId = Convert.ToInt32(Request.QueryString["LanguageId"]);
            var client = new LanguageManagmentServiceClient();
            var languageModel = new LanguageModel();
            languageModel.LanguageName = txtBoxLanuage.Text;
            languageModel.LanguageLCID = Convert.ToInt32(txtBoxLCID.Text);
            string user = (string)Session["user"];
            client.UpdateLanguage(languageId, languageModel, user);
            Response.Redirect("languagespage.aspx");

        }
    }
}