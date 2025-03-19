using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MABO20250319.AppWebMVC.Models;

[Display(Name = "Usuarios")]
public partial class User
{
    [Display(Name = "Id del usuario")]
    public int UserId { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [Display(Name = "Nombre de usuario")]
    public string Username { get; set; } = null!;
    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
    [Display(Name = "Correo electrónico")]
    public string Email { get; set; } = null!;
    [Required(ErrorMessage = "La contraseña es obligatoria.")]
    [DataType(DataType.Password)]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "La contraseña debe tener entre 5 y 50 caracteres.")]
    [Display(Name = "Contraseña")]
    public string PasswordHash { get; set; } = null!;
    [Required(ErrorMessage = "El Rol es obligatorio.")]
    [Display(Name = "Rol")]
    public string Role { get; set; } = null!;

    [NotMapped]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "La contraseña debe tener entre 5 y 50 caracteres.")]
    [Display(Name = "Confirmar Contraseña")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
    public string? ConfirmarPassword { get; set; } = null!;
}
