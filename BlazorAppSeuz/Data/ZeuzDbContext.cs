using System;
using System.Collections.Generic;
using BlazorAppZeuz.Models.Zeuz;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace BlazorAppZeuz.Data;

public partial class ZeuzDbContext : DbContext
{
    public ZeuzDbContext()
    {
    }

    public ZeuzDbContext(DbContextOptions<ZeuzDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tarticulos> Tarticulos { get; set; }

    public virtual DbSet<Tcamiones> Tcamiones { get; set; }

    public virtual DbSet<Tclientesb> Tclientesb { get; set; }

    public virtual DbSet<TnotasentEnc> TnotasentEnc { get; set; }

    public virtual DbSet<TnotasentReg> TnotasentReg { get; set; }

    public virtual DbSet<Tsucursales> Tsucursales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=127.0.0.1;port=3307;database=SEUZ;user=root;password=Admin12345", Microsoft.EntityFrameworkCore.ServerVersion.Parse("12.2.2-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_uca1400_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Tarticulos>(entity =>
        {
            entity.HasKey(e => e.ArtvIdarticulo).HasName("PRIMARY");

            entity
                .ToTable("tarticulos")
                .HasCharSet("latin1")
                .UseCollation("latin1_spanish_ci");

            entity.HasIndex(e => e.ArtvDescart, "Descripcion");

            entity.HasIndex(e => new { e.ArtvIdarticulo, e.ArtvDescart }, "Dual1");

            entity.HasIndex(e => e.ArtvIdagrupaa, "IdAgrupaa");

            entity.HasIndex(e => new { e.ArtvIdagrupaa, e.ArtvIdagrupab }, "IdAgrupab");

            entity.HasIndex(e => new { e.ArtvIdagrupaa, e.ArtvIdagrupab, e.ArtvIdagrupac }, "IdAgrupac");

            entity.HasIndex(e => e.ArtvIdarticulo, "IdArticulo");

            entity.HasIndex(e => e.ArtvIdpresen, "tpresentacion_tarticulos_fk");

            entity.Property(e => e.ArtvIdarticulo)
                .HasMaxLength(10)
                .HasComment("Id")
                .HasColumnName("ARTV_IDARTICULO");
            entity.Property(e => e.ArtnCajamayor)
                .HasPrecision(24, 3)
                .HasComment("Cajas para precio mayor")
                .HasColumnName("ARTN_CAJAMAYOR");
            entity.Property(e => e.ArtnComikilo)
                .HasDefaultValueSql("'0'")
                .HasComment("Comisión por kilo")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_COMIKILO");
            entity.Property(e => e.ArtnCompdescrip)
                .HasDefaultValueSql("'0'")
                .HasComment("Completar descripción en venta")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_COMPDESCRIP");
            entity.Property(e => e.ArtnCompfijo)
                .HasDefaultValueSql("'0'")
                .HasComment("Compuesto fijo")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_COMPFIJO");
            entity.Property(e => e.ArtnConbalanza)
                .HasComment("Usa Balanza")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_CONBALANZA");
            entity.Property(e => e.ArtnContxuni)
                .HasPrecision(15, 4)
                .HasComment("Contenido por unidad minima")
                .HasColumnName("ARTN_CONTXUNI");
            entity.Property(e => e.ArtnCostoactu)
                .HasPrecision(22, 4)
                .HasComment("Costo actual de producto")
                .HasColumnName("ARTN_COSTOACTU");
            entity.Property(e => e.ArtnCostoante)
                .HasPrecision(22, 4)
                .HasComment("Costo Anterior")
                .HasColumnName("ARTN_COSTOANTE");
            entity.Property(e => e.ArtnCostocam)
                .HasPrecision(22, 4)
                .HasComment("Costo al cambio")
                .HasColumnName("ARTN_COSTOCAM");
            entity.Property(e => e.ArtnCostodol)
                .HasPrecision(10)
                .HasDefaultValueSql("'0'")
                .HasComment("Costo de caja en dolares")
                .HasColumnName("ARTN_COSTODOL");
            entity.Property(e => e.ArtnCostoprom)
                .HasPrecision(22, 4)
                .HasComment("Costo Promedio actual")
                .HasColumnName("ARTN_COSTOPROM");
            entity.Property(e => e.ArtnCostopromext)
                .HasPrecision(22, 10)
                .HasDefaultValueSql("'0.0000000000'")
                .HasComment("Costo promedio extranjero")
                .HasColumnName("ARTN_COSTOPROMEXT");
            entity.Property(e => e.ArtnCukilos)
                .HasDefaultValueSql("'0'")
                .HasComment("Cajas y unidades como kilos")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_CUKILOS");
            entity.Property(e => e.ArtnDiasinv)
                .HasDefaultValueSql("'0'")
                .HasComment("Dias de inventario")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_DIASINV");
            entity.Property(e => e.ArtnFactcosto)
                .HasDefaultValueSql("'0'")
                .HasComment("Facturar a costo")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_FACTCOSTO");
            entity.Property(e => e.ArtnFactorcpe)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Factor costo promedio extranjero")
                .HasColumnName("ARTN_FACTORCPE");
            entity.Property(e => e.ArtnFfase)
                .HasDefaultValueSql("'0'")
                .HasComment("Fase de producción")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_FFASE");
            entity.Property(e => e.ArtnFlotediasven)
                .HasDefaultValueSql("'0'")
                .HasComment("Dias de vencimiento del lote")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_FLOTEDIASVEN");
            entity.Property(e => e.ArtnFprofinal)
                .HasDefaultValueSql("'0'")
                .HasComment("Producto Final")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_FPROFINAL");
            entity.Property(e => e.ArtnFreceta)
                .HasDefaultValueSql("'0'")
                .HasComment("Receta")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_FRECETA");
            entity.Property(e => e.ArtnFtipofinal)
                .HasDefaultValueSql("'0'")
                .HasComment("Tipo final")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_FTIPOFINAL");
            entity.Property(e => e.ArtnGradnacimpor)
                .HasDefaultValueSql("'1'")
                .HasComment("Nacional importado Licor")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_GRADNACIMPOR");
            entity.Property(e => e.ArtnIdcomicobrtp)
                .HasDefaultValueSql("'0'")
                .HasComment("Cálculo por tipo de precio")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_IDCOMICOBRTP");
            entity.Property(e => e.ArtnInvmax)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Inventario máximo")
                .HasColumnName("ARTN_INVMAX");
            entity.Property(e => e.ArtnInvmin)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Inventario mínimo")
                .HasColumnName("ARTN_INVMIN");
            entity.Property(e => e.ArtnLisaea)
                .HasPrecision(22, 4)
                .HasComment("Lisaea")
                .HasColumnName("ARTN_LISAEA");
            entity.Property(e => e.ArtnLisaea2)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Impuesto al licor 2")
                .HasColumnName("ARTN_LISAEA2");
            entity.Property(e => e.ArtnLisaea2cam)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Impuesto al licor 2 Cambio")
                .HasColumnName("ARTN_LISAEA2CAM");
            entity.Property(e => e.ArtnLisaea3)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Impusto IVA al licor")
                .HasColumnName("ARTN_LISAEA3");
            entity.Property(e => e.ArtnLisaea3cam)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Impuesto al licor 3 Cambio")
                .HasColumnName("ARTN_LISAEA3CAM");
            entity.Property(e => e.ArtnLisaeacam)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Impuesto al licor Cambio")
                .HasColumnName("ARTN_LISAEACAM");
            entity.Property(e => e.ArtnLotes)
                .HasDefaultValueSql("'0'")
                .HasComment("Usa Lotes")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_LOTES");
            entity.Property(e => e.ArtnMargenkilos)
                .HasPrecision(22, 4)
                .HasComment("Margen de diferencia permitida al pesar")
                .HasColumnName("ARTN_MARGENKILOS");
            entity.Property(e => e.ArtnNacimpor)
                .HasComment("Importado o Nacional")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_NACIMPOR");
            entity.Property(e => e.ArtnNofact)
                .HasComment("No permitir poder facturarlo")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_NOFACT");
            entity.Property(e => e.ArtnPeso)
                .HasPrecision(22, 3)
                .HasComment("Peso")
                .HasColumnName("ARTN_PESO");
            entity.Property(e => e.ArtnPorciva)
                .HasPrecision(5, 2)
                .HasComment("% IVA")
                .HasColumnName("ARTN_PORCIVA");
            entity.Property(e => e.ArtnPorcivac)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("% IVA Compra")
                .HasColumnName("ARTN_PORCIVAC");
            entity.Property(e => e.ArtnPorcutil)
                .HasPrecision(22, 4)
                .HasComment("% Utilidad")
                .HasColumnName("ARTN_PORCUTIL");
            entity.Property(e => e.ArtnPorcutilm)
                .HasPrecision(22, 4)
                .HasComment("% Utilidad Mínima")
                .HasColumnName("ARTN_PORCUTILM");
            entity.Property(e => e.ArtnPorkilos)
                .HasComment("Es por Kilos")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_PORKILOS");
            entity.Property(e => e.ArtnPreciocaj)
                .HasPrecision(22, 4)
                .HasComment("Precio por Cajas")
                .HasColumnName("ARTN_PRECIOCAJ");
            entity.Property(e => e.ArtnPreciocam)
                .HasPrecision(22, 4)
                .HasComment("Precio al cambio")
                .HasColumnName("ARTN_PRECIOCAM");
            entity.Property(e => e.ArtnPreciodol)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Precio de caja en dolares")
                .HasColumnName("ARTN_PRECIODOL");
            entity.Property(e => e.ArtnPreciolibre)
                .HasDefaultValueSql("'0'")
                .HasComment("Precio libre en venta")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_PRECIOLIBRE");
            entity.Property(e => e.ArtnPreciouni)
                .HasPrecision(22, 4)
                .HasComment("Precio por Unidad")
                .HasColumnName("ARTN_PRECIOUNI");
            entity.Property(e => e.ArtnPreivacaj)
                .HasPrecision(22, 4)
                .HasComment("Precio por Cajas +IVA")
                .HasColumnName("ARTN_PREIVACAJ");
            entity.Property(e => e.ArtnPreivaund)
                .HasPrecision(22, 4)
                .HasComment("Precio por Unidad + IVA")
                .HasColumnName("ARTN_PREIVAUND");
            entity.Property(e => e.ArtnRutafoto)
                .HasMaxLength(100)
                .HasComment("Ruta de la Foto")
                .HasColumnName("ARTN_RUTAFOTO");
            entity.Property(e => e.ArtnSada)
                .HasComment("Producto a revisar en SADA")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_SADA");
            entity.Property(e => e.ArtnSerial)
                .HasDefaultValueSql("'0'")
                .HasComment("Usa Seriales")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_SERIAL");
            entity.Property(e => e.ArtnStatus)
                .HasComment("Activo")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_STATUS");
            entity.Property(e => e.ArtnUltcoscom)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Ultimo costo de compra")
                .HasColumnName("ARTN_ULTCOSCOM");
            entity.Property(e => e.ArtnUndmin)
                .HasDefaultValueSql("'1'")
                .HasComment("Unidad mínima de venta")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_UNDMIN");
            entity.Property(e => e.ArtnUndmxm)
                .HasComment("Und minima como multiplo")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_UNDMXM");
            entity.Property(e => e.ArtnUnidisplay)
                .HasComment("Unidades por display")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_UNIDISPLAY");
            entity.Property(e => e.ArtnUnixcaja)
                .HasComment("Unidades Por cajas")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_UNIXCAJA");
            entity.Property(e => e.ArtnUsarivacomp)
                .HasDefaultValueSql("'0'")
                .HasComment("Usar IVA Compra")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_USARIVACOMP");
            entity.Property(e => e.ArtnVence)
                .HasDefaultValueSql("'0'")
                .HasComment("Usa Vencimiento")
                .HasColumnType("int(10)")
                .HasColumnName("ARTN_VENCE");
            entity.Property(e => e.ArtnVolumen)
                .HasPrecision(22, 3)
                .HasComment("Volumen")
                .HasColumnName("ARTN_VOLUMEN");
            entity.Property(e => e.ArtvCodifacpro)
                .HasMaxLength(20)
                .HasComment("Código Fact. Prov.")
                .HasColumnName("ARTV_CODIFACPRO");
            entity.Property(e => e.ArtvCodisicm)
                .HasMaxLength(20)
                .HasComment("Código Farmaceutico")
                .HasColumnName("ARTV_CODISICM");
            entity.Property(e => e.ArtvCpe)
                .HasMaxLength(15)
                .HasComment("CPE")
                .HasColumnName("ARTV_CPE");
            entity.Property(e => e.ArtvDescart)
                .HasMaxLength(80)
                .HasComment("Descripción")
                .HasColumnName("ARTV_DESCART");
            entity.Property(e => e.ArtvDescartcorta)
                .HasMaxLength(20)
                .HasComment("Descripción Corta")
                .HasColumnName("ARTV_DESCARTCORTA");
            entity.Property(e => e.ArtvDescartdeta)
                .HasComment("Descripción Detallada")
                .HasColumnType("text")
                .HasColumnName("ARTV_DESCARTDETA");
            entity.Property(e => e.ArtvDescunicom)
                .HasMaxLength(5)
                .HasComment("Abreviación Unidad Común")
                .HasColumnName("ARTV_DESCUNICOM");
            entity.Property(e => e.ArtvDescunimin)
                .HasMaxLength(5)
                .HasComment("Descripon de unidad minima")
                .HasColumnName("ARTV_DESCUNIMIN");
            entity.Property(e => e.ArtvEspecie)
                .HasMaxLength(15)
                .HasComment("Especie")
                .HasColumnName("ARTV_ESPECIE");
            entity.Property(e => e.ArtvFlotefechamasc)
                .HasMaxLength(20)
                .HasComment("Máscara fecha de Lote")
                .HasColumnName("ARTV_FLOTEFECHAMASC");
            entity.Property(e => e.ArtvFloteprefijo)
                .HasMaxLength(10)
                .HasComment("Prefijo de Lote")
                .HasColumnName("ARTV_FLOTEPREFIJO");
            entity.Property(e => e.ArtvFlotesufijo)
                .HasMaxLength(10)
                .HasComment("Sufijo de Lote")
                .HasColumnName("ARTV_FLOTESUFIJO");
            entity.Property(e => e.ArtvGradalco)
                .HasMaxLength(5)
                .HasComment("Grado de Alcohol")
                .HasColumnName("ARTV_GRADALCO");
            entity.Property(e => e.ArtvIdagrupaa)
                .HasMaxLength(3)
                .HasComment("Grupo")
                .HasColumnName("ARTV_IDAGRUPAA");
            entity.Property(e => e.ArtvIdagrupab)
                .HasMaxLength(3)
                .HasComment("Sug Grupo")
                .HasColumnName("ARTV_IDAGRUPAB");
            entity.Property(e => e.ArtvIdagrupac)
                .HasMaxLength(3)
                .HasComment("Linea")
                .HasColumnName("ARTV_IDAGRUPAC");
            entity.Property(e => e.ArtvIdcategoria)
                .HasMaxLength(3)
                .HasComment("Categoria")
                .HasColumnName("ARTV_IDCATEGORIA");
            entity.Property(e => e.ArtvIdcomicobr)
                .HasMaxLength(3)
                .HasComment("Id comisión cobranza vendedor")
                .HasColumnName("ARTV_IDCOMICOBR");
            entity.Property(e => e.ArtvIdcomicobrd)
                .HasMaxLength(3)
                .HasComment("Id comisión cobranza director")
                .HasColumnName("ARTV_IDCOMICOBRD");
            entity.Property(e => e.ArtvIdcomicobre)
                .HasMaxLength(3)
                .HasComment("Id comisión cobranza extra")
                .HasColumnName("ARTV_IDCOMICOBRE");
            entity.Property(e => e.ArtvIdcomicobrg)
                .HasMaxLength(3)
                .HasComment("Id comisión cobranza gerente")
                .HasColumnName("ARTV_IDCOMICOBRG");
            entity.Property(e => e.ArtvIdcomicobrs)
                .HasMaxLength(3)
                .HasComment("Id comisión cobranza supervisor")
                .HasColumnName("ARTV_IDCOMICOBRS");
            entity.Property(e => e.ArtvIdcomivent)
                .HasMaxLength(3)
                .HasComment("Id comisión ventas vendedor")
                .HasColumnName("ARTV_IDCOMIVENT");
            entity.Property(e => e.ArtvIddepar)
                .HasMaxLength(3)
                .HasComment("Departamento")
                .HasColumnName("ARTV_IDDEPAR");
            entity.Property(e => e.ArtvIddepocomp)
                .HasMaxLength(3)
                .HasComment("Deposito para la venta")
                .HasColumnName("ARTV_IDDEPOCOMP");
            entity.Property(e => e.ArtvIddepovent)
                .HasMaxLength(3)
                .HasComment("Deposito para la venta")
                .HasColumnName("ARTV_IDDEPOVENT");
            entity.Property(e => e.ArtvIdenvase)
                .HasMaxLength(3)
                .HasComment("Envase")
                .HasColumnName("ARTV_IDENVASE");
            entity.Property(e => e.ArtvIdinsumo)
                .HasMaxLength(10)
                .HasComment("Id artículo insumo")
                .HasColumnName("ARTV_IDINSUMO");
            entity.Property(e => e.ArtvIdmarca)
                .HasMaxLength(3)
                .HasComment("Marca")
                .HasColumnName("ARTV_IDMARCA");
            entity.Property(e => e.ArtvIdmoneda)
                .HasMaxLength(2)
                .HasComment("Id moneda de cambio")
                .HasColumnName("ARTV_IDMONEDA");
            entity.Property(e => e.ArtvIdpresen)
                .HasMaxLength(4)
                .HasComment("Presentacion")
                .HasColumnName("ARTV_IDPRESEN");
            entity.Property(e => e.ArtvIdrubro)
                .HasMaxLength(3)
                .HasComment("Id Rubro")
                .HasColumnName("ARTV_IDRUBRO");
            entity.Property(e => e.ArtvIdtipo)
                .HasMaxLength(3)
                .HasComment("Tipo")
                .HasColumnName("ARTV_IDTIPO");
            entity.Property(e => e.ArtvIdubicacion)
                .HasMaxLength(4)
                .HasComment("Id Ubicacion por defecto")
                .HasColumnName("ARTV_IDUBICACION");
            entity.Property(e => e.ArtvMpmedida)
                .HasMaxLength(3)
                .HasComment("Medida")
                .HasColumnName("ARTV_MPMEDIDA");
            entity.Property(e => e.ArtvProcedencia)
                .HasMaxLength(60)
                .HasComment("Procedencia")
                .HasColumnName("ARTV_PROCEDENCIA");
            entity.Property(e => e.ArtvRegissani)
                .HasMaxLength(50)
                .HasComment("Registro Sanitario")
                .HasColumnName("ARTV_REGISSANI");
            entity.Property(e => e.ArtvRutafoto)
                .HasMaxLength(255)
                .HasComment("Ruta de la Foto")
                .HasColumnName("ARTV_RUTAFOTO");
            entity.Property(e => e.ArtvTipopmayor)
                .HasMaxLength(1)
                .HasComment("Tipo de precio para Mayor")
                .HasColumnName("ARTV_TIPOPMAYOR");
        });

        modelBuilder.Entity<Tcamiones>(entity =>
        {
            entity.HasKey(e => e.CamivIdcamion).HasName("PRIMARY");

            entity
                .ToTable("tcamiones")
                .HasCharSet("latin1")
                .UseCollation("latin1_spanish_ci");

            entity.Property(e => e.CamivIdcamion)
                .HasMaxLength(3)
                .HasComment("Id de camión")
                .HasColumnName("CAMIV_IDCAMION");
            entity.Property(e => e.CaminKilometraje)
                .HasPrecision(22, 4)
                .HasComment("Kilometraje")
                .HasColumnName("CAMIN_KILOMETRAJE");
            entity.Property(e => e.CaminToneladas)
                .HasPrecision(22, 4)
                .HasComment("Capacidad en toneladas de camión")
                .HasColumnName("CAMIN_TONELADAS");
            entity.Property(e => e.CaminVolumen)
                .HasPrecision(22, 4)
                .HasComment("Capacidad en volumen de camión")
                .HasColumnName("CAMIN_VOLUMEN");
            entity.Property(e => e.CamivDescripcion)
                .HasMaxLength(50)
                .HasComment("Descripción de camión")
                .HasColumnName("CAMIV_DESCRIPCION");
            entity.Property(e => e.CamivIdempresa)
                .HasMaxLength(3)
                .HasComment("Id Empresa Transporte")
                .HasColumnName("CAMIV_IDEMPRESA");
            entity.Property(e => e.CamivIdidespachador)
                .HasMaxLength(3)
                .HasComment("ID DESPACHADOR")
                .HasColumnName("CAMIV_IDIDESPACHADOR");
            entity.Property(e => e.CamivIdseguro)
                .HasMaxLength(2)
                .HasComment("ID SEGURO")
                .HasColumnName("CAMIV_IDSEGURO");
            entity.Property(e => e.CamivIdtipo)
                .HasMaxLength(2)
                .HasComment("ID TIPO DE CAMION")
                .HasColumnName("CAMIV_IDTIPO");
            entity.Property(e => e.CamivPlaca)
                .HasMaxLength(10)
                .HasComment("Placa de camión")
                .HasColumnName("CAMIV_PLACA");
            entity.Property(e => e.CamivRazosoci)
                .HasMaxLength(100)
                .HasComment("Razón Social")
                .HasColumnName("CAMIV_RAZOSOCI");
            entity.Property(e => e.CamivRif)
                .HasMaxLength(20)
                .HasComment("R.I.F.")
                .HasColumnName("CAMIV_RIF");
        });

        modelBuilder.Entity<Tclientesb>(entity =>
        {
            entity.HasKey(e => e.ClievIdcliente).HasName("PRIMARY");

            entity
                .ToTable("tclientesb")
                .HasCharSet("latin1")
                .UseCollation("latin1_spanish_ci");

            entity.HasIndex(e => new { e.ClievIdestado, e.ClievIdciudad }, "IdCiudad");

            entity.HasIndex(e => e.ClievIdcliente, "IdCliente");

            entity.HasIndex(e => e.ClievIdestado, "IdEstado");

            entity.HasIndex(e => e.ClievIdgrupo, "IdGrupo");

            entity.HasIndex(e => e.ClievIdsubgrupo, "IdSubgrupo");

            entity.HasIndex(e => e.ClievIdzona, "IdZona");

            entity.HasIndex(e => e.ClievIdtmunicipio, "tmunicipio_tclientesb_fk");

            entity.Property(e => e.ClievIdcliente)
                .HasMaxLength(10)
                .HasComment("Codigo del cliente")
                .HasColumnName("CLIEV_IDCLIENTE");
            entity.Property(e => e.ClienCodigopostal)
                .HasComment("Codigo Postal")
                .HasColumnType("int(10)")
                .HasColumnName("CLIEN_CODIGOPOSTAL");
            entity.Property(e => e.ClienContribuye)
                .HasComment("Contribuyente especial")
                .HasColumnType("int(10)")
                .HasColumnName("CLIEN_CONTRIBUYE");
            entity.Property(e => e.ClienDiascred)
                .HasComment("Dias de crédito")
                .HasColumnType("int(10)")
                .HasColumnName("CLIEN_DIASCRED");
            entity.Property(e => e.ClienDiasdespacho)
                .HasComment("Dias de despacho")
                .HasColumnType("int(10)")
                .HasColumnName("CLIEN_DIASDESPACHO");
            entity.Property(e => e.ClienLatitud)
                .HasPrecision(18, 7)
                .HasComment("Latitud")
                .HasColumnName("CLIEN_LATITUD");
            entity.Property(e => e.ClienLimicred)
                .HasPrecision(22, 2)
                .HasComment("Límite de crédito")
                .HasColumnName("CLIEN_LIMICRED");
            entity.Property(e => e.ClienLongitud)
                .HasPrecision(18, 7)
                .HasComment("Longitud")
                .HasColumnName("CLIEN_LONGITUD");
            entity.Property(e => e.ClienMinventa)
                .HasPrecision(22, 10)
                .HasDefaultValueSql("'0.0000000000'")
                .HasComment("Mínimo de venta")
                .HasColumnName("CLIEN_MINVENTA");
            entity.Property(e => e.ClienNocxcne)
                .HasDefaultValueSql("'0'")
                .HasComment("No generar CXC en NE")
                .HasColumnType("int(10)")
                .HasColumnName("CLIEN_NOCXCNE");
            entity.Property(e => e.ClienStatus)
                .HasComment("Cliente activo")
                .HasColumnType("int(10)")
                .HasColumnName("CLIEN_STATUS");
            entity.Property(e => e.ClietUltiventa)
                .HasComment("Fecha de la Ultima Venta")
                .HasColumnType("timestamp")
                .HasColumnName("CLIET_ULTIVENTA");
            entity.Property(e => e.ClievCep)
                .HasMaxLength(30)
                .HasComment("Código Empresas Polar")
                .HasColumnName("CLIEV_CEP");
            entity.Property(e => e.ClievCodisicm)
                .HasMaxLength(20)
                .HasComment("Código Farmaceutico")
                .HasColumnName("CLIEV_CODISICM");
            entity.Property(e => e.ClievDireccion2)
                .HasMaxLength(250)
                .HasComment("Direccion 2")
                .HasColumnName("CLIEV_DIRECCION2");
            entity.Property(e => e.ClievDireccion3)
                .HasMaxLength(250)
                .HasComment("Direccion 3")
                .HasColumnName("CLIEV_DIRECCION3");
            entity.Property(e => e.ClievDireccion4)
                .HasMaxLength(250)
                .HasComment("Direccion 4")
                .HasColumnName("CLIEV_DIRECCION4");
            entity.Property(e => e.ClievDireccion5)
                .HasMaxLength(250)
                .HasComment("Direccion 5")
                .HasColumnName("CLIEV_DIRECCION5");
            entity.Property(e => e.ClievEmail)
                .HasMaxLength(100)
                .HasComment("EMAIL")
                .HasColumnName("CLIEV_EMAIL");
            entity.Property(e => e.ClievEncargado)
                .HasMaxLength(40)
                .HasComment("Encargado")
                .HasColumnName("CLIEV_ENCARGADO");
            entity.Property(e => e.ClievGrupcanal)
                .HasMaxLength(3)
                .HasComment("Grupo canal")
                .HasColumnName("CLIEV_GRUPCANAL");
            entity.Property(e => e.ClievGrupofrec)
                .HasMaxLength(1)
                .HasComment("Grupo de Frecuencia")
                .HasColumnName("CLIEV_GRUPOFREC");
            entity.Property(e => e.ClievHoradespacho)
                .HasMaxLength(10)
                .HasComment("Hora de despacho")
                .HasColumnName("CLIEV_HORADESPACHO");
            entity.Property(e => e.ClievIdciudad)
                .HasMaxLength(3)
                .HasComment("Ciudad")
                .HasColumnName("CLIEV_IDCIUDAD");
            entity.Property(e => e.ClievIddepo)
                .HasMaxLength(3)
                .HasComment("Depósito de venta")
                .HasColumnName("CLIEV_IDDEPO");
            entity.Property(e => e.ClievIdestado)
                .HasMaxLength(3)
                .HasComment("Estado")
                .HasColumnName("CLIEV_IDESTADO");
            entity.Property(e => e.ClievIdgrupo)
                .HasMaxLength(3)
                .HasComment("Grupo")
                .HasColumnName("CLIEV_IDGRUPO");
            entity.Property(e => e.ClievIdmonecob)
                .HasMaxLength(30)
                .HasComment("Id Monedas Cobranza Indexada")
                .HasColumnName("CLIEV_IDMONECOB");
            entity.Property(e => e.ClievIdparroquia)
                .HasMaxLength(4)
                .HasComment("Parroquia")
                .HasColumnName("CLIEV_IDPARROQUIA");
            entity.Property(e => e.ClievIdsada)
                .HasMaxLength(20)
                .HasComment("Código SADA")
                .HasColumnName("CLIEV_IDSADA");
            entity.Property(e => e.ClievIdsubgrupo)
                .HasMaxLength(3)
                .HasComment("Subgrupo")
                .HasColumnName("CLIEV_IDSUBGRUPO");
            entity.Property(e => e.ClievIdtmunicipio)
                .HasMaxLength(3)
                .HasComment("Municipio")
                .HasColumnName("CLIEV_IDTMUNICIPIO");
            entity.Property(e => e.ClievIdurbanizacion)
                .HasMaxLength(3)
                .HasComment("Urbanización")
                .HasColumnName("CLIEV_IDURBANIZACION");
            entity.Property(e => e.ClievIdzona)
                .HasMaxLength(3)
                .HasComment("Zona")
                .HasColumnName("CLIEV_IDZONA");
            entity.Property(e => e.ClievLicencialic)
                .HasMaxLength(30)
                .HasComment("Licencia de licores")
                .HasColumnName("CLIEV_LICENCIALIC");
            entity.Property(e => e.ClievMovil)
                .HasMaxLength(20)
                .HasComment("Telefono Movil")
                .HasColumnName("CLIEV_MOVIL");
            entity.Property(e => e.ClievNombre)
                .HasMaxLength(200)
                .HasComment("Nombre")
                .HasColumnName("CLIEV_NOMBRE");
            entity.Property(e => e.ClievPropietario)
                .HasMaxLength(60)
                .HasComment("Propietario del Negocio")
                .HasColumnName("CLIEV_PROPIETARIO");
            entity.Property(e => e.ClievTelefono2)
                .HasMaxLength(80)
                .HasComment("Telefono")
                .HasColumnName("CLIEV_TELEFONO2");
        });

        modelBuilder.Entity<TnotasentEnc>(entity =>
        {
            entity.HasKey(e => new { e.VenvTipodocu, e.VenvNumedocu, e.VenvIdsucursal })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("tnotasent_enc")
                .HasCharSet("latin1")
                .UseCollation("latin1_spanish_ci");

            entity.HasIndex(e => new { e.VenvTipodocu, e.VenvNumedocu }, "Documento");

            entity.HasIndex(e => e.VenvNumedocu, "Numero");

            entity.HasIndex(e => e.VenvTipodocu, "Tipo");

            entity.HasIndex(e => e.VenvIdcliente, "tnotasent_enc_ibfk_1");

            entity.HasIndex(e => e.VenvIdpvesta, "tnotasent_enc_ibfk_2");

            entity.HasIndex(e => e.VenvIdsucursal, "tnotasent_enc_ibfk_3");

            entity.HasIndex(e => e.VenvIdvendedor, "tnotasent_enc_ibfk_4");

            entity.Property(e => e.VenvTipodocu)
                .HasMaxLength(2)
                .HasComment("Tipo de documento")
                .HasColumnName("VENV_TIPODOCU");
            entity.Property(e => e.VenvNumedocu)
                .HasMaxLength(10)
                .HasComment("Numero de documento")
                .HasColumnName("VENV_NUMEDOCU");
            entity.Property(e => e.VenvIdsucursal)
                .HasMaxLength(6)
                .HasComment("Código de sucursal")
                .HasColumnName("VENV_IDSUCURSAL");
            entity.Property(e => e.VendEmision)
                .HasComment("Fecha del documento")
                .HasColumnType("timestamp")
                .HasColumnName("VEND_EMISION");
            entity.Property(e => e.VendFechafec)
                .HasComment("Fecha de documento afectado")
                .HasColumnType("timestamp")
                .HasColumnName("VEND_FECHAFEC");
            entity.Property(e => e.VendVencimiento)
                .HasComment("Fecha de vencimiento")
                .HasColumnType("timestamp")
                .HasColumnName("VEND_VENCIMIENTO");
            entity.Property(e => e.VennControl)
                .HasComment("Numero de Control")
                .HasColumnType("int(10)")
                .HasColumnName("VENN_CONTROL");
            entity.Property(e => e.VennCosto)
                .HasPrecision(22, 4)
                .HasComment("Costo del documento")
                .HasColumnName("VENN_COSTO");
            entity.Property(e => e.VennCostopromext)
                .HasPrecision(22, 10)
                .HasDefaultValueSql("'0.0000000000'")
                .HasComment("Costo promedio extranjero")
                .HasColumnName("VENN_COSTOPROMEXT");
            entity.Property(e => e.VennDiascred)
                .HasComment("Dias de credito de la factura")
                .HasColumnType("int(10)")
                .HasColumnName("VENN_DIASCRED");
            entity.Property(e => e.VennDocsinrec)
                .HasComment("Documento cancelado sin recibo")
                .HasColumnType("int(10)")
                .HasColumnName("VENN_DOCSINREC");
            entity.Property(e => e.VennExento)
                .HasPrecision(22, 4)
                .HasComment("Monto del exento")
                .HasColumnName("VENN_EXENTO");
            entity.Property(e => e.VennFactor)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Factor de cambio")
                .HasColumnName("VENN_FACTOR");
            entity.Property(e => e.VennGravado)
                .HasPrecision(22, 4)
                .HasComment("Monto del Gravado")
                .HasColumnName("VENN_GRAVADO");
            entity.Property(e => e.VennImpresa)
                .HasComment("Documento Impreso")
                .HasColumnType("int(10)")
                .HasColumnName("VENN_IMPRESA");
            entity.Property(e => e.VennImpualic)
                .HasPrecision(22, 4)
                .HasComment("Alicuota de impuesto")
                .HasColumnName("VENN_IMPUALIC");
            entity.Property(e => e.VennLatitud)
                .HasPrecision(18, 7)
                .HasComment("Latitud de Factura")
                .HasColumnName("VENN_LATITUD");
            entity.Property(e => e.VennLisaea1)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Monto Lisaea 1")
                .HasColumnName("VENN_LISAEA1");
            entity.Property(e => e.VennLisaea2)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Monto Lisaea 2")
                .HasColumnName("VENN_LISAEA2");
            entity.Property(e => e.VennLisaea3)
                .HasMaxLength(255)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Monto Lisaea 3")
                .HasColumnName("VENN_LISAEA3");
            entity.Property(e => e.VennLongitud)
                .HasPrecision(18, 7)
                .HasComment("Longitud de Factura")
                .HasColumnName("VENN_LONGITUD");
            entity.Property(e => e.VennMontafec)
                .HasPrecision(22, 4)
                .HasComment("Monto Afectado")
                .HasColumnName("VENN_MONTAFEC");
            entity.Property(e => e.VennMontodesc1)
                .HasPrecision(22, 4)
                .HasComment("Monto de descuento Global 1")
                .HasColumnName("VENN_MONTODESC1");
            entity.Property(e => e.VennMontodesc2)
                .HasPrecision(22, 4)
                .HasComment("Monto de descuento Global 2")
                .HasColumnName("VENN_MONTODESC2");
            entity.Property(e => e.VennPorcdesc1)
                .HasPrecision(22, 4)
                .HasComment("Porcentaje de descuento global 1")
                .HasColumnName("VENN_PORCDESC1");
            entity.Property(e => e.VennPorcdesc2)
                .HasPrecision(22, 4)
                .HasComment("Porcentaje de descuento global 2")
                .HasColumnName("VENN_PORCDESC2");
            entity.Property(e => e.VennSubtotal)
                .HasPrecision(22, 4)
                .HasComment("Subtotal con descuentos sin impuesto")
                .HasColumnName("VENN_SUBTOTAL");
            entity.Property(e => e.VennTotaimpu)
                .HasPrecision(22, 4)
                .HasComment("Total de impuesto")
                .HasColumnName("VENN_TOTAIMPU");
            entity.Property(e => e.VennTotal)
                .HasPrecision(22, 4)
                .HasComment("Total documento con descuentos e impuesto")
                .HasColumnName("VENN_TOTAL");
            entity.Property(e => e.VennTotalbruto)
                .HasPrecision(22, 4)
                .HasComment("Total bruto sin descuento ni impuesto")
                .HasColumnName("VENN_TOTALBRUTO");
            entity.Property(e => e.VenvCedula)
                .HasMaxLength(15)
                .HasComment("Cédula del Cliente")
                .HasColumnName("VENV_CEDULA");
            entity.Property(e => e.VenvComentario)
                .HasComment("Comentario del Documento")
                .HasColumnType("text")
                .HasColumnName("VENV_COMENTARIO");
            entity.Property(e => e.VenvDevuelta)
                .HasMaxLength(12)
                .HasComment("Modo devolución de la factura (TOTAL O PARCIAL)")
                .HasColumnName("VENV_DEVUELTA");
            entity.Property(e => e.VenvFactafec)
                .HasMaxLength(15)
                .HasComment("Documento Afectado")
                .HasColumnName("VENV_FACTAFEC");
            entity.Property(e => e.VenvHora)
                .HasMaxLength(8)
                .HasComment("Hora de Emisión")
                .HasColumnName("VENV_HORA");
            entity.Property(e => e.VenvIdcarga)
                .HasMaxLength(10)
                .HasComment("Id de carga")
                .HasColumnName("VENV_IDCARGA");
            entity.Property(e => e.VenvIdcliente)
                .HasMaxLength(10)
                .HasComment("Código del Cliente")
                .HasColumnName("VENV_IDCLIENTE");
            entity.Property(e => e.VenvIdequipo)
                .HasMaxLength(10)
                .HasComment("Id Equipo")
                .HasColumnName("VENV_IDEQUIPO");
            entity.Property(e => e.VenvIdmoneda)
                .HasMaxLength(2)
                .HasComment("Id Moneda")
                .HasColumnName("VENV_IDMONEDA");
            entity.Property(e => e.VenvIdmotivodev)
                .HasMaxLength(3)
                .HasComment("id Motivo")
                .HasColumnName("VENV_IDMOTIVODEV");
            entity.Property(e => e.VenvIdpvesta)
                .HasMaxLength(3)
                .HasComment("Código de la Caja")
                .HasColumnName("VENV_IDPVESTA");
            entity.Property(e => e.VenvIdserie)
                .HasMaxLength(1)
                .HasComment("Serie de impresion")
                .HasColumnName("VENV_IDSERIE");
            entity.Property(e => e.VenvIdusuario)
                .HasMaxLength(15)
                .HasComment("Codigo del Usuario")
                .HasColumnName("VENV_IDUSUARIO");
            entity.Property(e => e.VenvIdvendedor)
                .HasMaxLength(3)
                .HasComment("Id de Vendedor")
                .HasColumnName("VENV_IDVENDEDOR");
            entity.Property(e => e.VenvMotivonula)
                .HasComment("Motivo de Anulación")
                .HasColumnType("text")
                .HasColumnName("VENV_MOTIVONULA");
            entity.Property(e => e.VenvOrigen)
                .HasMaxLength(3)
                .HasComment("Origen del Documento")
                .HasColumnName("VENV_ORIGEN");
            entity.Property(e => e.VenvPedido)
                .HasMaxLength(10)
                .HasComment("Número de pedido")
                .HasColumnName("VENV_PEDIDO");
            entity.Property(e => e.VenvRazosoci)
                .HasMaxLength(200)
                .HasComment("Razón Social del Cliente")
                .HasColumnName("VENV_RAZOSOCI");
            entity.Property(e => e.VenvRif)
                .HasMaxLength(15)
                .HasComment("Rif del Cliente")
                .HasColumnName("VENV_RIF");
            entity.Property(e => e.VenvStatus)
                .HasMaxLength(12)
                .HasComment("Status de documento")
                .HasColumnName("VENV_STATUS");
            entity.Property(e => e.VenvStatusadm)
                .HasMaxLength(12)
                .HasComment("Status Administrativo")
                .HasColumnName("VENV_STATUSADM");

            entity.HasOne(d => d.VenvIdsucursalNavigation).WithMany(p => p.TnotasentEnc)
                .HasForeignKey(d => d.VenvIdsucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tnotasent_enc_ibfk_3");
        });

        modelBuilder.Entity<TnotasentReg>(entity =>
        {
            entity.HasKey(e => new { e.VenrvTipodocu, e.VenrvNumedocu, e.VenrvIdarticulo, e.VenrvIdsucursal, e.VenrvObsequio })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity
                .ToTable("tnotasent_reg")
                .HasCharSet("latin1")
                .UseCollation("latin1_spanish_ci");

            entity.HasIndex(e => new { e.VenrvTipodocu, e.VenrvNumedocu, e.VenrvIdarticulo }, "DocIdArticulo");

            entity.HasIndex(e => new { e.VenrvTipodocu, e.VenrvNumedocu }, "Documento");

            entity.HasIndex(e => e.VenrdEmision, "Fecha");

            entity.HasIndex(e => new { e.VenrvTipodocu, e.VenrvIdcarga }, "IdCarga");

            entity.HasIndex(e => e.VenrvIdcliente, "IdCliente");

            entity.HasIndex(e => e.VenrvIddepo, "IdDeposito");

            entity.HasIndex(e => e.VenrvIdarticulo, "tnotasent_reg_ibfk_1");

            entity.HasIndex(e => e.VenrvIdsucursal, "tnotasent_reg_ibfk_2");

            entity.Property(e => e.VenrvTipodocu)
                .HasMaxLength(2)
                .HasComment("Tipo de documento")
                .HasColumnName("VENRV_TIPODOCU");
            entity.Property(e => e.VenrvNumedocu)
                .HasMaxLength(10)
                .HasComment("Numero de documento")
                .HasColumnName("VENRV_NUMEDOCU");
            entity.Property(e => e.VenrvIdarticulo)
                .HasMaxLength(10)
                .HasComment("Id del producto")
                .HasColumnName("VENRV_IDARTICULO");
            entity.Property(e => e.VenrvIdsucursal)
                .HasMaxLength(6)
                .HasComment("Código de sucursal")
                .HasColumnName("VENRV_IDSUCURSAL");
            entity.Property(e => e.VenrvObsequio)
                .HasMaxLength(1)
                .HasDefaultValueSql("'0'")
                .IsFixedLength()
                .HasComment("Obsequio")
                .HasColumnName("VENRV_OBSEQUIO");
            entity.Property(e => e.VenrdEmision)
                .HasComment("Fecha de Emisión")
                .HasColumnType("timestamp")
                .HasColumnName("VENRD_EMISION");
            entity.Property(e => e.VenrnAlicimpu)
                .HasPrecision(22, 4)
                .HasComment("Alicuota de producto")
                .HasColumnName("VENRN_ALICIMPU");
            entity.Property(e => e.VenrnCajas)
                .HasPrecision(22, 2)
                .HasComment("Cajas")
                .HasColumnName("VENRN_CAJAS");
            entity.Property(e => e.VenrnCajascero)
                .HasDefaultValueSql("'0'")
                .HasComment("El usuario dejó las cajas en 0")
                .HasColumnType("int(10)")
                .HasColumnName("VENRN_CAJASCERO");
            entity.Property(e => e.VenrnCajasfact)
                .HasPrecision(22, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Cajas Factudas")
                .HasColumnName("VENRN_CAJASFACT");
            entity.Property(e => e.VenrnCajdesp)
                .HasPrecision(22, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Cajas despachadas")
                .HasColumnName("VENRN_CAJDESP");
            entity.Property(e => e.VenrnCajdv)
                .HasPrecision(22, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Cajas devueltas")
                .HasColumnName("VENRN_CAJDV");
            entity.Property(e => e.VenrnCambioext)
                .HasPrecision(22, 4)
                .HasComment("Factor de cambio moneda extrajera")
                .HasColumnName("VENRN_CAMBIOEXT");
            entity.Property(e => e.VenrnCostdolar)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Costo en dolares")
                .HasColumnName("VENRN_COSTDOLAR");
            entity.Property(e => e.VenrnCosto)
                .HasPrecision(22, 4)
                .HasComment("Costo")
                .HasColumnName("VENRN_COSTO");
            entity.Property(e => e.VenrnCostoactu)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Costo actual de producto")
                .HasColumnName("VENRN_COSTOACTU");
            entity.Property(e => e.VenrnCostopromext)
                .HasPrecision(22, 10)
                .HasDefaultValueSql("'0.0000000000'")
                .HasComment("Costo promedio extranjero")
                .HasColumnName("VENRN_COSTOPROMEXT");
            entity.Property(e => e.VenrnDescuento1)
                .HasPrecision(22, 4)
                .HasComment("% Descuento Lineal 1")
                .HasColumnName("VENRN_DESCUENTO1");
            entity.Property(e => e.VenrnDescuento2)
                .HasPrecision(22, 4)
                .HasComment("% Descuento Lineal 2")
                .HasColumnName("VENRN_DESCUENTO2");
            entity.Property(e => e.VenrnDesdv)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Descuentos devueltos")
                .HasColumnName("VENRN_DESDV");
            entity.Property(e => e.VenrnFactor)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Factor de cambio")
                .HasColumnName("VENRN_FACTOR");
            entity.Property(e => e.VenrnFactorcpe)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Factor costo promedio extranjero")
                .HasColumnName("VENRN_FACTORCPE");
            entity.Property(e => e.VenrnImpdv)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Impuesto devuelto")
                .HasColumnName("VENRN_IMPDV");
            entity.Property(e => e.VenrnKildesp)
                .HasPrecision(22, 3)
                .HasDefaultValueSql("'0.000'")
                .HasComment("Kilos despachados")
                .HasColumnName("VENRN_KILDESP");
            entity.Property(e => e.VenrnKildv)
                .HasPrecision(22, 3)
                .HasDefaultValueSql("'0.000'")
                .HasComment("Kilos devueltos")
                .HasColumnName("VENRN_KILDV");
            entity.Property(e => e.VenrnKilos)
                .HasPrecision(22, 3)
                .HasComment("Kilos")
                .HasColumnName("VENRN_KILOS");
            entity.Property(e => e.VenrnKilosfact)
                .HasPrecision(22, 3)
                .HasDefaultValueSql("'0.000'")
                .HasComment("Kilos Facturados")
                .HasColumnName("VENRN_KILOSFACT");
            entity.Property(e => e.VenrnLisaea1)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Monto Lisaea 1")
                .HasColumnName("VENRN_LISAEA1");
            entity.Property(e => e.VenrnLisaea2)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Monto Lisaea 2")
                .HasColumnName("VENRN_LISAEA2");
            entity.Property(e => e.VenrnLisaea3)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Monto Lisaea 3")
                .HasColumnName("VENRN_LISAEA3");
            entity.Property(e => e.VenrnMontdesc1)
                .HasPrecision(22, 4)
                .HasComment("Monto de descuento lineal 1")
                .HasColumnName("VENRN_MONTDESC1");
            entity.Property(e => e.VenrnMontdesc2)
                .HasPrecision(22, 4)
                .HasComment("Monto de descuento lineal 2")
                .HasColumnName("VENRN_MONTDESC2");
            entity.Property(e => e.VenrnMontdesg1)
                .HasPrecision(22, 4)
                .HasComment("Monto Desc. Global 1")
                .HasColumnName("VENRN_MONTDESG1");
            entity.Property(e => e.VenrnMontdesg2)
                .HasPrecision(22, 4)
                .HasComment("Monto Desc. Global 2")
                .HasColumnName("VENRN_MONTDESG2");
            entity.Property(e => e.VenrnNumreg)
                .HasDefaultValueSql("'0'")
                .HasComment("Numero de registro")
                .HasColumnType("int(10)")
                .HasColumnName("VENRN_NUMREG");
            entity.Property(e => e.VenrnPorcutil)
                .HasPrecision(22, 4)
                .HasComment("% Utilidad")
                .HasColumnName("VENRN_PORCUTIL");
            entity.Property(e => e.VenrnPrecdolar)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Precio en dolares")
                .HasColumnName("VENRN_PRECDOLAR");
            entity.Property(e => e.VenrnPreciocaj)
                .HasPrecision(22, 4)
                .HasComment("Precio x Cajas")
                .HasColumnName("VENRN_PRECIOCAJ");
            entity.Property(e => e.VenrnPreciouni)
                .HasPrecision(22, 4)
                .HasComment("Precio x Unidad")
                .HasColumnName("VENRN_PRECIOUNI");
            entity.Property(e => e.VenrnSubdv)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Subtotal devuelto")
                .HasColumnName("VENRN_SUBDV");
            entity.Property(e => e.VenrnSubtotal)
                .HasPrecision(22, 4)
                .HasComment("Subtotal con descuentos sin impuesto")
                .HasColumnName("VENRN_SUBTOTAL");
            entity.Property(e => e.VenrnTotabrut)
                .HasPrecision(22, 4)
                .HasComment("Total bruto sin descuento ni impuesto")
                .HasColumnName("VENRN_TOTABRUT");
            entity.Property(e => e.VenrnTotaimpu)
                .HasPrecision(22, 4)
                .HasComment("Total de Impuesto")
                .HasColumnName("VENRN_TOTAIMPU");
            entity.Property(e => e.VenrnTotal)
                .HasPrecision(22, 4)
                .HasComment("Total con descuentos e impuestos")
                .HasColumnName("VENRN_TOTAL");
            entity.Property(e => e.VenrnTotdv)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Total devuelto")
                .HasColumnName("VENRN_TOTDV");
            entity.Property(e => e.VenrnUltcoscom)
                .HasPrecision(22, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Ultimo costo de compra")
                .HasColumnName("VENRN_ULTCOSCOM");
            entity.Property(e => e.VenrnUnidades)
                .HasComment("Unidades")
                .HasColumnType("int(10)")
                .HasColumnName("VENRN_UNIDADES");
            entity.Property(e => e.VenrnUnidesp)
                .HasDefaultValueSql("'0'")
                .HasComment("Unidades despachadas")
                .HasColumnType("int(10)")
                .HasColumnName("VENRN_UNIDESP");
            entity.Property(e => e.VenrnUnidfact)
                .HasDefaultValueSql("'0'")
                .HasComment("Unidades Facturadas")
                .HasColumnType("int(10)")
                .HasColumnName("VENRN_UNIDFACT");
            entity.Property(e => e.VenrnUnidv)
                .HasDefaultValueSql("'0'")
                .HasComment("Unidades devueltas")
                .HasColumnType("int(10)")
                .HasColumnName("VENRN_UNIDV");
            entity.Property(e => e.VenrnUtilidad)
                .HasPrecision(22, 4)
                .HasComment("Monto Utilidad")
                .HasColumnName("VENRN_UTILIDAD");
            entity.Property(e => e.VenrvComentario)
                .HasComment("Comentario")
                .HasColumnType("text")
                .HasColumnName("VENRV_COMENTARIO");
            entity.Property(e => e.VenrvDescart)
                .HasMaxLength(80)
                .HasComment("Descripcion del Articulo")
                .HasColumnName("VENRV_DESCART");
            entity.Property(e => e.VenrvIdcaja)
                .HasMaxLength(3)
                .HasComment("Código de la Caja")
                .HasColumnName("VENRV_IDCAJA");
            entity.Property(e => e.VenrvIdcarga)
                .HasMaxLength(10)
                .HasComment("Id de carga")
                .HasColumnName("VENRV_IDCARGA");
            entity.Property(e => e.VenrvIdcliente)
                .HasMaxLength(10)
                .HasComment("Código del Cliente")
                .HasColumnName("VENRV_IDCLIENTE");
            entity.Property(e => e.VenrvIddepo)
                .HasMaxLength(3)
                .HasComment("Código del Depósito")
                .HasColumnName("VENRV_IDDEPO");
            entity.Property(e => e.VenrvIdvendedor)
                .HasMaxLength(3)
                .HasComment("Id de Vendedor")
                .HasColumnName("VENRV_IDVENDEDOR");
            entity.Property(e => e.VenrvStatus)
                .HasMaxLength(12)
                .HasComment("Status del producto dentro de documento")
                .HasColumnName("VENRV_STATUS");
            entity.Property(e => e.VenrvTipoprecio)
                .HasMaxLength(1)
                .HasComment("Tipo de precio de venta")
                .HasColumnName("VENRV_TIPOPRECIO");

            entity.HasOne(d => d.VenrvIdarticuloNavigation).WithMany(p => p.TnotasentReg)
                .HasForeignKey(d => d.VenrvIdarticulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tnotasent_reg_ibfk_1");

            entity.HasOne(d => d.VenrvIdsucursalNavigation).WithMany(p => p.TnotasentReg)
                .HasForeignKey(d => d.VenrvIdsucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tnotasent_reg_ibfk_2");
        });

        modelBuilder.Entity<Tsucursales>(entity =>
        {
            entity.HasKey(e => e.SucuvIdsucursal).HasName("PRIMARY");

            entity
                .ToTable("tsucursales")
                .HasCharSet("latin1")
                .UseCollation("latin1_spanish_ci");

            entity.HasIndex(e => new { e.SucuvIdsucursal, e.SucuvIdempresa }, "SUCUV_IDSUCURSAL");

            entity.Property(e => e.SucuvIdsucursal)
                .HasMaxLength(6)
                .HasComment("Código de sucursal")
                .HasColumnName("SUCUV_IDSUCURSAL");
            entity.Property(e => e.SucuvDireccion1)
                .HasComment("Dirección1")
                .HasColumnType("text")
                .HasColumnName("SUCUV_DIRECCION1");
            entity.Property(e => e.SucuvDireccion2)
                .HasComment("Dirección2")
                .HasColumnType("text")
                .HasColumnName("SUCUV_DIRECCION2");
            entity.Property(e => e.SucuvIdempresa)
                .HasMaxLength(10)
                .HasComment("Id Empresa")
                .HasColumnName("SUCUV_IDEMPRESA");
            entity.Property(e => e.SucuvNombfiscal)
                .HasMaxLength(60)
                .HasComment("Nombre Fiscal")
                .HasColumnName("SUCUV_NOMBFISCAL");
            entity.Property(e => e.SucuvNombre)
                .HasMaxLength(60)
                .HasComment("Nombre")
                .HasColumnName("SUCUV_NOMBRE");
            entity.Property(e => e.SucuvRif)
                .HasMaxLength(20)
                .HasComment("R.I.F")
                .HasColumnName("SUCUV_RIF");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
