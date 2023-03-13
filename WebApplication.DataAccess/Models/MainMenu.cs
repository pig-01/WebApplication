
namespace WebApplication1.DataAccess.Models;

public class MainMenu
{
    public MainMenu()
    {
        this.Children = new List<Menu>();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public List<Menu> Children { get; set; }
}