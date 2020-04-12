using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using MyPhotos.Persistence;

namespace MyPhotos.WCF
{
    [ServiceContract]
    interface IMyPhotosWcf
    {
        [OperationContract]
        Guid CreatePhoto(string path, string name, string @event, string place, ICollection<string> persons);
        [OperationContract]
        IEnumerable<Photo> GetAllPhotos();
        [OperationContract]
        void AddCustomProperty(string id, string name, string value);
        [OperationContract]
        IEnumerable<Photo> GetFilteredPhotos(string property, string value);

        [OperationContract]
        IEnumerable<string> GetAllPropertiesAsStrings();
    }
}
