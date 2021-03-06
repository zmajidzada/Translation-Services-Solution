﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSiteApplication.LangManagmentServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LanguageModel", Namespace="http://schemas.datacontract.org/2004/07/TranslationWebServices")]
    [System.SerializableAttribute()]
    public partial class LanguageModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LanguageIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LanguageLCIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LanguageNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LanguageId {
            get {
                return this.LanguageIdField;
            }
            set {
                if ((this.LanguageIdField.Equals(value) != true)) {
                    this.LanguageIdField = value;
                    this.RaisePropertyChanged("LanguageId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LanguageLCID {
            get {
                return this.LanguageLCIDField;
            }
            set {
                if ((this.LanguageLCIDField.Equals(value) != true)) {
                    this.LanguageLCIDField = value;
                    this.RaisePropertyChanged("LanguageLCID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LanguageName {
            get {
                return this.LanguageNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LanguageNameField, value) != true)) {
                    this.LanguageNameField = value;
                    this.RaisePropertyChanged("LanguageName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LangManagmentServiceReference.ILanguageManagmentService")]
    public interface ILanguageManagmentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILanguageManagmentService/AddLanguage", ReplyAction="http://tempuri.org/ILanguageManagmentService/AddLanguageResponse")]
        string AddLanguage(WebSiteApplication.LangManagmentServiceReference.LanguageModel languageModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILanguageManagmentService/AddLanguage", ReplyAction="http://tempuri.org/ILanguageManagmentService/AddLanguageResponse")]
        System.Threading.Tasks.Task<string> AddLanguageAsync(WebSiteApplication.LangManagmentServiceReference.LanguageModel languageModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILanguageManagmentService/RetrieveLanguage", ReplyAction="http://tempuri.org/ILanguageManagmentService/RetrieveLanguageResponse")]
        WebSiteApplication.LangManagmentServiceReference.LanguageModel RetrieveLanguage(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILanguageManagmentService/RetrieveLanguage", ReplyAction="http://tempuri.org/ILanguageManagmentService/RetrieveLanguageResponse")]
        System.Threading.Tasks.Task<WebSiteApplication.LangManagmentServiceReference.LanguageModel> RetrieveLanguageAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILanguageManagmentService/RemoveLanguage", ReplyAction="http://tempuri.org/ILanguageManagmentService/RemoveLanguageResponse")]
        string RemoveLanguage(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILanguageManagmentService/RemoveLanguage", ReplyAction="http://tempuri.org/ILanguageManagmentService/RemoveLanguageResponse")]
        System.Threading.Tasks.Task<string> RemoveLanguageAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILanguageManagmentService/UpdateLanguage", ReplyAction="http://tempuri.org/ILanguageManagmentService/UpdateLanguageResponse")]
        string UpdateLanguage(int id, WebSiteApplication.LangManagmentServiceReference.LanguageModel language, string updatedBy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILanguageManagmentService/UpdateLanguage", ReplyAction="http://tempuri.org/ILanguageManagmentService/UpdateLanguageResponse")]
        System.Threading.Tasks.Task<string> UpdateLanguageAsync(int id, WebSiteApplication.LangManagmentServiceReference.LanguageModel language, string updatedBy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILanguageManagmentService/DisplayLanguages", ReplyAction="http://tempuri.org/ILanguageManagmentService/DisplayLanguagesResponse")]
        WebSiteApplication.LangManagmentServiceReference.LanguageModel[] DisplayLanguages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILanguageManagmentService/DisplayLanguages", ReplyAction="http://tempuri.org/ILanguageManagmentService/DisplayLanguagesResponse")]
        System.Threading.Tasks.Task<WebSiteApplication.LangManagmentServiceReference.LanguageModel[]> DisplayLanguagesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILanguageManagmentService/ListLanguages", ReplyAction="http://tempuri.org/ILanguageManagmentService/ListLanguagesResponse")]
        System.Data.DataSet ListLanguages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILanguageManagmentService/ListLanguages", ReplyAction="http://tempuri.org/ILanguageManagmentService/ListLanguagesResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListLanguagesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILanguageManagmentServiceChannel : WebSiteApplication.LangManagmentServiceReference.ILanguageManagmentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LanguageManagmentServiceClient : System.ServiceModel.ClientBase<WebSiteApplication.LangManagmentServiceReference.ILanguageManagmentService>, WebSiteApplication.LangManagmentServiceReference.ILanguageManagmentService {
        
        public LanguageManagmentServiceClient() {
        }
        
        public LanguageManagmentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LanguageManagmentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LanguageManagmentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LanguageManagmentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AddLanguage(WebSiteApplication.LangManagmentServiceReference.LanguageModel languageModel) {
            return base.Channel.AddLanguage(languageModel);
        }
        
        public System.Threading.Tasks.Task<string> AddLanguageAsync(WebSiteApplication.LangManagmentServiceReference.LanguageModel languageModel) {
            return base.Channel.AddLanguageAsync(languageModel);
        }
        
        public WebSiteApplication.LangManagmentServiceReference.LanguageModel RetrieveLanguage(int id) {
            return base.Channel.RetrieveLanguage(id);
        }
        
        public System.Threading.Tasks.Task<WebSiteApplication.LangManagmentServiceReference.LanguageModel> RetrieveLanguageAsync(int id) {
            return base.Channel.RetrieveLanguageAsync(id);
        }
        
        public string RemoveLanguage(int id) {
            return base.Channel.RemoveLanguage(id);
        }
        
        public System.Threading.Tasks.Task<string> RemoveLanguageAsync(int id) {
            return base.Channel.RemoveLanguageAsync(id);
        }
        
        public string UpdateLanguage(int id, WebSiteApplication.LangManagmentServiceReference.LanguageModel language, string updatedBy) {
            return base.Channel.UpdateLanguage(id, language, updatedBy);
        }
        
        public System.Threading.Tasks.Task<string> UpdateLanguageAsync(int id, WebSiteApplication.LangManagmentServiceReference.LanguageModel language, string updatedBy) {
            return base.Channel.UpdateLanguageAsync(id, language, updatedBy);
        }
        
        public WebSiteApplication.LangManagmentServiceReference.LanguageModel[] DisplayLanguages() {
            return base.Channel.DisplayLanguages();
        }
        
        public System.Threading.Tasks.Task<WebSiteApplication.LangManagmentServiceReference.LanguageModel[]> DisplayLanguagesAsync() {
            return base.Channel.DisplayLanguagesAsync();
        }
        
        public System.Data.DataSet ListLanguages() {
            return base.Channel.ListLanguages();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListLanguagesAsync() {
            return base.Channel.ListLanguagesAsync();
        }
    }
}
