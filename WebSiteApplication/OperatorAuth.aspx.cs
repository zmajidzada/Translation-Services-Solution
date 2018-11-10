using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WebSiteApplication.AdminAuthServiceReference;
namespace WebSiteApplication
{
    public partial class OperatorAuth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.TextBoxLoginUserName.Text)|string.IsNullOrEmpty(this.TextBoxLoginPassword.Text))
            {
                MessageBox.Show("provide User Name and Password");
            }
            var client = new AdminAuthServiceClient();

            var operatorModel = new OperatorModel
            {
                UserName = TextBoxLoginUserName.Text,
                Password = TextBoxLoginPassword.Text
            };
         

            bool result =Convert.ToBoolean( client.AuthenticateOperator(operatorModel));
           // MessageReturn.Text = str;
            client.Close();
            if(result)
            {
                Session["user"] = TextBoxLoginUserName.Text;
            
            Response.Redirect("http://localhost:65173/ApplicationPage.aspx");
            
           }
            else
            {
                Label1.Text = "Sorry, login failed";
            }
        }

      

       
    }
}