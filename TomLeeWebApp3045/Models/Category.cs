using System.ComponentModel.DataAnnotations;

namespace TomLeeWebApp3045.Models;
public class Category
{
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

}