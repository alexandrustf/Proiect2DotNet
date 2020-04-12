using MyPhotos.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Photo> GetAllPhotos()
        {
            return myPhotosDatabaseAPI.GetAllPhotos();
        }

        public IEnumerable<string> GetAllPropertiesAsStrings()
        {
            return myPhotosDatabaseAPI.GetAllPropertiesAsStrings();
        }

        public IEnumerable<Photo> GetFilteredPhotos(string property, string value)
        {
            return myPhotosDatabaseAPI.GetFilteredPhotos(property, value);
        }
    }
}
