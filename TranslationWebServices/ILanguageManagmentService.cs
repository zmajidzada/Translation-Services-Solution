using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TranslationWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILanguageManagmentService" in both code and config file together.
    [ServiceContract]
    public interface ILanguageManagmentService
    {
        [OperationContract]
        string AddLanguage(LanguageModel languageModel);
        [OperationContract]
        LanguageModel RetrieveLanguage(int id);
        [OperationContract]
        string RemoveLanguage(int id);
        [OperationContract]
        string UpdateLanguage(int id, LanguageModel language, string updatedBy);
        [OperationContract]
        List<LanguageModel> DisplayLanguages();
        [OperationContract]
        DataSet ListLanguages();
    }
}
