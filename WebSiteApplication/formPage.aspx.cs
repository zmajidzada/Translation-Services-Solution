using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteApplication.ApplicationManagementServiceReference;
using WebSiteApplication.FormManagementServiceReference;
namespace WebSiteApplication
{
    public partial class formPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new FormManagmentServiceClient();
            //GridView1.DataSource = client.ListForms();
            //GridView1.DataBind();
            if (!Page.IsPostBack)
            {
               ApplicationNameDDList.DataSource = LoadDropDownList();
                ApplicationNameDDList.DataTextField = "TRANS_APP_NAME";
                ApplicationNameDDList.DataValueField = "TRANS_APP_NO";
                ApplicationNameDDList.DataBind();
                LoadGridView();
            }
        }
        private DataSet LoadDropDownList()
        {
            var client = new ApplicationManagementServiceClient();
            DataSet ds = new DataSet();
            ds = client.ListApplicationName();
            return ds;


        }
        private void LoadGridView()
        {

            var client = new FormManagmentServiceClient();
            FormListGridView.DataSource = client.ListForms(Convert.ToInt32(ApplicationNameDDList.SelectedValue));
            FormListGridView.DataBind();
        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var applicationModel = new FormManagementServiceReference.ApplicationModel();

           // int appId = Convert.ToInt32(Request.QueryString["ApplicationId"]);
            applicationModel.ApplicationId = Convert.ToInt32(ApplicationNameDDList.SelectedValue);

            string user = (string)Session["user"];
            var client = new FormManagmentServiceClient();
            FormModel form = new FormModel
            {
                FormName = txtBoxFormName.Text,
                FormCategory = txtBoxCategory.Text

            };

            string str = client.AddNewForm(form, applicationModel, user);
            //LabelRetunMessage.Text = str;
            FormListGridView.DataSource = client.ListForms(Convert.ToInt32(ApplicationNameDDList.SelectedValue));
            FormListGridView.DataBind();
            txtBoxFormName.Text = "";
            txtBoxCategory.Text = "";
        }

        protected void ApplicationNameDDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var client = new FormManagmentServiceClient();
            FormListGridView.DataSource = client.ListForms(Convert.ToInt32(ApplicationNameDDList.SelectedValue));
            FormListGridView.DataBind();
        }
    }

       

    }