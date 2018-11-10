using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteApplication.LangManagmentServiceReference;

namespace WebSiteApplication
{
    public partial class Languagespage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            var client = new LanguageManagmentServiceClient();
          LanguageModel language=new LanguageModel();
            GridView1.DataSource = client.DisplayLanguages();
            GridView1.DataBind();

     //       var client = new LanguageManagmentServiceClient();
           // List<LanguageModel>languagesList = new List<LanguageModel>();
          //  languagesList = client.DisplayLanguages();
          //  dt.LoadDataRow(languagesList);




        }

        protected void ButtonAddLanguage_Click(object sender, EventArgs e)
        {
            var client = new LanguageManagmentServiceClient();
            var langaugeModel = new LanguageModel
            {
                LanguageLCID = Convert.ToInt32(TextBoxLanguageLCID.Text),
                LanguageName = TextBoxLanguageName.Text

            };

            client.AddLanguage(langaugeModel);
        }
    }
}