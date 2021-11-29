using Microsoft.AspNetCore.Mvc;
using NetCoreMVCApp.Models.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCApp.ViewComponents
{
    public class MenuViewComponent: ViewComponent
    {
        // dbden çekilecek veri async olabileceğinden performans amaçlı async tercih edilir.
        // istenilen kadar parametre gönderebiliriz.
        public async Task<IViewComponentResult> InvokeAsync(string id)
        {

            var menuList = new List<MenuVM>()
            {
                new MenuVM
                {
                    Name = "Menu-1"
                },
                new MenuVM
                {
                    Name = "Menu2"
                }
            };

            await Task.FromResult(menuList);

            return View(menuList);
        }
    }
}
