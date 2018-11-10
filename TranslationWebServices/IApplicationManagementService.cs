using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TranslationWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IApplicationManagementService" in both code and config file together.
    [ServiceContract(Name = "IApplicationManagementService")]
    public interface IApplicationManagementService
    {
        [OperationContract]
        string AddApplication(ApplicationModel applicationModel, OperatorModel operatorModel);
        [OperationContract]
        bool UpdateApplication(int appId, ApplicationModel appModel, string updatedBy);
        [OperationContract]
        ApplicationModel RetrieveApplication(int id);

        [OperationContract]
        string DeleteApplication(int applicationId);

        [OperationContract]
        List<ApplicationModel> ListApplication();
        [OperationContract]
        DataSet ListApplicationName();
    

    }
}
