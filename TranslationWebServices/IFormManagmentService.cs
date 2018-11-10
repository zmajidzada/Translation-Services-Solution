using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TranslationWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFormManagmentService" in both code and config file together.
    [ServiceContract]
    public interface IFormManagmentService
    {
        [OperationContract]
        List<FormModel> ListForms(int appNo);
        [OperationContract]
        DataSet ListFormsName(int appNo);
        [OperationContract]
        string AddNewForm(FormModel formModel, ApplicationModel applicationModel,string updatedBy);
        [OperationContract]
        FormModel RetrieveForm(int id);

        [OperationContract]
        bool UpdateForm(int formId ,FormModel formModel, string updateBy);
         [OperationContract]
        string DeleteForm(int formId);
    }
}
