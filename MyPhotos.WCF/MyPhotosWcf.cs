using MyPhotos.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.WCF
{
    public class MyPhotosWcf : IMyPhotosWcf
    {
        private readonly MyPhotosDatabaseAPI myPhotosDatabaseAPI = new MyPhotosDatabaseAPI();
        public void AddCustomProperty(string id, string name, string value)
        {
            myPhotosDatabaseAPI.AddCustomProperty(id, name, value);
        }

        public Guid CreatePhoto(string path, string name, string @event, string place, ICollection<string> persons)
        {
            return myPhotosDatabaseAPI.CreatePhoto(path, name, @event, place, persons);
        }

        public IEnumerable<PhotoDTO> GetAllPhotos()
        {
           return  myPhotosDatabaseAPI.GetAllPhotos().Select(p => new PhotoDTO(p.Id, p.Path, p.Name));
        }

        public IEnumerable<string> GetAllPropertiesAsStrings()
        {
            return myPhotosDatabaseAPI.GetAllPropertiesAsStrings();
        }

        public IEnumerable<PhotoDTO> GetFilteredPhotos(string property, string value)
        {
            return myPhotosDatabaseAPI.GetFilteredPhotos(property, value).Select(p => new PhotoDTO(p.Id, p.Path, p.Name));
        }
    }

    [DataContract(IsReference = true)]
    public partial class PhotoDTO
    {
        public PhotoDTO(Guid id, string path, string name)
        {
            Id = id;
            Path = path;
            Name = name;
        }
        [DataMember]
        public System.Guid Id { get; set; }
        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
