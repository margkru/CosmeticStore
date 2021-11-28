using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreOnline.Services;

namespace StoreOnline.Pages
{
    public class SearchModel : MasterModel
    {
       
        public void OnGet(string query)
        {
            Categories = DataProvider.GetCategories();
            Articles = DataProvider.Search(query);
        }

        public List<ProductInfo> Articles;
    }
}
