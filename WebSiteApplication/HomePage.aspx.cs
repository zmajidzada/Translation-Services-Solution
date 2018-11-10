using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteApplication.ApplicationManagementServiceReference;
using WebSiteApplication.FormManagementServiceReference;
using WebSiteApplication.LangManagmentServiceReference;
namespace WebSiteApplication
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DisplayDropDownList.DataSource = LoadApplicationNameDropDownList();
                DisplayDropDownList.DataTextField = "TRANS_APP_NAME";
                DisplayDropDownList.DataValueField = "TRANS_APP_NO";
                DisplayDropDownList.DataBind();

               
                ListFormsDropDownList.DataBind();
                LoadFromsNameDropDownList();
                LoadFormListGridView();
            

                LanguageListDDList.DataSource= LoadLanguage();
                LanguageListDDList.DataTextField = "TRANS_LANGUAGE";
                LanguageListDDList.DataValueField = "TRANS_LANG_NO";
                LanguageListDDList.DataBind();
            }
        }

        private DataSet LoadLanguage()
        {
            DataSet dataSet = new DataSet();
            var langClient = new LanguageManagmentServiceClient();
            dataSet= langClient.ListLanguages();
          

            return dataSet;
        }
        private DataSet LoadApplicationNameDropDownList()
        { 
            var client = new ApplicationManagementServiceClient();
            DataSet ds = new DataSet();
            ds = client.ListApplicationName();
            return ds;
        }
        private void LoadFromsNameDropDownList()
        {
            DataSet ds = new DataSet();
            var client = new FormManagmentServiceClient();
            ds = client.ListFormsName(Convert.ToInt32(DisplayDropDownList.SelectedValue));
            ListFormsDropDownList.DataSource = ds;
            ListFormsDropDownList.DataTextField = "TRANS_FORM_NAME";
            ListFormsDropDownList.DataValueField = "TRANS_FORM_NO";
            ListFormsDropDownList.DataBind();


        }
       
        private void LoadFormListGridView()
        {

            var client = new FormManagmentServiceClient();
           FormListGridView.DataSource = client.ListForms(Convert.ToInt32(DisplayDropDownList.SelectedValue));
            FormListGridView.DataBind();
        }

        protected void DisplayDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var client = new FormManagmentServiceClient();


            //ListFormsDropDownList.DataSource = client.ListForms(Convert.ToInt32(DisplayDropDownList.SelectedValue));
            //ListFormsDropDownList.DataTextField = "TRANS_FORM_NAME";
            //ListFormsDropDownList.DataValueField = "TRANS_FORM_NO";
            //ListFormsDropDownList.DataBind();

            LoadFromsNameDropDownList();
            LoadFormListGridView();
        
            //    FormListGridView.DataSource = client.ListForms(Convert.ToInt32(DisplayDropDownList.SelectedValue));
            //FormListGridView.DataBind();


        }
    }

    internal class List
    {
        public List()
        {
        }
    }
}