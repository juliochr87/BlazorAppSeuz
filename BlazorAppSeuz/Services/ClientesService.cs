using BlazorAppSeuz.IServices;
using BlazorAppZeuz.Data;
using BlazorAppZeuz.Models.Zeuz;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppSeuz.Services;

public class ClienteService : IClienteService
{
    private readonly ZeuzDbContext _context;

    public ClienteService(ZeuzDbContext context)
    {
        _context = context;
    }

    public async Task<List<Tclientesb>> GetAllAsync()
    {
        return await _context.Tclientesb
            .AsNoTracking()
            .ToListAsync();
    }
    
    public async Task<bool> UpdateAsync(Tclientesb cliente)
    {
        var existingCliente = await _context.Tclientesb
            .FirstOrDefaultAsync(x => x.ClievIdcliente == cliente.ClievIdcliente);

        if (existingCliente == null)
            return false;

        existingCliente.ClienLatitud = cliente.ClienLatitud;
        existingCliente.ClienLongitud = cliente.ClienLongitud;
         
        await _context.SaveChangesAsync();

        return true;
    }
}