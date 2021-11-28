using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreOnline.Services;

namespace StoreOnline.Pages
{
    public class ArticleModel : MasterModel
    {
        public void OnGet(int id, string error)
        {
            if (error != null)
            {
                Error = error;
            }
            Categories = DataProvider.GetCategories();
            Article = DataProvider.GetProducts(id);
            DataProvider.IncreaseVisitorsCount(id);
            inStock = DataProvider.IsAvailable(id);
        }

        public ProductInfo Article;
        public string inStock;
        public string Error;

    }
}
