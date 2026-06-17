using System;
using System.Collections.Generic;

namespace BlazorAppZeuz.Models.Zeuz;

public partial class Tcamiones
{
    /// <summary>
    /// Id de camión
    /// </summary>
    public string CamivIdcamion { get; set; } = null!;

    /// <summary>
    /// Descripción de camión
    /// </summary>
    public string? CamivDescripcion { get; set; }

    /// <summary>
    /// Placa de camión
    /// </summary>
    public string? CamivPlaca { get; set; }

    /// <summary>
    /// Capacidad en volumen de camión
    /// </summary>
    public decimal? CaminVolumen { get; set; }

    /// <summary>
    /// Capacidad en toneladas de camión
    /// </summary>
    public decimal? CaminToneladas { get; set; }

    /// <summary>
    /// R.I.F.
    /// </summary>
    public string? CamivRif { get; set; }

    /// <summary>
    /// Razón Social
    /// </summary>
    public string? CamivRazosoci { get; set; }

    /// <summary>
    /// ID DESPACHADOR
    /// </summary>
    public string? CamivIdidespachador { get; set; }

    /// <summary>
    /// ID TIPO DE CAMION
    /// </summary>
    public string? CamivIdtipo { get; set; }

    /// <summary>
    /// ID SEGURO
    /// </summary>
    public string? CamivIdseguro { get; set; }

    /// <summary>
    /// Id Empresa Transporte
    /// </summary>
    public string? CamivIdempresa { get; set; }

    /// <summary>
    /// Kilometraje
    /// </summary>
    public decimal? CaminKilometraje { get; set; }
}
