using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TranslationWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ApplicationManagementService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ApplicationManagementService.svc or ApplicationManagementService.svc.cs at the Solution Explorer and start debugging.
    public class ApplicationManagementService : IApplicationManagementService
    {
        public string AddApplication(ApplicationModel applicationModel, OperatorModel operatorModel)
        {
            string message = "";
            DateTime today = DateTime.Now;
            SqlConnection connection =
                new SqlConnection(
                    "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();

            using (SqlCommand command =
                new SqlCommand(
                    "insert into TRANSLATOR_APPLICATION(TRANS_APP_NAME,LAST_UPDATED,UPDATED_BY)Values(@TRANS_APP_NAME,@LAST_UPDATED,@UPDATED_BY)",
                    connection))
            {
                command.Parameters.Add(new SqlParameter("TRANS_APP_NAME", applicationModel.ApplicationName));
                 command.Parameters.Add(new SqlParameter("LAST_UPDATED", today));
                 command.Parameters.Add(new SqlParameter("UPDATED_BY", operatorModel.UserName));
                int count =command.ExecuteNonQuery();
                if (count == 1)
                {


                    message = "Application added";

                    connection.Close();
                }
                else
                {
                    message = "Could not be added";
                }
            }

            return message;
        }
         public ApplicationModel RetrieveApplication(int id)
        {
            ApplicationModel applicationModel = new ApplicationModel();
            SqlConnection connection =
                new SqlConnection(
                    "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();

            using (
                SqlCommand cmdSqlCommand =
                    new SqlCommand("SELECT COUNT(*) from TRANSLATOR_APPLICATION where TRANS_APP_NO= @id",
                        connection))
            {

                cmdSqlCommand.Parameters.Add(new SqlParameter("id", id));
                int count = (int)cmdSqlCommand.ExecuteScalar();
                if (count == 1)
                {

                    using (SqlCommand command = new SqlCommand(
                        "select * from TRANSLATOR_APPLICATION where TRANS_APP_NO =@id", connection))
                    {
                        command.Parameters.Add(new SqlParameter("id", id));

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {


                            applicationModel.ApplicationName = reader["TRANS_APP_NAME"].ToString();
                            
                           

                        }

                    }
                }
            }
            return applicationModel;


            
        }

        public bool UpdateApplication(int appId,ApplicationModel appModel, string updateBy)
        {
           var today=DateTime.Now;

            SqlConnection connection =
                new SqlConnection(
                    "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();


            using (
                var cmdUpdate =
                    new SqlCommand(
                        "UPDATE TRANSLATOR_APPLICATION SET TRANS_APP_NAME=@TRANS_APP_NAME,LAST_UPDATED=@LAST_UPDATED,UPDATED_BY=@UPDATED_BY WHERE TRANS_APP_NO =@appId",
                        connection))
            {
                cmdUpdate.Parameters.Add("@appId", SqlDbType.Int).Value = appId;
                cmdUpdate.Parameters.Add("@TRANS_APP_NAME", SqlDbType.VarChar).Value = appModel.ApplicationName;
                cmdUpdate.Parameters.Add("@LAST_UPDATED", SqlDbType.DateTime).Value = today;
                cmdUpdate.Parameters.Add("@UPDATED_BY", SqlDbType.VarChar).Value = updateBy;

            
                int result = cmdUpdate.ExecuteNonQuery();
                if (result == 1)
                {
                    return true;
                }

                else
                {

                    return false;
                }



            }
        }


        public string DeleteApplication(int applicationId)
        {

            string message = "Form has been deleted";
            SqlConnection connection =
               new SqlConnection(
                   "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();


            using (
                SqlCommand deleteCommand =
                    new SqlCommand("Delete from TRANSLATOR_APPLICATION where TRANS_APP_NO= @applicationId",
                        connection))
            {

                deleteCommand.Parameters.Add(new SqlParameter("applicationId", applicationId));
               
                var reader = deleteCommand.ExecuteReader();

                while (reader.Read())
                {


                }
                // reader.Close();
            }


            return message;
        }


        public List<ApplicationModel> ListApplication()
        {
            List<ApplicationModel> applications = new List<ApplicationModel>();
            SqlConnection connection = new SqlConnection(
                "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();
           
                    using (SqlCommand command = new SqlCommand("Select * from TRANSLATOR_APPLICATION", connection))
                    {
                       
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            ApplicationModel application = new ApplicationModel();

                            application.ApplicationName = reader["TRANS_APP_NAME"].ToString();
                            application.ApplicationId = Convert.ToInt32(reader["TRANS_APP_NO"].ToString());


                            applications.Add(application);

                        }

                
            }
            return applications;
        }
     public   DataSet ListApplicationName()
        {
            DataSet applications = new DataSet();
            SqlConnection connection = new SqlConnection(
                "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();
            using (var command = new SqlCommand(
              "Select * from TRANSLATOR_APPLICATION", connection))
            {
              
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(applications);

            }

            return applications;


        }


    }
}


