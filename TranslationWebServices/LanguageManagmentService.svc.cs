using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TranslationWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LanguageManagmentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LanguageManagmentService.svc or LanguageManagmentService.svc.cs at the Solution Explorer and start debugging.
    public class LanguageManagmentService : ILanguageManagmentService
    {

        public string AddLanguage(LanguageModel language)
        {
            string message;
            var connection =
             new SqlConnection(
                 "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();

            using (
                var insertCommand =
                    new SqlCommand(
                        "Insert into TRANSLATOR_LANGUAGE(TRANS_LCID,TRANS_LANGUAGE)VALUES(@TRANS_LCID,@TRANS_LANGUAGE)",
                        connection))
            {
                insertCommand.Parameters.Add(new SqlParameter("TRANS_LCID", language.LanguageLCID));
                insertCommand.Parameters.Add(new SqlParameter("TRANS_LANGUAGE", language.LanguageName));
                int newRow = Convert.ToInt32(insertCommand.ExecuteScalar());
                connection.Close();
                message = "Language added to the list";
            }


            return message;

        }

        public List<LanguageModel> DisplayLanguages()
        {

            List<LanguageModel> languages = new List<LanguageModel>();

            var connection =
           new SqlConnection(
               "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();
            using (var selectCommand = new SqlCommand("Select TRANS_LANG_NO,TRANS_LCID,TRANS_LANGUAGE FROM TRANSLATOR_LANGUAGE", connection))
            {
                var reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    LanguageModel language = new LanguageModel();
                    language.LanguageId = Convert.ToInt32(reader["TRANS_LANG_NO"].ToString());
                    language.LanguageLCID = Convert.ToInt16(reader["TRANS_LCID"].ToString());
                    language.LanguageName = reader["TRANS_LANGUAGE"].ToString();
                    languages.Add(language);

                }
                connection.Close();

            }

            return languages;
        }

        public DataSet ListLanguages()
        {
            DataSet languages = new DataSet();
            SqlConnection connection = new SqlConnection(
                "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();
            using (var command = new SqlCommand(
              "Select * from TRANSLATOR_LANGUAGE", connection))
            {

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(languages);

            }

            return languages;

        }

        public string RemoveLanguage(int id)
        {

            return null;
        }

        public LanguageModel RetrieveLanguage(int id)
        {

            LanguageModel languageModel = new LanguageModel();
            SqlConnection connection =
                new SqlConnection(
                    "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();


            using (SqlCommand command = new SqlCommand(
                "select * from TRANSLATOR_LANGUAGE where TRANS_LANG_NO =@id", connection))
            {
                command.Parameters.Add(new SqlParameter("id", id));

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    languageModel.LanguageName = reader["TRANS_LANGUAGE"].ToString();
                    languageModel.LanguageLCID = Convert.ToInt32(reader["TRANS_LCID"]);

                }
            }
            connection.Close();
            return languageModel;
        }

        public string UpdateLanguage(int Id, LanguageModel languageeModel, string updateBy)
        {

            var today = DateTime.Now;
            SqlConnection connection =
                new SqlConnection(
                    "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();


            using (
                var cmdUpdate =
                    new SqlCommand(
                        "UPDATE TRANSLATOR_LANGUAGE SET TRANS_LANGUAGE=@TRANS_LANGUAGE,TRANS_LCID=@TRANS_LCID,LAST_UPDATED=@LAST_UPDATED,UPDATED_BY=@UPDATED_BY WHERE TRANS_LANG_NO =@Id",
                        connection))
            {

                cmdUpdate.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                cmdUpdate.Parameters.Add("@TRANS_LANGUAGE", SqlDbType.VarChar).Value = languageeModel.LanguageName;
                cmdUpdate.Parameters.Add("@TRANS_LCID", SqlDbType.VarChar).Value = languageeModel.LanguageLCID;
                cmdUpdate.Parameters.Add("@LAST_UPDATED", SqlDbType.DateTime).Value = today;
                cmdUpdate.Parameters.Add("@UPDATED_BY", SqlDbType.VarChar).Value = updateBy;

                int result = cmdUpdate.ExecuteNonQuery();
            }
            return null;
        }
    }
}
