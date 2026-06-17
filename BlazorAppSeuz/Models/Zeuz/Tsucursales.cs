using System;
using System.Collections.Generic;

namespace BlazorAppZeuz.Models.Zeuz;

public partial class Tsucursales
{
    /// <summary>
    /// Código de sucursal
    /// </summary>
    public string SucuvIdsucursal { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    public string? SucuvNombre { get; set; }

    /// <summary>
    /// R.I.F
    /// </summary>
    public string? SucuvRif { get; set; }

    /// <summary>
    /// Nombre Fiscal
    /// </summary>
    public string? SucuvNombfiscal { get; set; }

    /// <summary>
    /// Dirección1
    /// </summary>
    public string? SucuvDireccion1 { get; set; }

    /// <summary>
    /// Dirección2
    /// </summary>
    public string? SucuvDireccion2 { get; set; }

    /// <summary>
    /// Id Empresa
    /// </summary>
    public string? SucuvIdempresa { get; set; }

    public virtual ICollection<TnotasentEnc> TnotasentEnc { get; set; } = new List<TnotasentEnc>();

    public virtual ICollection<TnotasentReg> TnotasentReg { get; set; } = new List<TnotasentReg>();
}
