
using BlazorAppSeuz.IServices;
using BlazorAppSeuz.Data;
using BlazorAppSeuz.Models;
using BlazorAppZeuz.Data;
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
        
        
 
        
    }
}
