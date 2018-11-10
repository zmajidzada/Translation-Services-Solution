using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Configuration;
using System.Web.SessionState;

using System.Web;
using System.Web.Services;
 
namespace TranslationWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdminAuthService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AdminAuthService.svc or AdminAuthService.svc.cs at the Solution Explorer and start debugging.
    public class AdminAuthService : IAdminAuthService
    {

  // protected System.Web.SessionState.HttpSessionState httpSessionState;
          
        public bool RegisterOperator(OperatorModel userOperatorModel)
        {
           var today = DateTime.Now;

            var connection =
                new SqlConnection(
                    "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();

            using (var sqlCommand =
                    new SqlCommand("SELECT COUNT(*) from TRANSLATOR_OPERATOR where OPERATOR_NAME = @OPERATOR_NAME",
                        connection)
                )
              {

                sqlCommand.Parameters.AddWithValue("@OPERATOR_NAME", userOperatorModel.UserName);

                int count = (int) sqlCommand.ExecuteScalar();


                if (count > 0)
                {
                    return false;
                }
                else
                {
                    using (var command =
                        new SqlCommand(
                            "insert into TRANSLATOR_OPERATOR(OPERATOR_NAME,OPERATOR_PASSWORD,LAST_UPDATED)Values(@OPERATOR_NAME,@OPERATOR_Password,@LAST_UPDATED)",
                            connection))
                    {
                        command.Parameters.Add(new SqlParameter("OPERATOR_NAME", userOperatorModel.UserName));
                        command.Parameters.Add(new SqlParameter("OPERATOR_PASSWORD", userOperatorModel.Password));
                        command.Parameters.Add(new SqlParameter("LAST_UPDATED", today));
                        int temp = Convert.ToInt16(command.ExecuteScalar());
                        connection.Close();
                    }
                }
                  return true;

              }

            
        }
    
        public bool AuthenticateOperator(OperatorModel userOperatorModel){
       
            

            var connection =
                        new SqlConnection(
                            "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();
            try
            {


                using (
                    SqlCommand sqlCommand =
                        new SqlCommand(
                            "SELECT COUNT(*) from TRANSLATOR_OPERATOR where OPERATOR_NAME=@OPERATOR_NAME AND OPERATOR_Password=@OPERATOR_Password",
                            connection)
                    )
                {

                    sqlCommand.Parameters.AddWithValue("@OPERATOR_NAME", userOperatorModel.UserName);
                    sqlCommand.Parameters.AddWithValue("@OPERATOR_Password", userOperatorModel.Password);

                    int count = (int) sqlCommand.ExecuteScalar();
                    if (count == 1)
                    {
                       // loginMessage = "Welcome" + userOperatorModel.UserName;
                       // httpSessionState["UserName"] = userOperatorModel.UserName;
                     // Session  ["UserName"] = userOperatorModel.UserName;
                        return true;
                    }
                    else
                    {
                       // loginMessage = "Log in Failed Please enter correct email and password";
                        return false;
                    }
             
                }
            }
            catch (Exception)
            {


                throw;

            }
        

        }

      
    }
}
