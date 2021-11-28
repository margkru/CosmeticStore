using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreOnline.Services
{
    public class DataProvider
    {
        static List<CategoryInfo> Category;
        static List<ProductInfo> Product;

        static DataProvider()
        {
            Category = new List<CategoryInfo>
            {
                new CategoryInfo {
                    Title = "Шампуни",
                    Alias = "Shampoo"
                },
                new CategoryInfo {
                    Title = "Макияж",
                    Alias = "Makeup"
                },
                new CategoryInfo {
                    Title = "Уход",
                    Alias = "Care"
                }
            };

            Product = new List<ProductInfo> {
                new ProductInfo {
                    Id=1,
                    Category = Category[0],
                    Title = "CAUDALIE",
                    Announce = "Мягкий шампунь для волос",
                    Ingredients = "Состав шампуня",
                    isAvailable = false,
                    ViewCount = 1,
                    Cost = 1180,
                    PublicationDate = new DateTime(2021,7,23),
                    Comments = new List<CommentInfo>()
                },
                new ProductInfo {
                    Id=2,
                    Category = Category[1],
                    Title = "GUERLAIN",
                    Announce = "KissKiss Помада для губ",
                    Ingredients = "Состав помады",
                    isAvailable = true,
                    ViewCount = 1,
                    Cost = 1560,
                    PublicationDate = new DateTime(2021,7,23),
                    Comments = new List<CommentInfo>()
                },
                new ProductInfo {
                    Id=3,
                    Category = Category[2],
                    Title = "CLINIQUE",
                    Announce = "Отшелушивающий лосьон для склонной к сухости кожи",
                    Ingredients = "Состав лосьона",
                    isAvailable = true,
                    ViewCount = 1,
                    Cost = 1068,
                    PublicationDate = new DateTime(2021,7,23),
                    Comments = new List<CommentInfo>()
                },
                new ProductInfo {
                    Id=3,
                    Category = Category[2],
                    Title = "CLINIQUE",
                    Announce = "Отшелушивающий лосьон для комбинированной кожи",
                    Ingredients = "Состав лосьона",
                    isAvailable = true,
                    ViewCount = 1,
                    Cost = 1068,
                    PublicationDate = new DateTime(2021,7,23),
                    Comments = new List<CommentInfo>()
                }
            };
        }

        public List<ProductInfo> GetNewProducts()
        {
            List<ProductInfo> newProducts = new List<ProductInfo>();
            foreach (ProductInfo product in Product)
            {                
                if ((DateTime.Now - product.PublicationDate).TotalDays <= 7)
                    newProducts.Add(product);
            }
            return newProducts;
        }

        internal void AddComment(int id, string text, string user, DateTime date)
        {
            foreach (ProductInfo product in Product)
            {
                if (product.Id == id)
                {
                    CommentInfo comment = new CommentInfo();
                    comment.Text = text;
                    comment.Author = user;
                    comment.Date = date;
                    product.Comments.Add(comment);
                    break;
                }
            }
        }

        public string IsAvailable(int id)
        {
            return Product.FirstOrDefault(x => x.Id == id).isAvailable ? "Есть в наличии" : "Нет в наличии";
        }

        public List<ProductInfo> Search(string query)
        {
            List<ProductInfo> filteredProducts = new List<ProductInfo>();
            foreach (ProductInfo product in Product)
            {
                if (product.Title.IndexOf(query) >= 0 || product.Announce.IndexOf(query) >= 0)
                {
                    filteredProducts.Add(product);
                }
            }

            return filteredProducts;
        }

        public void IncreaseVisitorsCount(int id)
        {
            Product.FirstOrDefault(x => x.Id == id).ViewCount++;
        }

        public List<ProductInfo> GetProducts(string category)
        {
            if (category == null)
            {
                return Product;
            }

            List<ProductInfo> filteredProducts = new List<ProductInfo>();
            foreach (ProductInfo product in Product)
            {
                if (product.Category.Alias == category)
                {
                    filteredProducts.Add(product);
                }
            }

            return filteredProducts;
        }

        public ProductInfo GetProducts(int id)
        {
            return Product.FirstOrDefault(x => x.Id == id);
        }

        public List<CategoryInfo> GetCategories()
        {
            return Category;
        }
    }

    public class ProductInfo
    {
        public CategoryInfo Category;
        public string Title;
        public string Announce;
        public string Ingredients;
        public int Id;
        public int ViewCount;
        public int Cost;
        public bool isAvailable;
        public DateTime PublicationDate;
        public List<CommentInfo> Comments;
    }

    public class CategoryInfo
    {
        public string Title;
        public string Alias;

    }

    public class CommentInfo
    {
        public int Id;
        public string Text;
        public string Author;
        public DateTime Date;
    }
}
