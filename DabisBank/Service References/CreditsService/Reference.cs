﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DabisBank.CreditsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PaymentModel", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class PaymentModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreditField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Credit {
            get {
                return this.CreditField;
            }
            set {
                if ((object.ReferenceEquals(this.CreditField, value) != true)) {
                    this.CreditField = value;
                    this.RaisePropertyChanged("Credit");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CreditsService.CreditsSoap")]
    public interface CreditsSoap {
        
        // CODEGEN: Generating message contract since element name credit from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/isValid", ReplyAction="*")]
        DabisBank.CreditsService.isValidResponse isValid(DabisBank.CreditsService.isValidRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/isValid", ReplyAction="*")]
        System.Threading.Tasks.Task<DabisBank.CreditsService.isValidResponse> isValidAsync(DabisBank.CreditsService.isValidRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class isValidRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="isValid", Namespace="http://tempuri.org/", Order=0)]
        public DabisBank.CreditsService.isValidRequestBody Body;
        
        public isValidRequest() {
        }
        
        public isValidRequest(DabisBank.CreditsService.isValidRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class isValidRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DabisBank.CreditsService.PaymentModel credit;
        
        public isValidRequestBody() {
        }
        
        public isValidRequestBody(DabisBank.CreditsService.PaymentModel credit) {
            this.credit = credit;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class isValidResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="isValidResponse", Namespace="http://tempuri.org/", Order=0)]
        public DabisBank.CreditsService.isValidResponseBody Body;
        
        public isValidResponse() {
        }
        
        public isValidResponse(DabisBank.CreditsService.isValidResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class isValidResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool isValidResult;
        
        public isValidResponseBody() {
        }
        
        public isValidResponseBody(bool isValidResult) {
            this.isValidResult = isValidResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CreditsSoapChannel : DabisBank.CreditsService.CreditsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreditsSoapClient : System.ServiceModel.ClientBase<DabisBank.CreditsService.CreditsSoap>, DabisBank.CreditsService.CreditsSoap {
        
        public CreditsSoapClient() {
        }
        
        public CreditsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CreditsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreditsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreditsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DabisBank.CreditsService.isValidResponse DabisBank.CreditsService.CreditsSoap.isValid(DabisBank.CreditsService.isValidRequest request) {
            return base.Channel.isValid(request);
        }
        
        public bool isValid(DabisBank.CreditsService.PaymentModel credit) {
            DabisBank.CreditsService.isValidRequest inValue = new DabisBank.CreditsService.isValidRequest();
            inValue.Body = new DabisBank.CreditsService.isValidRequestBody();
            inValue.Body.credit = credit;
            DabisBank.CreditsService.isValidResponse retVal = ((DabisBank.CreditsService.CreditsSoap)(this)).isValid(inValue);
            return retVal.Body.isValidResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DabisBank.CreditsService.isValidResponse> DabisBank.CreditsService.CreditsSoap.isValidAsync(DabisBank.CreditsService.isValidRequest request) {
            return base.Channel.isValidAsync(request);
        }
        
        public System.Threading.Tasks.Task<DabisBank.CreditsService.isValidResponse> isValidAsync(DabisBank.CreditsService.PaymentModel credit) {
            DabisBank.CreditsService.isValidRequest inValue = new DabisBank.CreditsService.isValidRequest();
            inValue.Body = new DabisBank.CreditsService.isValidRequestBody();
            inValue.Body.credit = credit;
            return ((DabisBank.CreditsService.CreditsSoap)(this)).isValidAsync(inValue);
        }
    }
}