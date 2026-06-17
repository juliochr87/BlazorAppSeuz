using System;
using System.Collections.Generic;

namespace BlazorAppZeuz.Models.Zeuz;

public partial class Tclientesb
{
    /// <summary>
    /// Codigo del cliente
    /// </summary>
    public string ClievIdcliente { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    public string? ClievNombre { get; set; }

    /// <summary>
    /// Propietario del Negocio
    /// </summary>
    public string? ClievPropietario { get; set; }

    /// <summary>
    /// Encargado
    /// </summary>
    public string? ClievEncargado { get; set; }

    /// <summary>
    /// Direccion 2
    /// </summary>
    public string? ClievDireccion2 { get; set; }

    /// <summary>
    /// Direccion 3
    /// </summary>
    public string? ClievDireccion3 { get; set; }

    /// <summary>
    /// Direccion 4
    /// </summary>
    public string? ClievDireccion4 { get; set; }

    /// <summary>
    /// Direccion 5
    /// </summary>
    public string? ClievDireccion5 { get; set; }

    /// <summary>
    /// Telefono
    /// </summary>
    public string? ClievTelefono2 { get; set; }

    /// <summary>
    /// Telefono Movil
    /// </summary>
    public string? ClievMovil { get; set; }

    /// <summary>
    /// Estado
    /// </summary>
    public string? ClievIdestado { get; set; }

    /// <summary>
    /// Ciudad
    /// </summary>
    public string? ClievIdciudad { get; set; }

    /// <summary>
    /// Municipio
    /// </summary>
    public string? ClievIdtmunicipio { get; set; }

    /// <summary>
    /// Parroquia
    /// </summary>
    public string? ClievIdparroquia { get; set; }

    /// <summary>
    /// Urbanización
    /// </summary>
    public string? ClievIdurbanizacion { get; set; }

    /// <summary>
    /// Zona
    /// </summary>
    public string? ClievIdzona { get; set; }

    /// <summary>
    /// Grupo
    /// </summary>
    public string? ClievIdgrupo { get; set; }

    /// <summary>
    /// Subgrupo
    /// </summary>
    public string? ClievIdsubgrupo { get; set; }

    /// <summary>
    /// Cliente activo
    /// </summary>
    public int? ClienStatus { get; set; }

    /// <summary>
    /// EMAIL
    /// </summary>
    public string? ClievEmail { get; set; }

    /// <summary>
    /// Dias de despacho
    /// </summary>
    public int? ClienDiasdespacho { get; set; }

    /// <summary>
    /// Hora de despacho
    /// </summary>
    public string? ClievHoradespacho { get; set; }

    /// <summary>
    /// Grupo canal
    /// </summary>
    public string? ClievGrupcanal { get; set; }

    /// <summary>
    /// Grupo de Frecuencia
    /// </summary>
    public string? ClievGrupofrec { get; set; }

    /// <summary>
    /// Fecha de la Ultima Venta
    /// </summary>
    public DateTime? ClietUltiventa { get; set; }

    /// <summary>
    /// Latitud
    /// </summary>
    public decimal? ClienLatitud { get; set; }

    /// <summary>
    /// Longitud
    /// </summary>
    public decimal? ClienLongitud { get; set; }

    /// <summary>
    /// Codigo Postal
    /// </summary>
    public int? ClienCodigopostal { get; set; }

    /// <summary>
    /// Contribuyente especial
    /// </summary>
    public int? ClienContribuye { get; set; }

    /// <summary>
    /// Dias de crédito
    /// </summary>
    public int? ClienDiascred { get; set; }

    /// <summary>
    /// Límite de crédito
    /// </summary>
    public decimal? ClienLimicred { get; set; }

    /// <summary>
    /// Código SADA
    /// </summary>
    public string? ClievIdsada { get; set; }

    /// <summary>
    /// Código Farmaceutico
    /// </summary>
    public string? ClievCodisicm { get; set; }

    /// <summary>
    /// Licencia de licores
    /// </summary>
    public string? ClievLicencialic { get; set; }

    /// <summary>
    /// Código Empresas Polar
    /// </summary>
    public string? ClievCep { get; set; }

    /// <summary>
    /// No generar CXC en NE
    /// </summary>
    public int? ClienNocxcne { get; set; }

    /// <summary>
    /// Id Monedas Cobranza Indexada
    /// </summary>
    public string? ClievIdmonecob { get; set; }

    /// <summary>
    /// Depósito de venta
    /// </summary>
    public string? ClievIddepo { get; set; }

    /// <summary>
    /// Mínimo de venta
    /// </summary>
    public decimal? ClienMinventa { get; set; }
}
