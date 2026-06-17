using System;
using System.Collections.Generic;

namespace BlazorAppZeuz.Models.Zeuz;

public partial class TnotasentReg
{
    /// <summary>
    /// Tipo de documento
    /// </summary>
    public string VenrvTipodocu { get; set; } = null!;

    /// <summary>
    /// Numero de documento
    /// </summary>
    public string VenrvNumedocu { get; set; } = null!;

    /// <summary>
    /// Id del producto
    /// </summary>
    public string VenrvIdarticulo { get; set; } = null!;

    /// <summary>
    /// Cajas
    /// </summary>
    public decimal? VenrnCajas { get; set; }

    /// <summary>
    /// Unidades
    /// </summary>
    public int? VenrnUnidades { get; set; }

    /// <summary>
    /// Kilos
    /// </summary>
    public decimal? VenrnKilos { get; set; }

    /// <summary>
    /// Tipo de precio de venta
    /// </summary>
    public string? VenrvTipoprecio { get; set; }

    /// <summary>
    /// Precio x Cajas
    /// </summary>
    public decimal? VenrnPreciocaj { get; set; }

    /// <summary>
    /// Total bruto sin descuento ni impuesto
    /// </summary>
    public decimal? VenrnTotabrut { get; set; }

    /// <summary>
    /// % Descuento Lineal 1
    /// </summary>
    public decimal? VenrnDescuento1 { get; set; }

    /// <summary>
    /// % Descuento Lineal 2
    /// </summary>
    public decimal? VenrnDescuento2 { get; set; }

    /// <summary>
    /// Monto de descuento lineal 1
    /// </summary>
    public decimal? VenrnMontdesc1 { get; set; }

    /// <summary>
    /// Monto de descuento lineal 2
    /// </summary>
    public decimal? VenrnMontdesc2 { get; set; }

    /// <summary>
    /// Monto Desc. Global 1
    /// </summary>
    public decimal? VenrnMontdesg1 { get; set; }

    /// <summary>
    /// Monto Desc. Global 2
    /// </summary>
    public decimal? VenrnMontdesg2 { get; set; }

    /// <summary>
    /// Subtotal con descuentos sin impuesto
    /// </summary>
    public decimal? VenrnSubtotal { get; set; }

    /// <summary>
    /// Alicuota de producto
    /// </summary>
    public decimal? VenrnAlicimpu { get; set; }

    /// <summary>
    /// Total de Impuesto
    /// </summary>
    public decimal? VenrnTotaimpu { get; set; }

    /// <summary>
    /// Total con descuentos e impuestos
    /// </summary>
    public decimal? VenrnTotal { get; set; }

    /// <summary>
    /// Costo
    /// </summary>
    public decimal? VenrnCosto { get; set; }

    /// <summary>
    /// Id de carga
    /// </summary>
    public string? VenrvIdcarga { get; set; }

    /// <summary>
    /// Status del producto dentro de documento
    /// </summary>
    public string? VenrvStatus { get; set; }

    /// <summary>
    /// Código de la Caja
    /// </summary>
    public string? VenrvIdcaja { get; set; }

    /// <summary>
    /// Código del Depósito
    /// </summary>
    public string? VenrvIddepo { get; set; }

    /// <summary>
    /// Monto Utilidad
    /// </summary>
    public decimal? VenrnUtilidad { get; set; }

    /// <summary>
    /// % Utilidad
    /// </summary>
    public decimal? VenrnPorcutil { get; set; }

    /// <summary>
    /// Comentario
    /// </summary>
    public string? VenrvComentario { get; set; }

    /// <summary>
    /// Código del Cliente
    /// </summary>
    public string? VenrvIdcliente { get; set; }

    /// <summary>
    /// Código de sucursal
    /// </summary>
    public string VenrvIdsucursal { get; set; } = null!;

    /// <summary>
    /// Fecha de Emisión
    /// </summary>
    public DateTime? VenrdEmision { get; set; }

