using Microsoft.AspNetCore.Mvc;
using WebApplication1.DataAccess.Models;

namespace WebApplication1.ViewComponents;

[ViewComponent]
public class MenuViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        List<MainMenu> menuList = new(){
            new MainMenu(){
                Id = 1,
                Name = "Test",
                Children = new List<Menu>()
                {
                    new Menu()
                    {
                        Id = 1,
                        Name = "Test1",
                        Description = "測試1",
                        Url = "Test/Test/Test1"
                    },

                    new Menu()
                    {
                        Id = 2,
                        Name = "Test2",
                        Description = "測試2",
                        Url = "Test/Test/Test2"
                    },

                    new Menu()
                    {
                        Id = 3,
                        Name = "Test3",
                        Description = "測試3",
                        Url = "Test/Test/Test3"
                    },

                    new Menu()
                    {
                        Id = 4,
                        Name = "Test4",
                        Description = "測試4",
                        Url = "Test/Test/Test4"
                    }
                }
            },
            new MainMenu()
            {
                Id = 2,
                Name= "Admin",
                Children= new List<Menu>()
                {
                    new Menu()
                    {
                        Id = 5,
                        Name = "Admin1",
                        Description = "管理1",
                        Url = "Admin/Admin/Admin1"
                    }
                }
            }
        };

        return View(menuList);
    }
}
