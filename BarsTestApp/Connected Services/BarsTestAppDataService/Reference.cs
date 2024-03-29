﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarsTestAppDataService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contract", Namespace="http://schemas.datacontract.org/2004/07/BarsTestApp.Service")]
    public partial class Contract : object
    {
        
        private int ContractNumberField;
        
        private System.DateTime CreatedOnField;
        
        private System.DateTime LastUpdateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ContractNumber
        {
            get
            {
                return this.ContractNumberField;
            }
            set
            {
                this.ContractNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedOn
        {
            get
            {
                return this.CreatedOnField;
            }
            set
            {
                this.CreatedOnField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastUpdate
        {
            get
            {
                return this.LastUpdateField;
            }
            set
            {
                this.LastUpdateField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IBarsTestAppDataService")]
    public interface IBarsTestAppDataService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBarsTestAppDataService/GetContracts", ReplyAction="http://tempuri.org/IBarsTestAppDataService/GetContractsResponse")]
        BarsTestAppDataService.Contract[] GetContracts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBarsTestAppDataService/GetContracts", ReplyAction="http://tempuri.org/IBarsTestAppDataService/GetContractsResponse")]
        System.Threading.Tasks.Task<BarsTestAppDataService.Contract[]> GetContractsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IBarsTestAppDataServiceChannel : BarsTestAppDataService.IBarsTestAppDataService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class BarsTestAppDataServiceClient : System.ServiceModel.ClientBase<BarsTestAppDataService.IBarsTestAppDataService>, BarsTestAppDataService.IBarsTestAppDataService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public BarsTestAppDataServiceClient() : 
                base(BarsTestAppDataServiceClient.GetDefaultBinding(), BarsTestAppDataServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IBarsTestAppDataService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BarsTestAppDataServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(BarsTestAppDataServiceClient.GetBindingForEndpoint(endpointConfiguration), BarsTestAppDataServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BarsTestAppDataServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(BarsTestAppDataServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BarsTestAppDataServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(BarsTestAppDataServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BarsTestAppDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public BarsTestAppDataService.Contract[] GetContracts()
        {
            return base.Channel.GetContracts();
        }
        
        public System.Threading.Tasks.Task<BarsTestAppDataService.Contract[]> GetContractsAsync()
        {
            return base.Channel.GetContractsAsync();
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IBarsTestAppDataService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IBarsTestAppDataService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:54461/BarsTestAppDataService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return BarsTestAppDataServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IBarsTestAppDataService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return BarsTestAppDataServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IBarsTestAppDataService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IBarsTestAppDataService,
        }
    }
}
