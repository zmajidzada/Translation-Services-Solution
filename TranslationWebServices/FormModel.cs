using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TranslationWebServices
{

    [DataContract(Namespace ="www.zab.com")]
    public class FormModel
    {
        [DataMember(Name="FormId",IsRequired =false,Order =1)]
        public int FormId { get; set; }
        [DataMember(Name = "FormName",Order =2)]

        public string FormName { get; set; }

        [DataMember(Name = "FormCategory" ,Order=3)]

        public string FormCategory { get; set; }

    }
}