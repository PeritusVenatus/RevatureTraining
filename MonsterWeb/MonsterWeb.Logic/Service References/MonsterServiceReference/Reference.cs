﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonsterWeb.Logic.MonsterServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenderDAO", Namespace="http://schemas.datacontract.org/2004/07/MonsterApp.DataClient.Models")]
    [System.SerializableAttribute()]
    public partial class GenderDAO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="MonsterTypeDAO", Namespace="http://schemas.datacontract.org/2004/07/MonsterApp.DataClient.Models")]
    [System.SerializableAttribute()]
    public partial class MonsterTypeDAO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TitleDAO", Namespace="http://schemas.datacontract.org/2004/07/MonsterApp.DataClient.Models")]
    [System.SerializableAttribute()]
    public partial class TitleDAO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MonsterServiceReference.IMonsterService")]
    public interface IMonsterService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonsterService/GetGenders", ReplyAction="http://tempuri.org/IMonsterService/GetGendersResponse")]
        MonsterWeb.Logic.MonsterServiceReference.GenderDAO[] GetGenders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonsterService/GetGenders", ReplyAction="http://tempuri.org/IMonsterService/GetGendersResponse")]
        System.Threading.Tasks.Task<MonsterWeb.Logic.MonsterServiceReference.GenderDAO[]> GetGendersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonsterService/GetMonsterTypes", ReplyAction="http://tempuri.org/IMonsterService/GetMonsterTypesResponse")]
        MonsterWeb.Logic.MonsterServiceReference.MonsterTypeDAO[] GetMonsterTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonsterService/GetMonsterTypes", ReplyAction="http://tempuri.org/IMonsterService/GetMonsterTypesResponse")]
        System.Threading.Tasks.Task<MonsterWeb.Logic.MonsterServiceReference.MonsterTypeDAO[]> GetMonsterTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonsterService/GetTitles", ReplyAction="http://tempuri.org/IMonsterService/GetTitlesResponse")]
        MonsterWeb.Logic.MonsterServiceReference.TitleDAO[] GetTitles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonsterService/GetTitles", ReplyAction="http://tempuri.org/IMonsterService/GetTitlesResponse")]
        System.Threading.Tasks.Task<MonsterWeb.Logic.MonsterServiceReference.TitleDAO[]> GetTitlesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMonsterServiceChannel : MonsterWeb.Logic.MonsterServiceReference.IMonsterService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MonsterServiceClient : System.ServiceModel.ClientBase<MonsterWeb.Logic.MonsterServiceReference.IMonsterService>, MonsterWeb.Logic.MonsterServiceReference.IMonsterService {
        
        public MonsterServiceClient() {
        }
        
        public MonsterServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MonsterServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MonsterServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MonsterServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MonsterWeb.Logic.MonsterServiceReference.GenderDAO[] GetGenders() {
            return base.Channel.GetGenders();
        }
        
        public System.Threading.Tasks.Task<MonsterWeb.Logic.MonsterServiceReference.GenderDAO[]> GetGendersAsync() {
            return base.Channel.GetGendersAsync();
        }
        
        public MonsterWeb.Logic.MonsterServiceReference.MonsterTypeDAO[] GetMonsterTypes() {
            return base.Channel.GetMonsterTypes();
        }
        
        public System.Threading.Tasks.Task<MonsterWeb.Logic.MonsterServiceReference.MonsterTypeDAO[]> GetMonsterTypesAsync() {
            return base.Channel.GetMonsterTypesAsync();
        }
        
        public MonsterWeb.Logic.MonsterServiceReference.TitleDAO[] GetTitles() {
            return base.Channel.GetTitles();
        }
        
        public System.Threading.Tasks.Task<MonsterWeb.Logic.MonsterServiceReference.TitleDAO[]> GetTitlesAsync() {
            return base.Channel.GetTitlesAsync();
        }
    }
}