using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteApplication.AdminAuthServiceReference;

namespace WebSiteApplication
{
    public partial class RegistrationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
                var client = new AdminAuthServiceClient();

            var operatorModel = new OperatorModel
            {
                UserName = TextBoxUserName.Text,
                Password = TextBoxPassword.Text
            };

           bool result=Convert.ToBoolean( client.RegisterOperator(operatorModel));
            if (result)
            {
                Response.Redirect("OperatorAuth.aspx");
            }
            else
            {
             
                LabelMessage.Text = "User already taken";
            }
        

            client.Close();
        }


        }
    }
