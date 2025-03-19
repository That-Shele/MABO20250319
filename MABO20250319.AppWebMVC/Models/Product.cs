using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MABO20250319.AppWebMVC.Models;

[Display(Name = "Productos")]
public partial class Product
{
    [Display(Name = "Id del producto")]
    public int ProductId { get; set; }
    [Display(Name = "Nombre del producto")]
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string ProductName { get; set; } = null!;
    [Display(Name = "Descripcion")]
    public string? Description { get; set; }
    [Required(ErrorMessage = "El precio es obligatorio.")]
    [Display(Name = "Precio")]
    public decimal Price { get; set; }
    [Required(ErrorMessage = "Seleccione una categoría.")]
    [Display(Name = "Categoría")]
    public int? CategoryId { get; set; }
    [Required(ErrorMessage = "Seleccione una marca.")]
    [Display(Name = "Marca")]
    public int? BrandId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Category? Category { get; set; }
}
