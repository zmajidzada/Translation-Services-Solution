using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TranslationWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LanguagesService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LanguagesService.svc or LanguagesService.svc.cs at the Solution Explorer and start debugging.
    public class LanguagesService : ITranslationService
    {
        

        public void SaveTraslationData(int appNo, int formNo,int languageNo, string resource_Key,
        string resource_Key_translation,string updated_By)
        {
            SqlConnection connection =
            new SqlConnection(
                "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DELOCAL;Data Source=samah\\sqlexpress");
            connection.Open();

        }
        public List<TranslationModel> ListFormTranslation()
        {
            throw new NotImplementedException();
        }
    }
}
