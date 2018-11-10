using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TranslationWebServices
{    [DataContract]
    public class LanguageModel
    {

        [DataMember(Name = "LanguageId",IsRequired = false)]
        public int LanguageId { get; set; }
        [DataMember(Name = "LanguageLCID")]
        public int LanguageLCID { get; set; }
        [DataMember(Name = "LanguageName")]
        public string LanguageName { get; set; }
    }
}