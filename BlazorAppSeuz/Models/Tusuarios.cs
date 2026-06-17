using System;
using System.Collections.Generic;

namespace BlazorAppSeuz.Models;

public partial class Tusuarios
{
    public string UsuavIdusuario { get; set; } = null!;

    public string? UsuavNombre { get; set; }

    public int? UsuavNivelauto { get; set; }

    public string? UsuavPassword { get; set; }

    public string? UsuavIdperfil { get; set; }

    /// <summary>
    /// Movil
    /// </summary>
    public string? UsuavMovil { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? UsuavEmail { get; set; }

    /// <summary>
    /// Tipo de usuario
    /// </summary>
    public int? UsuanTipo { get; set; }

    /// <summary>
    /// Id
    /// </summary>
    public string? UsuavId { get; set; }
}
