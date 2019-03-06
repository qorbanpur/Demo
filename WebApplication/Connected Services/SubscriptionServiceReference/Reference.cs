﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SubscriptionServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Subscription", Namespace="http://schemas.datacontract.org/2004/07/DAL")]
    public partial class Subscription : object
    {
        
        private int CallMinutesField;
        
        private string NameField;
        
        private decimal PriceField;
        
        private decimal PriceIncVatAmountField;
        
        private System.Guid SubscriptionIdField;
        
        private System.Collections.Generic.List<SubscriptionServiceReference.UserSubscription> UserSubscriptionsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CallMinutes
        {
            get
            {
                return this.CallMinutesField;
            }
            set
            {
                this.CallMinutesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price
        {
            get
            {
                return this.PriceField;
            }
            set
            {
                this.PriceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal PriceIncVatAmount
        {
            get
            {
                return this.PriceIncVatAmountField;
            }
            set
            {
                this.PriceIncVatAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid SubscriptionId
        {
            get
            {
                return this.SubscriptionIdField;
            }
            set
            {
                this.SubscriptionIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<SubscriptionServiceReference.UserSubscription> UserSubscriptions
        {
            get
            {
                return this.UserSubscriptionsField;
            }
            set
            {
                this.UserSubscriptionsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserSubscription", Namespace="http://schemas.datacontract.org/2004/07/DAL")]
    public partial class UserSubscription : object
    {
        
        private System.Guid SubscriptionIdField;
        
        private int UserIdField;
        
        private System.Guid UserSubscriptionIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid SubscriptionId
        {
            get
            {
                return this.SubscriptionIdField;
            }
            set
            {
                this.SubscriptionIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid UserSubscriptionId
        {
            get
            {
                return this.UserSubscriptionIdField;
            }
            set
            {
                this.UserSubscriptionIdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:11012/services/subscription", ConfigurationName="SubscriptionServiceReference.ISubscriptionService")]
    public interface ISubscriptionService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:11012/services/subscription/ISubscriptionService/Add", ReplyAction="http://localhost:11012/services/subscription/ISubscriptionService/AddResponse")]
        System.Threading.Tasks.Task<SubscriptionServiceReference.Subscription> AddAsync(SubscriptionServiceReference.Subscription entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:11012/services/subscription/ISubscriptionService/Delete", ReplyAction="http://localhost:11012/services/subscription/ISubscriptionService/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:11012/services/subscription/ISubscriptionService/Get", ReplyAction="http://localhost:11012/services/subscription/ISubscriptionService/GetResponse")]
        System.Threading.Tasks.Task<SubscriptionServiceReference.Subscription> GetAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:11012/services/subscription/ISubscriptionService/GetAll", ReplyAction="http://localhost:11012/services/subscription/ISubscriptionService/GetAllResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<SubscriptionServiceReference.Subscription>> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:11012/services/subscription/ISubscriptionService/Update", ReplyAction="http://localhost:11012/services/subscription/ISubscriptionService/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(string id, SubscriptionServiceReference.Subscription entity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface ISubscriptionServiceChannel : SubscriptionServiceReference.ISubscriptionService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class SubscriptionServiceClient : System.ServiceModel.ClientBase<SubscriptionServiceReference.ISubscriptionService>, SubscriptionServiceReference.ISubscriptionService
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SubscriptionServiceClient() : 
                base(SubscriptionServiceClient.GetDefaultBinding(), SubscriptionServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ISubscriptionService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SubscriptionServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(SubscriptionServiceClient.GetBindingForEndpoint(endpointConfiguration), SubscriptionServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SubscriptionServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SubscriptionServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SubscriptionServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SubscriptionServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SubscriptionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<SubscriptionServiceReference.Subscription> AddAsync(SubscriptionServiceReference.Subscription entity)
        {
            return base.Channel.AddAsync(entity);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(string id)
        {
            return base.Channel.DeleteAsync(id);
        }
        
        public System.Threading.Tasks.Task<SubscriptionServiceReference.Subscription> GetAsync(string id)
        {
            return base.Channel.GetAsync(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<SubscriptionServiceReference.Subscription>> GetAllAsync()
        {
            return base.Channel.GetAllAsync();
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(string id, SubscriptionServiceReference.Subscription entity)
        {
            return base.Channel.UpdateAsync(id, entity);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISubscriptionService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISubscriptionService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:11012/Services/SubscriptionService.svc/Subscription.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SubscriptionServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ISubscriptionService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SubscriptionServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ISubscriptionService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ISubscriptionService,
        }
    }
}