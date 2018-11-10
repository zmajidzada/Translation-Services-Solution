﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSiteApplication.ApplicationManagementServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ApplicationModel", Namespace="http://schemas.datacontract.org/2004/07/TranslationWebServices")]
    [System.SerializableAttribute()]
    public partial class ApplicationModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ApplicationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApplicationNameField;
        
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
        public int ApplicationId {
            get {
                return this.ApplicationIdField;
            }
            set {
                if ((this.ApplicationIdField.Equals(value) != true)) {
                    this.ApplicationIdField = value;
                    this.RaisePropertyChanged("ApplicationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApplicationName {
            get {
                return this.ApplicationNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ApplicationNameField, value) != true)) {
                    this.ApplicationNameField = value;
                    this.RaisePropertyChanged("ApplicationName");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OperatorModel", Namespace="http://schemas.datacontract.org/2004/07/TranslationWebServices")]
    [System.SerializableAttribute()]
    public partial class OperatorModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OperatorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public int OperatorId {
            get {
                return this.OperatorIdField;
            }
            set {
                if ((this.OperatorIdField.Equals(value) != true)) {
                    this.OperatorIdField = value;
                    this.RaisePropertyChanged("OperatorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ApplicationManagementServiceReference.IApplicationManagementService")]
    public interface IApplicationManagementService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationManagementService/AddApplication", ReplyAction="http://tempuri.org/IApplicationManagementService/AddApplicationResponse")]
        string AddApplication(WebSiteApplication.ApplicationManagementServiceReference.ApplicationModel applicationModel, WebSiteApplication.ApplicationManagementServiceReference.OperatorModel operatorModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationManagementService/AddApplication", ReplyAction="http://tempuri.org/IApplicationManagementService/AddApplicationResponse")]
        System.Threading.Tasks.Task<string> AddApplicationAsync(WebSiteApplication.ApplicationManagementServiceReference.ApplicationModel applicationModel, WebSiteApplication.ApplicationManagementServiceReference.OperatorModel operatorModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationManagementService/UpdateApplication", ReplyAction="http://tempuri.org/IApplicationManagementService/UpdateApplicationResponse")]
        bool UpdateApplication(int appId, WebSiteApplication.ApplicationManagementServiceReference.ApplicationModel appModel, string updatedBy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationManagementService/UpdateApplication", ReplyAction="http://tempuri.org/IApplicationManagementService/UpdateApplicationResponse")]
        System.Threading.Tasks.Task<bool> UpdateApplicationAsync(int appId, WebSiteApplication.ApplicationManagementServiceReference.ApplicationModel appModel, string updatedBy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationManagementService/RetrieveApplication", ReplyAction="http://tempuri.org/IApplicationManagementService/RetrieveApplicationResponse")]
        WebSiteApplication.ApplicationManagementServiceReference.ApplicationModel RetrieveApplication(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationManagementService/RetrieveApplication", ReplyAction="http://tempuri.org/IApplicationManagementService/RetrieveApplicationResponse")]
        System.Threading.Tasks.Task<WebSiteApplication.ApplicationManagementServiceReference.ApplicationModel> RetrieveApplicationAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationManagementService/DeleteApplication", ReplyAction="http://tempuri.org/IApplicationManagementService/DeleteApplicationResponse")]
        string DeleteApplication(int applicationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationManagementService/DeleteApplication", ReplyAction="http://tempuri.org/IApplicationManagementService/DeleteApplicationResponse")]
        System.Threading.Tasks.Task<string> DeleteApplicationAsync(int applicationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationManagementService/ListApplication", ReplyAction="http://tempuri.org/IApplicationManagementService/ListApplicationResponse")]
        WebSiteApplication.ApplicationManagementServiceReference.ApplicationModel[] ListApplication();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationManagementService/ListApplication", ReplyAction="http://tempuri.org/IApplicationManagementService/ListApplicationResponse")]
        System.Threading.Tasks.Task<WebSiteApplication.ApplicationManagementServiceReference.ApplicationModel[]> ListApplicationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationManagementService/ListApplicationName", ReplyAction="http://tempuri.org/IApplicationManagementService/ListApplicationNameResponse")]
        System.Data.DataSet ListApplicationName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationManagementService/ListApplicationName", ReplyAction="http://tempuri.org/IApplicationManagementService/ListApplicationNameResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListApplicationNameAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IApplicationManagementServiceChannel : WebSiteApplication.ApplicationManagementServiceReference.IApplicationManagementService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ApplicationManagementServiceClient : System.ServiceModel.ClientBase<WebSiteApplication.ApplicationManagementServiceReference.IApplicationManagementService>, WebSiteApplication.ApplicationManagementServiceReference.IApplicationManagementService {
        
        public ApplicationManagementServiceClient() {
        }
        
        public ApplicationManagementServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ApplicationManagementServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationManagementServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationManagementServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AddApplication(WebSiteApplication.ApplicationManagementServiceReference.ApplicationModel applicationModel, WebSiteApplication.ApplicationManagementServiceReference.OperatorModel operatorModel) {
            return base.Channel.AddApplication(applicationModel, operatorModel);
        }
        
        public System.Threading.Tasks.Task<string> AddApplicationAsync(WebSiteApplication.ApplicationManagementServiceReference.ApplicationModel applicationModel, WebSiteApplication.ApplicationManagementServiceReference.OperatorModel operatorModel) {
            return base.Channel.AddApplicationAsync(applicationModel, operatorModel);
        }
        
        public bool UpdateApplication(int appId, WebSiteApplication.ApplicationManagementServiceReference.ApplicationModel appModel, string updatedBy) {
            return base.Channel.UpdateApplication(appId, appModel, updatedBy);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateApplicationAsync(int appId, WebSiteApplication.ApplicationManagementServiceReference.ApplicationModel appModel, string updatedBy) {
            return base.Channel.UpdateApplicationAsync(appId, appModel, updatedBy);
        }
        
        public WebSiteApplication.ApplicationManagementServiceReference.ApplicationModel RetrieveApplication(int id) {
            return base.Channel.RetrieveApplication(id);
        }
        
        public System.Threading.Tasks.Task<WebSiteApplication.ApplicationManagementServiceReference.ApplicationModel> RetrieveApplicationAsync(int id) {
            return base.Channel.RetrieveApplicationAsync(id);
        }
        
        public string DeleteApplication(int applicationId) {
            return base.Channel.DeleteApplication(applicationId);
        }
        
        public System.Threading.Tasks.Task<string> DeleteApplicationAsync(int applicationId) {
            return base.Channel.DeleteApplicationAsync(applicationId);
        }
        
        public WebSiteApplication.ApplicationManagementServiceReference.ApplicationModel[] ListApplication() {
            return base.Channel.ListApplication();
        }
        
        public System.Threading.Tasks.Task<WebSiteApplication.ApplicationManagementServiceReference.ApplicationModel[]> ListApplicationAsync() {
            return base.Channel.ListApplicationAsync();
        }
        
        public System.Data.DataSet ListApplicationName() {
            return base.Channel.ListApplicationName();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListApplicationNameAsync() {
            return base.Channel.ListApplicationNameAsync();
        }
    }
}
