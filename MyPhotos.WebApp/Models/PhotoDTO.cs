using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MyPhotos.WebApp.Models
{
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
