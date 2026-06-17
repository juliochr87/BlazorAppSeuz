using System;
using System.Collections.Generic;

namespace BlazorAppZeuz.Models.Zeuz;

public partial class Tarticulos
{
    /// <summary>
    /// Id
    /// </summary>
    public string ArtvIdarticulo { get; set; } = null!;

    /// <summary>
    /// Descripción
    /// </summary>
    public string? ArtvDescart { get; set; }

    /// <summary>
    /// Descripción Detallada
    /// </summary>
    public string? ArtvDescartdeta { get; set; }

    /// <summary>
    /// Grupo
    /// </summary>
    public string? ArtvIdagrupaa { get; set; }

    /// <summary>
    /// Sug Grupo
    /// </summary>
    public string? ArtvIdagrupab { get; set; }

    /// <summary>
    /// Linea
    /// </summary>
    public string? ArtvIdagrupac { get; set; }

    /// <summary>
    /// Tipo
    /// </summary>
    public string? ArtvIdtipo { get; set; }

    /// <summary>
    /// Presentacion
    /// </summary>
    public string? ArtvIdpresen { get; set; }

    /// <summary>
    /// Marca
    /// </summary>
    public string? ArtvIdmarca { get; set; }

    /// <summary>
    /// Departamento
    /// </summary>
    public string? ArtvIddepar { get; set; }

    /// <summary>
    /// Envase
    /// </summary>
    public string? ArtvIdenvase { get; set; }

    /// <summary>
    /// Categoria
    /// </summary>
    public string? ArtvIdcategoria { get; set; }

    /// <summary>
    /// Unidades Por cajas
    /// </summary>
    public int? ArtnUnixcaja { get; set; }

    /// <summary>
    /// Contenido por unidad minima
    /// </summary>
    public decimal? ArtnContxuni { get; set; }

    /// <summary>
    /// Costo Anterior
    /// </summary>
    public decimal? ArtnCostoante { get; set; }

    /// <summary>
    /// Costo actual de producto
    /// </summary>
    public decimal? ArtnCostoactu { get; set; }

    /// <summary>
    /// Costo Promedio actual
    /// </summary>
    public decimal? ArtnCostoprom { get; set; }

    /// <summary>
    /// % IVA
    /// </summary>
    public decimal? ArtnPorciva { get; set; }

    /// <summary>
    /// Lisaea
    /// </summary>
    public decimal? ArtnLisaea { get; set; }

    /// <summary>
    /// Grado de Alcohol
    /// </summary>
    public string? ArtvGradalco { get; set; }

    /// <summary>
    /// Importado o Nacional
    /// </summary>
    public int? ArtnNacimpor { get; set; }

    /// <summary>
    /// Descripon de unidad minima
    /// </summary>
    public string? ArtvDescunimin { get; set; }

    /// <summary>
    /// Abreviación Unidad Común
    /// </summary>
    public string? ArtvDescunicom { get; set; }

    /// <summary>
    /// Volumen
    /// </summary>
    public decimal? ArtnVolumen { get; set; }

    /// <summary>
    /// Peso
    /// </summary>
    public decimal? ArtnPeso { get; set; }

    /// <summary>
    /// Producto a revisar en SADA
    /// </summary>
    public int? ArtnSada { get; set; }

    /// <summary>
    /// Descripción Corta
    /// </summary>
    public string? ArtvDescartcorta { get; set; }

    /// <summary>
    /// Registro Sanitario
    /// </summary>
    public string? ArtvRegissani { get; set; }

    /// <summary>
    /// CPE
    /// </summary>
    public string? ArtvCpe { get; set; }

    /// <summary>
    /// Especie
    /// </summary>
    public string? ArtvEspecie { get; set; }

    /// <summary>
    /// Procedencia
    /// </summary>
    public string? ArtvProcedencia { get; set; }

    /// <summary>
    /// Es por Kilos
    /// </summary>
    public int? ArtnPorkilos { get; set; }

    /// <summary>
    /// Activo
    /// </summary>
    public int? ArtnStatus { get; set; }

    /// <summary>
    /// Usa Balanza
    /// </summary>
    public int? ArtnConbalanza { get; set; }

    /// <summary>
    /// % Utilidad
    /// </summary>
    public decimal? ArtnPorcutil { get; set; }

