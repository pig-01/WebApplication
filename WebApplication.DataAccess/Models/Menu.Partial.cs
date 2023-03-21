using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace WebApplication1.DataAccess.Models;

[ModelMetadataType(typeof(MenuMetadata))]
public partial class Menu
{

}

public class MenuMetadata
{
    [Required]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string AuthorUrl { get; set; } = string.Empty;
    public string AuthorName { get; set; } = string.Empty;
    public string AuthorDescription { get; set; } = string.Empty;
    public string AuthorTitle { get; set; } = string.Empty;
}

