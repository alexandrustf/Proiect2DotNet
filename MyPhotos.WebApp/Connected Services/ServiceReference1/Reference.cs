﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PhotoDTO", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos.WCF", IsReference=true)]
    public partial class PhotoDTO : object
    {
        
        private System.Guid IdField;
        
        private string NameField;
        
        private string PathField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
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
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMyPhotosWcf")]
    public interface IMyPhotosWcf
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotosWcf/CreatePhoto", ReplyAction="http://tempuri.org/IMyPhotosWcf/CreatePhotoResponse")]
        System.Threading.Tasks.Task<System.Guid> CreatePhotoAsync(string path, string name, string @event, string place, string[] persons);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotosWcf/GetAllPhotos", ReplyAction="http://tempuri.org/IMyPhotosWcf/GetAllPhotosResponse")]
        System.Threading.Tasks.Task<ServiceReference1.PhotoDTO[]> GetAllPhotosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotosWcf/AddCustomProperty", ReplyAction="http://tempuri.org/IMyPhotosWcf/AddCustomPropertyResponse")]
        System.Threading.Tasks.Task AddCustomPropertyAsync(string id, string name, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotosWcf/GetFilteredPhotos", ReplyAction="http://tempuri.org/IMyPhotosWcf/GetFilteredPhotosResponse")]
        System.Threading.Tasks.Task<ServiceReference1.PhotoDTO[]> GetFilteredPhotosAsync(string property, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotosWcf/GetAllPropertiesAsStrings", ReplyAction="http://tempuri.org/IMyPhotosWcf/GetAllPropertiesAsStringsResponse")]
        System.Threading.Tasks.Task<string[]> GetAllPropertiesAsStringsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IMyPhotosWcfChannel : ServiceReference1.IMyPhotosWcf, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class MyPhotosWcfClient : System.ServiceModel.ClientBase<ServiceReference1.IMyPhotosWcf>, ServiceReference1.IMyPhotosWcf
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MyPhotosWcfClient() : 
                base(MyPhotosWcfClient.GetDefaultBinding(), MyPhotosWcfClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMyPhotosWcf.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosWcfClient(EndpointConfiguration endpointConfiguration) : 
                base(MyPhotosWcfClient.GetBindingForEndpoint(endpointConfiguration), MyPhotosWcfClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosWcfClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MyPhotosWcfClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosWcfClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MyPhotosWcfClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosWcfClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<System.Guid> CreatePhotoAsync(string path, string name, string @event, string place, string[] persons)
        {
            return base.Channel.CreatePhotoAsync(path, name, @event, place, persons);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.PhotoDTO[]> GetAllPhotosAsync()
        {
            return base.Channel.GetAllPhotosAsync();
        }
        
        public System.Threading.Tasks.Task AddCustomPropertyAsync(string id, string name, string value)
        {
            return base.Channel.AddCustomPropertyAsync(id, name, value);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.PhotoDTO[]> GetFilteredPhotosAsync(string property, string value)
        {
            return base.Channel.GetFilteredPhotosAsync(property, value);
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllPropertiesAsStringsAsync()
        {
            return base.Channel.GetAllPropertiesAsStringsAsync();
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMyPhotosWcf))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMyPhotosWcf))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MyPhotosWcfClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMyPhotosWcf);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MyPhotosWcfClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMyPhotosWcf);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMyPhotosWcf,
        }
    }
}
