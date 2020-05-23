using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;

namespace MyPhotos.WebApp.Pages.Photos
{
    public class AllPropertiesModel : PageModel
    {
        MyPhotosWcfClient myPhotosWcfClient = new MyPhotosWcfClient();
        public List<string> Properties { get; set; }

        public AllPropertiesModel()
        {
            Properties = new List<string>();
        }

        public async Task OnGetAsync()
        {
            var properties = await myPhotosWcfClient.GetAllPropertiesAsStringsAsync();
            foreach (var item in properties)
            {
                Properties.Add(item);
            }
            Properties.Sort();
        }
    }
}