    /// <summary>
    /// Precio por Cajas
    /// </summary>
    public decimal? ArtnPreciocaj { get; set; }

    /// <summary>
    /// Precio por Unidad
    /// </summary>
    public decimal? ArtnPreciouni { get; set; }

    /// <summary>
    /// Precio por Cajas +IVA
    /// </summary>
    public decimal? ArtnPreivacaj { get; set; }

    /// <summary>
    /// Precio por Unidad + IVA
    /// </summary>
    public decimal? ArtnPreivaund { get; set; }

    /// <summary>
    /// % Utilidad Mínima
    /// </summary>
    public decimal? ArtnPorcutilm { get; set; }

    /// <summary>
    /// Ruta de la Foto
    /// </summary>
    public string? ArtnRutafoto { get; set; }

    /// <summary>
    /// Deposito para la venta
    /// </summary>
    public string? ArtvIddepovent { get; set; }

    /// <summary>
    /// Precio libre en venta
    /// </summary>
    public int? ArtnPreciolibre { get; set; }

    /// <summary>
    /// Unidad mínima de venta
    /// </summary>
    public int? ArtnUndmin { get; set; }

    /// <summary>
    /// Id comisión cobranza vendedor
    /// </summary>
    public string? ArtvIdcomicobr { get; set; }

    /// <summary>
    /// Id Ubicacion por defecto
    /// </summary>
    public string? ArtvIdubicacion { get; set; }

    /// <summary>
    /// Unidades por display
    /// </summary>
    public int? ArtnUnidisplay { get; set; }

    /// <summary>
    /// Margen de diferencia permitida al pesar
    /// </summary>
    public decimal? ArtnMargenkilos { get; set; }

    /// <summary>
    /// Id moneda de cambio
    /// </summary>
    public string? ArtvIdmoneda { get; set; }

    /// <summary>
    /// Precio al cambio
    /// </summary>
    public decimal? ArtnPreciocam { get; set; }

    /// <summary>
    /// Costo al cambio
    /// </summary>
    public decimal? ArtnCostocam { get; set; }

    /// <summary>
    /// Impuesto al licor 2
    /// </summary>
    public decimal? ArtnLisaea2 { get; set; }

    /// <summary>
    /// Impusto IVA al licor
    /// </summary>
    public decimal? ArtnLisaea3 { get; set; }

    /// <summary>
    /// Usa Vencimiento
    /// </summary>
    public int? ArtnVence { get; set; }

    /// <summary>
    /// Usa Lotes
    /// </summary>
    public int? ArtnLotes { get; set; }

    /// <summary>
    /// Usa Seriales
    /// </summary>
    public int? ArtnSerial { get; set; }

    /// <summary>
    /// Código Farmaceutico
    /// </summary>
    public string? ArtvCodisicm { get; set; }

    /// <summary>
    /// Ultimo costo de compra
    /// </summary>
    public decimal? ArtnUltcoscom { get; set; }

    /// <summary>
    /// Inventario máximo
    /// </summary>
    public decimal? ArtnInvmax { get; set; }

    /// <summary>
    /// Inventario mínimo
    /// </summary>
    public decimal? ArtnInvmin { get; set; }

    /// <summary>
    /// Dias de inventario
    /// </summary>
    public int? ArtnDiasinv { get; set; }

    /// <summary>
    /// Ruta de la Foto
    /// </summary>
    public string? ArtvRutafoto { get; set; }

    /// <summary>
    /// Id Rubro
    /// </summary>
    public string? ArtvIdrubro { get; set; }

    /// <summary>
    /// Impuesto al licor Cambio
    /// </summary>
    public decimal? ArtnLisaeacam { get; set; }

    /// <summary>
    /// Impuesto al licor 2 Cambio
    /// </summary>
    public decimal? ArtnLisaea2cam { get; set; }

    /// <summary>
    /// Impuesto al licor 3 Cambio
    /// </summary>
    public decimal? ArtnLisaea3cam { get; set; }

    /// <summary>
    /// Usar IVA Compra
    /// </summary>
    public int? ArtnUsarivacomp { get; set; }

    /// <summary>
    /// % IVA Compra
    /// </summary>
    public decimal? ArtnPorcivac { get; set; }

