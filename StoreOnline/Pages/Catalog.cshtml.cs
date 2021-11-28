using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreOnline.Services;

namespace StoreOnline.Pages
{
    public class CatalogModel : MasterModel
    {

        public void OnGet(string category)
        {
            Categories = DataProvider.GetCategories();
            Products = DataProvider.GetProducts(category);
        }

        public List<ProductInfo> Products;
    }
}