    /// <summary>
    /// Id de Vendedor
    /// </summary>
    public string? VenrvIdvendedor { get; set; }

    /// <summary>
    /// Descripcion del Articulo
    /// </summary>
    public string? VenrvDescart { get; set; }

    /// <summary>
    /// Precio x Unidad
    /// </summary>
    public decimal? VenrnPreciouni { get; set; }

    /// <summary>
    /// Factor de cambio moneda extrajera
    /// </summary>
    public decimal? VenrnCambioext { get; set; }

    /// <summary>
    /// Cajas devueltas
    /// </summary>
    public decimal? VenrnCajdv { get; set; }

    /// <summary>
    /// Unidades devueltas
    /// </summary>
    public int? VenrnUnidv { get; set; }

    /// <summary>
    /// Kilos devueltos
    /// </summary>
    public decimal? VenrnKildv { get; set; }

    /// <summary>
    /// Descuentos devueltos
    /// </summary>
    public decimal? VenrnDesdv { get; set; }

    /// <summary>
    /// Subtotal devuelto
    /// </summary>
    public decimal? VenrnSubdv { get; set; }

    /// <summary>
    /// Impuesto devuelto
    /// </summary>
    public decimal? VenrnImpdv { get; set; }

    /// <summary>
    /// Total devuelto
    /// </summary>
    public decimal? VenrnTotdv { get; set; }

    /// <summary>
    /// Cajas Factudas
    /// </summary>
    public decimal? VenrnCajasfact { get; set; }

    /// <summary>
    /// Unidades Facturadas
    /// </summary>
    public int? VenrnUnidfact { get; set; }

    /// <summary>
    /// Kilos Facturados
    /// </summary>
    public decimal? VenrnKilosfact { get; set; }

    /// <summary>
    /// Monto Lisaea 1
    /// </summary>
    public decimal? VenrnLisaea1 { get; set; }

    /// <summary>
    /// Monto Lisaea 2
    /// </summary>
    public decimal? VenrnLisaea2 { get; set; }

    /// <summary>
    /// Monto Lisaea 3
    /// </summary>
    public decimal? VenrnLisaea3 { get; set; }

    /// <summary>
    /// El usuario dejó las cajas en 0
    /// </summary>
    public int? VenrnCajascero { get; set; }

    /// <summary>
    /// Ultimo costo de compra
    /// </summary>
    public decimal? VenrnUltcoscom { get; set; }

    /// <summary>
    /// Costo actual de producto
    /// </summary>
    public decimal? VenrnCostoactu { get; set; }

    /// <summary>
    /// Factor de cambio
    /// </summary>
    public decimal? VenrnFactor { get; set; }

    /// <summary>
    /// Precio en dolares
    /// </summary>
    public decimal? VenrnPrecdolar { get; set; }

    /// <summary>
    /// Costo en dolares
    /// </summary>
    public decimal? VenrnCostdolar { get; set; }

    /// <summary>
    /// Cajas despachadas
    /// </summary>
    public decimal? VenrnCajdesp { get; set; }

    /// <summary>
    /// Unidades despachadas
    /// </summary>
    public int? VenrnUnidesp { get; set; }

    /// <summary>
    /// Kilos despachados
    /// </summary>
    public decimal? VenrnKildesp { get; set; }

    /// <summary>
    /// Costo promedio extranjero
    /// </summary>
    public decimal? VenrnCostopromext { get; set; }

    /// <summary>
    /// Factor costo promedio extranjero
    /// </summary>
    public decimal? VenrnFactorcpe { get; set; }

    /// <summary>
    /// Obsequio
    /// </summary>
    public string VenrvObsequio { get; set; } = null!;

    /// <summary>
    /// Numero de registro
    /// </summary>
    public int? VenrnNumreg { get; set; }

    public virtual Tarticulos VenrvIdarticuloNavigation { get; set; } = null!;

    public virtual Tsucursales VenrvIdsucursalNavigation { get; set; } = null!;
}
