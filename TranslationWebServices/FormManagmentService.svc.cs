using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TranslationWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FormManagmentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FormManagmentService.svc or FormManagmentService.svc.cs at the Solution Explorer and start debugging.
    public class FormManagmentService : IFormManagmentService
    {
        public List<FormModel> ListForms(int appNo)
        {
            List<FormModel> forms = new List<FormModel>();

            SqlConnection connection =
                new SqlConnection(
                    "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();


            using (SqlCommand command = new SqlCommand("Select* from TRANSLATOR_FORM where TRANS_APP_NO=@appNo", connection))
            {
               
                command.Parameters.Add(new SqlParameter("appNo", appNo));
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    FormModel form = new FormModel();
                    form.FormId = Convert.ToInt32(reader["TRANS_FORM_NO"].ToString());
                    form.FormCategory = reader["TRANS_FORM_CATEGORY"].ToString();
                    form.FormName = reader["TRANS_FORM_NAME"].ToString();

                    forms.Add(form);

                }
            }
            return forms;
        }
             
        public string AddNewForm(FormModel formModel, ApplicationModel applicationModel, string updatedBy)
        {
             
            string message = "";
            SqlConnection connection =
                new SqlConnection(
                    "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();
            /*
            using (
                SqlCommand sqlCommand =
                    new SqlCommand("SELECT COUNT(*) TRANSLATOR_FORM where TRANS_APP_NO=@TRANS_APP_NO",
                        connection)
                )
            {

                sqlCommand.Parameters.Add(new SqlParameter("TRANS_APP_NO", application.ApplicationId));

                int count = (int) sqlCommand.ExecuteScalar();


                if (count > 0)
                {
            */
            using (SqlCommand command =
                new SqlCommand(
                    "insert into TRANSLATOR_FORM(TRANS_FORM_NAME,TRANS_FORM_CATEGORY,TRANS_APP_NO,UPDATED_BY)Values(@TRANS_FORM_NAME,@TRANS_FORM_CATEGORY,@TRANS_APP_NO,@UPDATED_BY)",
                    connection))
            {
            // DateTime.Now
                command.Parameters.Add(new SqlParameter("TRANS_FORM_NAME", formModel.FormName));
                command.Parameters.Add(new SqlParameter("TRANS_FORM_CATEGORY", formModel.FormCategory));
                command.Parameters.Add(new SqlParameter("UPDATED_BY", updatedBy));
                command.Parameters.Add(new SqlParameter("TRANS_APP_NO",applicationModel.ApplicationId));

            //   command.Parameters.Add(new SqlParameter("UPDATED_BY", httpSessionState["UserName"]));
                command.ExecuteScalar();


                message = "Form added";
                connection.Close();


            }
            return message;
        }

        public FormModel RetrieveForm(int id)
        {
            FormModel formModel = new FormModel();
            SqlConnection connection =
                new SqlConnection(
                    "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();

            using (
                SqlCommand cmdSqlCommand =
                    new SqlCommand("SELECT COUNT(*) from TRANSLATOR_FORM where TRANS_FORM_NO= @id",
                        connection))
            {

                cmdSqlCommand.Parameters.Add(new SqlParameter("id", id));
                int count = (int)cmdSqlCommand.ExecuteScalar();
                if (count == 1)
                {

                    using (SqlCommand command = new SqlCommand(
                        "select * from TRANSLATOR_FORM where TRANS_FORM_NO =@id", connection))
                    {
                        command.Parameters.Add(new SqlParameter("id", id));

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {


                            formModel.FormName = reader["TRANS_FORM_NAME"].ToString();
                            formModel.FormCategory = reader["TRANS_FORM_CATEGORY"].ToString();
                            formModel.FormId = Convert.ToInt32(reader["TRANS_FORM_NO"]);
                        }

                    }
                }
            }
            return formModel;


        }

        public bool UpdateForm(int formId, FormModel formModel, string updateBy)
        {

            var today = DateTime.Now;
            SqlConnection connection =
                new SqlConnection(
                    "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();


            using (
                var cmdUpdate =
                    new SqlCommand(
                        "UPDATE TRANSLATOR_FORM SET TRANS_FORM_NAME=@TRANS_FORM_NAME,TRANS_FORM_CATEGORY=@TRANS_FORM_CATEGORY,LAST_UPDATED=@LAST_UPDATED,UPDATED_BY=@UPDATED_BY WHERE TRANS_FORM_NO =@formId",
                        connection))
            {

                cmdUpdate.Parameters.Add("@formId", SqlDbType.Int).Value = formId;
                cmdUpdate.Parameters.Add("@TRANS_FORM_NAME", SqlDbType.VarChar).Value = formModel.FormName;
                cmdUpdate.Parameters.Add("@TRANS_FORM_CATEGORY", SqlDbType.VarChar).Value = formModel.FormCategory;
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
        public string DeleteForm(int formId)
        {

            string message = "Form has been deleted";
            SqlConnection connection =
               new SqlConnection(
                   "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();


            using (
                SqlCommand deleteCommand =
                    new SqlCommand("Delete from TRANSLATOR_FORM where TRANS_FORM_NO= @formId",
                        connection))

            {

                deleteCommand.Parameters.Add(new SqlParameter("formId", formId));
                    var reader = deleteCommand.ExecuteReader();

                    while (reader.Read())
                    {


                    }
                    reader.Close();
                }

            
            return message;
        }

        public DataSet ListFormsName(int appNo)
        {
            DataSet applications = new DataSet();
            SqlConnection connection = new SqlConnection(
                "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();
            using (var command = new SqlCommand(
              "Select* from TRANSLATOR_FORM where TRANS_APP_NO=@appNo", connection))
            {
                command.Parameters.Add(new SqlParameter("appNo", appNo));
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(applications);

            }

            return applications;

        }
    }
}