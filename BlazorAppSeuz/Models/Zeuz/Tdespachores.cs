using System;
using System.Collections.Generic;

namespace BlazorAppZeuz.Models.Zeuz;

public partial class Tdespachores
{
    /// <summary>
    /// Id de despachador
    /// </summary>
    public string DespvIddespachador { get; set; } = null!;

    /// <summary>
    /// Nombre de despachador
    /// </summary>
    public string? DespvNombre { get; set; }

    /// <summary>
    /// Documento Identicacion de despachador
    /// </summary>
    public string? DespvDocuid { get; set; }

    /// <summary>
    /// Numero de licencia de conducir de despachador
    /// </summary>
    public string? DespvLicencia { get; set; }

    /// <summary>
    /// Grado de licencia de conducir de despachador
    /// </summary>
    public int? DespvGrado { get; set; }
}
