
using BlazorAppSeuz.IServices;
using BlazorAppSeuz.Data;
using BlazorAppSeuz.Models;
using BlazorAppZeuz.Data;
using BlazorAppZeuz.Dto.NotasEntrega;
using BlazorAppZeuz.Models.Zeuz;
using Microsoft.EntityFrameworkCore;
using MudBlazor;

namespace BlazorAppSeuz.Services
{
    public class NotasEntregaService : INotasEntregaService
    {
        private readonly ZeuzDbContext _context;

        public NotasEntregaService(ZeuzDbContext context)
        {
            _context = context;
        }
 
        public async Task<List<TnotasentReg>> GetDetalleByNota(string documento)
        {
            return await _context.TnotasentReg
                .Where(x => x.VenrvNumedocu == documento)
                .ToListAsync();
        }
        
        public async Task<List<DetalleNotaDTO>> GetDetalleByNotaPesoVolumen(string documento)
        {
            return await _context.TnotasentReg
                .Where(x => x.VenrvNumedocu == documento)
                .Select(x => new DetalleNotaDTO
                {
                    IdArticulo = x.VenrvIdarticulo,
                    Descripcion = x.VenrvDescart,
                    Cajas = x.VenrnCajas.Value,
                    Unidades = x.VenrnUnidades.Value,
                    Status = x.VenrvStatus,

                    PesoUnitario = x.VenrvIdarticuloNavigation.ArtnPeso.Value,
                    VolumenUnitario = x.VenrvIdarticuloNavigation.ArtnVolumen.Value
                })
                .ToListAsync();
        }
        
        public async Task<List<TnotasentEnc>> GetNotasEntregaByDateRange(DateRange range)
        {
             
            var start = range?.Start?.Date;
            var end = range?.End?.Date.AddDays(1);

            var query = _context.TnotasentEnc.AsQueryable();

            if (start.HasValue)
            {
                var s = start.Value;
                query = query.Where(x => x.VendEmision >= s);
            }

            if (end.HasValue)
            {
                var e = end.Value;
                query = query.Where(x => x.VendEmision < e);
            }

            return await query
                .OrderByDescending(x => x.VendEmision)
                .ToListAsync();
        }
        
        public async Task<List<TnotasentEnc>> GetNotasEntregaByDate(DateTime day)
        {
            var start = day.Date;
            var end = day.Date.AddDays(1);

            return await _context.TnotasentEnc
                .Where(x => x.VendEmision >= start && x.VendEmision < end)
                .ToListAsync();
        }
        
        public async Task<List<NotaEntregaDto>> GetNotasEntregaByDatePesoVolumen(DateTime day)
{
    var start = day.Date;
    var end = day.Date.AddDays(1);

    // 1. NOTAS (base)
    var notas = await _context.TnotasentEnc
        .AsNoTracking()
        .Where(x => x.VendEmision >= start && x.VendEmision < end)
        .Select(x => new NotaEntregaDto
        {
            Documento = x.VenvNumedocu,
            Rif = x.VenvRif,
            RazonSocial = x.VenvRazosoci,
            Status = x.VenvStatus,
            FechaEmision = x.VendEmision.Value,
            Comentarios = x.VenvComentario,

            PesoTotal = 0,
            VolumenTotal = 0,
            CajasTotal = 0,
            LineasTotal = 0
        })
        .ToListAsync();

    // 2. DOCUMENTOS
    var documentos = notas.Select(x => x.Documento).ToList();

    // 3. DETALLES (sin GROUP BY en SQL)
    var detalles = await _context.TnotasentReg
        .AsNoTracking()
        .Where(x => documentos.Contains(x.VenrvNumedocu))
        .Select(x => new
        {
            x.VenrvNumedocu,

            Peso = (decimal)x.VenrnCajas *
                   (x.VenrvIdarticuloNavigation.ArtnPeso ?? 0m),

            Volumen = (decimal)x.VenrnCajas *
                      (x.VenrvIdarticuloNavigation.ArtnVolumen ?? 0m),

            Cajas = x.VenrnCajas ?? 0m
        })
        .ToListAsync();

    // 4. AGRUPAR EN MEMORIA
    var lookup = detalles
        .GroupBy(x => x.VenrvNumedocu)
        .ToDictionary(
            g => g.Key,
            g => new
            {
                Peso = g.Sum(x => x.Peso),
                Volumen = g.Sum(x => x.Volumen),
                Cajas = g.Sum(x => x.Cajas),
                Lineas = g.Count()
            });

    // 5. ASIGNAR A NOTAS
    foreach (var n in notas)
    {
        if (lookup.TryGetValue(n.Documento, out var t))
        {
            n.PesoTotal = t.Peso;
            n.VolumenTotal = t.Volumen;
            n.CajasTotal = t.Cajas;
            n.LineasTotal = t.Lineas;
        }
    }

    return notas;
}
 
        
    }
}
