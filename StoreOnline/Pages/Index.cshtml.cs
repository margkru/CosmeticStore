using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using StoreOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreOnline.Pages
{
    public class IndexModel : MasterModel
    {

        public void OnGet(string category)
        {
            Categories = DataProvider.GetCategories();
            Products = DataProvider.GetNewProducts();
        }

        public List<ProductInfo> Products;
    }

}