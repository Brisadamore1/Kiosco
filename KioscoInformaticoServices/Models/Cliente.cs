using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KioscoInformaticoServices.Models;

public partial class Cliente
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El campo nombre es obligatorio.")]
    public string Nombre { get; set; } = null!;
    [Required(ErrorMessage = "El campo direccion es obligatorio.")]
    public string Direccion { get; set; } = null!;
    [Required(ErrorMessage = "El campo telefono es obligatorio.")]
    public string Telefonos { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }
    [Required(ErrorMessage = "El campo localidad es obligatorio.")]
    public int? LocalidadId { get; set; }

    public virtual Localidad? Localidad { get; set; }

    public bool Eliminado { get; set; } = false;

}
