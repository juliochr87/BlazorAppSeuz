using BlazorAppSeuz.IServices;
using BlazorAppZeuz.Data;
using BlazorAppZeuz.Models.Zeuz;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppSeuz.Services;

public class CamionService : ICamionService
{
    private readonly ZeuzDbContext _context;

    public CamionService(ZeuzDbContext context)
    {
        _context = context;
    }

    public async Task<List<Tcamiones>> GetAllAsync()
    {
        return await _context.Tcamiones
            .AsNoTracking()
            .ToListAsync();
    }
    
    public async Task<bool> UpdateAsync(Tcamiones camion)
    {
        var existingCamion = await _context.Tcamiones
            .FirstOrDefaultAsync(x => x.CamivIdcamion == camion.CamivIdcamion);

        if (existingCamion == null)
            return false;

        existingCamion.CamivDescripcion = camion.CamivDescripcion;
        existingCamion.CamivPlaca = camion.CamivPlaca;
        existingCamion.CamivRif = camion.CamivRif;
        existingCamion.CamivRazosoci = camion.CamivRazosoci;
        existingCamion.CaminVolumen = camion.CaminVolumen;
        existingCamion.CaminToneladas = camion.CaminToneladas;

        await _context.SaveChangesAsync();

        return true;
    }
}