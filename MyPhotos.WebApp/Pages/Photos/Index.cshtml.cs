using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;

namespace MyPhotos.WebApp.Pages.Photos
{
    public class IndexModel : PageModel
    {
        MyPhotosWcfClient myPhotosWcfClient = new MyPhotosWcfClient();
        public List<PhotoDTO> Photos { get; set; }

        public IndexModel()
        {
            Photos = new List<PhotoDTO>();
        }

        public async Task OnGetAsync()
        {
            var posts = await myPhotosWcfClient.GetAllPhotosAsync();
            foreach (var item in posts)
            {
                PhotoDTO pd = new PhotoDTO();
                pd.Id = item.Id;
                pd.Name = item.Name;
                pd.Path = item.Path;

                Photos.Add(pd);
            }
        }
    }
}