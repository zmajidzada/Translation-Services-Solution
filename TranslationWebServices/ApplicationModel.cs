using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TranslationWebServices
{
    public class ApplicationModel
    {
          [DataMember(Name = "ApplicationId",IsRequired = false)]
        public int ApplicationId { get; set; }
        [DataMember(Name = "ApplicationName")]
        public string ApplicationName { get; set; }


    }
}