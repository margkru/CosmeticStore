using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreOnline.Services;

namespace StoreOnline.Pages
{
    public class AddCommentModel : PageModel
    {
        public IActionResult OnGet(int id, string text, string user)
        {
            if (text == null || user == null)
            {
                //   throw new Exception("Заполните пользователя и текст сообщения!");
                return Redirect("Article?id=" + id + "&error=Заполните поля!");
            }
            DataProvider dataProvider = new DataProvider();
            dataProvider.AddComment(id, text, user, DateTime.Now);
            return Redirect("Article?id=" + id);
        }
    }
}