    /// <summary>
    /// Precio de caja en dolares
    /// </summary>
    public decimal? ArtnPreciodol { get; set; }

    /// <summary>
    /// Costo de caja en dolares
    /// </summary>
    public decimal? ArtnCostodol { get; set; }

    /// <summary>
    /// Código Fact. Prov.
    /// </summary>
    public string? ArtvCodifacpro { get; set; }

    /// <summary>
    /// Completar descripción en venta
    /// </summary>
    public int? ArtnCompdescrip { get; set; }

    /// <summary>
    /// Compuesto fijo
    /// </summary>
    public int? ArtnCompfijo { get; set; }

    /// <summary>
    /// Id comisión cobranza supervisor
    /// </summary>
    public string? ArtvIdcomicobrs { get; set; }

    /// <summary>
    /// Facturar a costo
    /// </summary>
    public int? ArtnFactcosto { get; set; }

    /// <summary>
    /// Id comisión cobranza extra
    /// </summary>
    public string? ArtvIdcomicobre { get; set; }

    /// <summary>
    /// Id comisión cobranza gerente
    /// </summary>
    public string? ArtvIdcomicobrg { get; set; }

    /// <summary>
    /// Id comisión cobranza director
    /// </summary>
    public string? ArtvIdcomicobrd { get; set; }

    /// <summary>
    /// Cálculo por tipo de precio
    /// </summary>
    public int? ArtnIdcomicobrtp { get; set; }

    /// <summary>
    /// Cajas y unidades como kilos
    /// </summary>
    public int? ArtnCukilos { get; set; }

    /// <summary>
    /// Id artículo insumo
    /// </summary>
    public string? ArtvIdinsumo { get; set; }

    /// <summary>
    /// Costo promedio extranjero
    /// </summary>
    public decimal? ArtnCostopromext { get; set; }

    /// <summary>
    /// Factor costo promedio extranjero
    /// </summary>
    public decimal? ArtnFactorcpe { get; set; }

    /// <summary>
    /// Comisión por kilo
    /// </summary>
    public int? ArtnComikilo { get; set; }

    /// <summary>
    /// Producto Final
    /// </summary>
    public int? ArtnFprofinal { get; set; }

    /// <summary>
    /// Tipo final
    /// </summary>
    public int? ArtnFtipofinal { get; set; }

    /// <summary>
    /// Fase de producción
    /// </summary>
    public int? ArtnFfase { get; set; }

    /// <summary>
    /// Receta
    /// </summary>
    public int? ArtnFreceta { get; set; }

    /// <summary>
    /// Prefijo de Lote
    /// </summary>
    public string? ArtvFloteprefijo { get; set; }

    /// <summary>
    /// Máscara fecha de Lote
    /// </summary>
    public string? ArtvFlotefechamasc { get; set; }

    /// <summary>
    /// Sufijo de Lote
    /// </summary>
    public string? ArtvFlotesufijo { get; set; }

    /// <summary>
    /// Dias de vencimiento del lote
    /// </summary>
    public int? ArtnFlotediasven { get; set; }

    /// <summary>
    /// Medida
    /// </summary>
    public string? ArtvMpmedida { get; set; }

    /// <summary>
    /// Und minima como multiplo
    /// </summary>
    public int? ArtnUndmxm { get; set; }

    /// <summary>
    /// No permitir poder facturarlo
    /// </summary>
    public int? ArtnNofact { get; set; }

    /// <summary>
    /// Id comisión ventas vendedor
    /// </summary>
    public string? ArtvIdcomivent { get; set; }

    /// <summary>
    /// Cajas para precio mayor
    /// </summary>
    public decimal? ArtnCajamayor { get; set; }

    /// <summary>
    /// Tipo de precio para Mayor
    /// </summary>
    public string? ArtvTipopmayor { get; set; }

    /// <summary>
    /// Deposito para la venta
    /// </summary>
    public string? ArtvIddepocomp { get; set; }

    /// <summary>
    /// Nacional importado Licor
    /// </summary>
    public int? ArtnGradnacimpor { get; set; }

    public virtual ICollection<TnotasentReg> TnotasentReg { get; set; } = new List<TnotasentReg>();
}
