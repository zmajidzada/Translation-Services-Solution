using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TranslationWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILanguagesService" in both code and config file together.
    [ServiceContract]
    public interface ITranslationService
    {
     [OperationContract]
     void SaveTraslationData(int appNo, int formNo, int languageNo, string resource_Key,
     string resource_Key_translation, string updated_By);
        [OperationContract]

        List<TranslationModel> ListFormTranslation();

    }
}
