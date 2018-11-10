using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TranslationWebServices
{
    [DataContract]
    public class OperatorModel
    {
        [DataMember(Name="OperatorId",IsRequired = false)]

        public int OperatorId { get; set; }

        [DataMember (Name="UserName")]

        public string UserName { get; set; }

        [DataMember(Name = "Password")]

        public string Password { get; set; }
}
}