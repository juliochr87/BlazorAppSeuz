using System;
using System.Collections.Generic;

namespace BlazorAppZeuz.Models.Zeuz;

public partial class TnotasentEnc
{
    /// <summary>
    /// Tipo de documento
    /// </summary>
    public string VenvTipodocu { get; set; } = null!;

    /// <summary>
    /// Numero de documento
    /// </summary>
    public string VenvNumedocu { get; set; } = null!;

    /// <summary>
    /// Código del Cliente
    /// </summary>
    public string? VenvIdcliente { get; set; }

    /// <summary>
    /// Código de sucursal
    /// </summary>
    public string VenvIdsucursal { get; set; } = null!;

    /// <summary>
    /// Id de Vendedor
    /// </summary>
    public string? VenvIdvendedor { get; set; }

    /// <summary>
    /// Código de la Caja
    /// </summary>
    public string? VenvIdpvesta { get; set; }

    /// <summary>
    /// Rif del Cliente
    /// </summary>
    public string? VenvRif { get; set; }

    /// <summary>
    /// Cédula del Cliente
    /// </summary>
    public string? VenvCedula { get; set; }

    /// <summary>
    /// Razón Social del Cliente
    /// </summary>
    public string? VenvRazosoci { get; set; }

    /// <summary>
    /// Fecha del documento
    /// </summary>
    public DateTime? VendEmision { get; set; }

    /// <summary>
    /// Hora de Emisión
    /// </summary>
    public string? VenvHora { get; set; }

    /// <summary>
    /// Dias de credito de la factura
    /// </summary>
    public int? VennDiascred { get; set; }

    /// <summary>
    /// Fecha de vencimiento
    /// </summary>
    public DateTime? VendVencimiento { get; set; }

    /// <summary>
    /// Total bruto sin descuento ni impuesto
    /// </summary>
    public decimal? VennTotalbruto { get; set; }

    /// <summary>
    /// Porcentaje de descuento global 1
    /// </summary>
    public decimal? VennPorcdesc1 { get; set; }

    /// <summary>
    /// Porcentaje de descuento global 2
    /// </summary>
    public decimal? VennPorcdesc2 { get; set; }

    /// <summary>
    /// Monto de descuento Global 1
    /// </summary>
    public decimal? VennMontodesc1 { get; set; }

    /// <summary>
    /// Monto de descuento Global 2
    /// </summary>
    public decimal? VennMontodesc2 { get; set; }

    /// <summary>
    /// Subtotal con descuentos sin impuesto
    /// </summary>
    public decimal? VennSubtotal { get; set; }

    /// <summary>
    /// Alicuota de impuesto
    /// </summary>
    public decimal? VennImpualic { get; set; }

    /// <summary>
    /// Total de impuesto
    /// </summary>
    public decimal? VennTotaimpu { get; set; }

    /// <summary>
    /// Monto del Gravado
    /// </summary>
    public decimal? VennGravado { get; set; }

    /// <summary>
    /// Monto del exento
    /// </summary>
    public decimal? VennExento { get; set; }

    /// <summary>
    /// Monto Lisaea 1
    /// </summary>
    public decimal? VennLisaea1 { get; set; }

    /// <summary>
    /// Monto Lisaea 2
    /// </summary>
    public decimal? VennLisaea2 { get; set; }

    /// <summary>
    /// Total documento con descuentos e impuesto
    /// </summary>
    public decimal? VennTotal { get; set; }

    /// <summary>
    /// Costo del documento
    /// </summary>
    public decimal? VennCosto { get; set; }

    /// <summary>
    /// Comentario del Documento
    /// </summary>
    public string? VenvComentario { get; set; }

    /// <summary>
    /// Id de carga
    /// </summary>
    public string? VenvIdcarga { get; set; }

    /// <summary>
    /// Status de documento
    /// </summary>
    public string? VenvStatus { get; set; }

    /// <summary>
    /// Latitud de Factura
    /// </summary>
    public decimal? VennLatitud { get; set; }

    /// <summary>
    /// Longitud de Factura
    /// </summary>
    public decimal? VennLongitud { get; set; }

    /// <summary>
    /// Numero de Control
    /// </summary>
    public int? VennControl { get; set; }

    /// <summary>
    /// Codigo del Usuario
    /// </summary>
    public string? VenvIdusuario { get; set; }

    /// <summary>
    /// Motivo de Anulación
    /// </summary>
    public string? VenvMotivonula { get; set; }

    /// <summary>
    /// Modo devolución de la factura (TOTAL O PARCIAL)
    /// </summary>
    public string? VenvDevuelta { get; set; }

    /// <summary>
    /// Documento Impreso
    /// </summary>
    public int? VennImpresa { get; set; }

    /// <summary>
    /// Monto Afectado
    /// </summary>
    public decimal? VennMontafec { get; set; }

    /// <summary>
    /// Origen del Documento
    /// </summary>
    public string? VenvOrigen { get; set; }

    /// <summary>
    /// Documento Afectado
    /// </summary>
    public string? VenvFactafec { get; set; }

    /// <summary>
    /// Fecha de documento afectado
    /// </summary>
    public DateTime? VendFechafec { get; set; }

    /// <summary>
    /// Documento cancelado sin recibo
    /// </summary>
    public int? VennDocsinrec { get; set; }

    /// <summary>
    /// Status Administrativo
    /// </summary>
    public string? VenvStatusadm { get; set; }

    /// <summary>
    /// id Motivo
    /// </summary>
    public string? VenvIdmotivodev { get; set; }

    /// <summary>
    /// Monto Lisaea 3
    /// </summary>
    public string? VennLisaea3 { get; set; }

    /// <summary>
    /// Factor de cambio
    /// </summary>
    public decimal? VennFactor { get; set; }

    /// <summary>
    /// Número de pedido
    /// </summary>
    public string? VenvPedido { get; set; }

    /// <summary>
    /// Id Equipo
    /// </summary>
    public string? VenvIdequipo { get; set; }

    /// <summary>
    /// Serie de impresion
    /// </summary>
    public string? VenvIdserie { get; set; }

    /// <summary>
    /// Costo promedio extranjero
    /// </summary>
    public decimal? VennCostopromext { get; set; }

    /// <summary>
    /// Id Moneda
    /// </summary>
    public string? VenvIdmoneda { get; set; }

    public virtual Tsucursales VenvIdsucursalNavigation { get; set; } = null!;
}
