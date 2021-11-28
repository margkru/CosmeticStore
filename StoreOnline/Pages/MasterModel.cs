using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreOnline.Pages
{
    public class MasterModel : PageModel
    {
        public MasterModel()
        {
            DataProvider = new DataProvider();
        }

        public DataProvider DataProvider;
        public List<CategoryInfo> Categories;
    }
}
