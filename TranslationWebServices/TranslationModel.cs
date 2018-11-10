using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TranslationWebServices
{
    [DataContract]
    public class TranslationModel
    {
        [DataMember(Name = "TransId", IsRequired = false)]
        public int TransId { get; set; }
        [DataMember(Name ="Trans_Resource_Key")]
        public string Trans_Resource_Key { get; set; }
        [DataMember(Name ="Trans_Resource_Translation")]
        public string Trans_Resource_Translation { get; set; }
    }
}