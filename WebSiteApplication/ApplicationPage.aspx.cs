using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WebSiteApplication.ApplicationManagementServiceReference;

namespace WebSiteApplication
{
    public partial class ApplicationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            LblMSG.Text = Session["user"].ToString();
            LblMSG.Visible = false;
            errorLabel.Visible = false;
            returnMsg.Visible = false;
            var client = new ApplicationManagementServiceClient();
          GridView1.DataSource = client.ListApplication();
            GridView1.DataBind();


         //   Repeater1.DataSource = client.ListApplication();
           // Repeater1.DataBind();

        }

        protected void ButtonAddApplication_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxAddApplication.Text))
            {
                errorLabel.Visible = true;
                errorLabel.ForeColor=System.Drawing.Color.Red;
                errorLabel.Text = "Please enter a name";
            }
            else
            {


                var client = new ApplicationManagementServiceClient();
                ApplicationModel app = new ApplicationModel
                {
                    ApplicationName = TextBoxAddApplication.Text,
                };
                
                
                var User = new OperatorModel
                {
                    UserName = LblMSG.Text,
                };
                string str = client.AddApplication(app, User);
                returnMsg.ForeColor = System.Drawing.Color.Green;
                returnMsg.Visible = true;
                errorLabel.Visible = false;
                returnMsg.Text = str;
                TextBoxAddApplication.Text = "";
                var client1 = new ApplicationManagementServiceClient();
                GridView1.DataSource = client1.ListApplication();
              
                GridView1.DataBind();
            }

     
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}