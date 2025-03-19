using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MABO20250319.AppWebMVC.Models;

[Display(Name = "Marcas")]
public partial class Brand
{
    [Display(Name = "Id de la marca")]
    public int BrandId { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [Display(Name = "Nombre de la marca")]
    public string BrandName { get; set; } = null!;
    [Display(Name = "País de origen")]
    public string? Country { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
