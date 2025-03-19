using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MABO20250319.AppWebMVC.Models;

[Display(Name = "Categorias")]
public partial class Category
{
    [Display(Name = "Id de la categoría")]
    public int CategoryId { get; set; }
    [Display(Name = "Nombre de la categoría")]
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string CategoryName { get; set; } = null!;
    [Display(Name = "Descripcion de la categoría")]
    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
