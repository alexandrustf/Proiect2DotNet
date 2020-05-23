using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;

namespace MyPhotos.WebApp.Pages.Photos
{
    public class FilterPhotosModel : PageModel
    {
        MyPhotosWcfClient myPhotosWcfClient = new MyPhotosWcfClient();
        public List<PhotoDTO> FilteredPhotos { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PropertySearched { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ValueSearched { get; set; }

        public FilterPhotosModel()
        {
            FilteredPhotos = new List<PhotoDTO>();
        }

        public async Task OnGetAsync()
        {
            var filteredPhotos = await myPhotosWcfClient.GetFilteredPhotosAsync(PropertySearched, ValueSearched);
            foreach (var item in filteredPhotos)
            {
                PhotoDTO pd = new PhotoDTO();
                pd.Id = item.Id;
                pd.Name = item.Name;
                pd.Path = item.Path;
                FilteredPhotos.Add(pd);
            }
        }
    }
}