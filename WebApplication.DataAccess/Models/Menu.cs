namespace WebApplication1.DataAccess.Models;

public class Menu
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Url { get { return _url; } set { _url = value; } }
    private string _url;
    public string Action { get { return _url.Split('/').Length == 3 ? _url.Split('/')[2] : ""; } }
    public string Controller { get { return _url.Split('/').Length == 3 ? _url.Split('/')[1] : ""; } }
    public string Area { get { return _url.Split('/').Length == 3 ? _url.Split('/')[0] : ""; } }
    public string AuthorUrl { get; set; } = string.Empty;
    public string AuthorName { get; set; } = string.Empty;
    public string AuthorDescription { get; set; } = string.Empty;
    public string AuthorTitle { get; set; } = string.Empty;

}
