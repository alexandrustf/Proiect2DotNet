﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotos.Persistence
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Photo", Namespace = "http://schemas.datacontract.org/2004/07/MyPhotos.Persistence")]
    public partial class Photo : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.Nullable<System.DateTime> CreatedAtField;

        private System.Nullable<bool> DeletedField;

        private string EventField;

        private System.Guid IdField;

        private string NameField;

        private string PathField;

        private MyPhotos.Persistence.Person[] PeopleField;

        private string PlaceField;

        private MyPhotos.Persistence.Property[] PropertiesField;

        private System.Nullable<bool> VideoField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CreatedAt
        {
            get
            {
                return this.CreatedAtField;
            }
            set
            {
                this.CreatedAtField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Deleted
        {
            get
            {
                return this.DeletedField;
            }
            set
            {
                this.DeletedField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Event
        {
            get
            {
                return this.EventField;
            }
            set
            {
                this.EventField = value;
            }
        }

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

        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyPhotos.Persistence.Person[] People
        {
            get
            {
                return this.PeopleField;
            }
            set
            {
                this.PeopleField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Place
        {
            get
            {
                return this.PlaceField;
            }
            set
            {
                this.PlaceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyPhotos.Persistence.Property[] Properties
        {
            get
            {
                return this.PropertiesField;
            }
            set
            {
                this.PropertiesField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Video
        {
            get
            {
                return this.VideoField;
            }
            set
            {
                this.VideoField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Person", Namespace = "http://schemas.datacontract.org/2004/07/MyPhotos.Persistence")]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.Guid IdField;

        private string NameField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

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
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Property", Namespace = "http://schemas.datacontract.org/2004/07/MyPhotos.Persistence")]
    public partial class Property : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.Guid IdField;

        private string NameField;

        private string ValueField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

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
        public string Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IMyPhotosWcf")]
public interface IMyPhotosWcf
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhotosWcf/CreatePhoto", ReplyAction = "http://tempuri.org/IMyPhotosWcf/CreatePhotoResponse")]
    System.Guid CreatePhoto(string path, string name, string @event, string place, string[] persons);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhotosWcf/CreatePhoto", ReplyAction = "http://tempuri.org/IMyPhotosWcf/CreatePhotoResponse")]
    System.Threading.Tasks.Task<System.Guid> CreatePhotoAsync(string path, string name, string @event, string place, string[] persons);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhotosWcf/GetAllPhotos", ReplyAction = "http://tempuri.org/IMyPhotosWcf/GetAllPhotosResponse")]
    MyPhotos.Persistence.Photo[] GetAllPhotos();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhotosWcf/GetAllPhotos", ReplyAction = "http://tempuri.org/IMyPhotosWcf/GetAllPhotosResponse")]
    System.Threading.Tasks.Task<MyPhotos.Persistence.Photo[]> GetAllPhotosAsync();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhotosWcf/AddCustomProperty", ReplyAction = "http://tempuri.org/IMyPhotosWcf/AddCustomPropertyResponse")]
    void AddCustomProperty(string id, string name, string value);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhotosWcf/AddCustomProperty", ReplyAction = "http://tempuri.org/IMyPhotosWcf/AddCustomPropertyResponse")]
    System.Threading.Tasks.Task AddCustomPropertyAsync(string id, string name, string value);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhotosWcf/GetFilteredPhotos", ReplyAction = "http://tempuri.org/IMyPhotosWcf/GetFilteredPhotosResponse")]
    MyPhotos.Persistence.Photo[] GetFilteredPhotos(string property, string value);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhotosWcf/GetFilteredPhotos", ReplyAction = "http://tempuri.org/IMyPhotosWcf/GetFilteredPhotosResponse")]
    System.Threading.Tasks.Task<MyPhotos.Persistence.Photo[]> GetFilteredPhotosAsync(string property, string value);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhotosWcf/GetAllPropertiesAsStrings", ReplyAction = "http://tempuri.org/IMyPhotosWcf/GetAllPropertiesAsStringsResponse")]
    string[] GetAllPropertiesAsStrings();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhotosWcf/GetAllPropertiesAsStrings", ReplyAction = "http://tempuri.org/IMyPhotosWcf/GetAllPropertiesAsStringsResponse")]
    System.Threading.Tasks.Task<string[]> GetAllPropertiesAsStringsAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IMyPhotosWcfChannel : IMyPhotosWcf, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class MyPhotosWcfClient : System.ServiceModel.ClientBase<IMyPhotosWcf>, IMyPhotosWcf
{

    public MyPhotosWcfClient()
    {
    }

    public MyPhotosWcfClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
    {
    }

    public MyPhotosWcfClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public MyPhotosWcfClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public MyPhotosWcfClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
    {
    }

    public System.Guid CreatePhoto(string path, string name, string @event, string place, string[] persons)
    {
        return base.Channel.CreatePhoto(path, name, @event, place, persons);
    }

    public System.Threading.Tasks.Task<System.Guid> CreatePhotoAsync(string path, string name, string @event, string place, string[] persons)
    {
        return base.Channel.CreatePhotoAsync(path, name, @event, place, persons);
    }

    public MyPhotos.Persistence.Photo[] GetAllPhotos()
    {
        return base.Channel.GetAllPhotos();
    }

    public System.Threading.Tasks.Task<MyPhotos.Persistence.Photo[]> GetAllPhotosAsync()
    {
        return base.Channel.GetAllPhotosAsync();
    }

    public void AddCustomProperty(string id, string name, string value)
    {
        base.Channel.AddCustomProperty(id, name, value);
    }

    public System.Threading.Tasks.Task AddCustomPropertyAsync(string id, string name, string value)
    {
        return base.Channel.AddCustomPropertyAsync(id, name, value);
    }

    public MyPhotos.Persistence.Photo[] GetFilteredPhotos(string property, string value)
    {
        return base.Channel.GetFilteredPhotos(property, value);
    }

    public System.Threading.Tasks.Task<MyPhotos.Persistence.Photo[]> GetFilteredPhotosAsync(string property, string value)
    {
        return base.Channel.GetFilteredPhotosAsync(property, value);
    }

    public string[] GetAllPropertiesAsStrings()
    {
        return base.Channel.GetAllPropertiesAsStrings();
    }

    public System.Threading.Tasks.Task<string[]> GetAllPropertiesAsStringsAsync()
    {
        return base.Channel.GetAllPropertiesAsStringsAsync();
    }
}
