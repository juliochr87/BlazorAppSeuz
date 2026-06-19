using BlazorAppSeuz.IServices;
using BlazorAppZeuz.Data;
using BlazorAppZeuz.Dto.NotasEntrega;
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
    
    public async Task<List<CamionDTO>> GetAllCamionesConDespachadorAsync()
    {
        var query = from camion in _context.Tcamiones.AsNoTracking()
            // Al hacer el join directo sin 'into' ni 'DefaultIfEmpty', 
            // SQL lo convierte automáticamente en un INNER JOIN.
            join despachador in _context.Tdespachores
                on camion.CamivIdidespachador equals despachador.DespvIddespachador
                
            select new CamionDTO
            {
                IdCamion = camion.CamivIdcamion,
                Descripcion = camion.CamivDescripcion,
                Placa = camion.CamivPlaca,
                Rif = camion.CamivRif,
                RazonSocial = camion.CamivRazosoci,
                CapacidadVolumen = camion.CaminVolumen ?? 0m,
                CapacidadPesoKg = camion.CaminToneladas * 1000 ?? 0m, 
                IdDespachador = camion.CamivIdidespachador,
                    
                // Ya sabemos que 'despachador' nunca será nulo aquí, 
                // solo controlamos si el campo del nombre en la BD vino vacío.
                NombreDespachador = despachador.DespvNombre ?? "Despachador sin nombre"
            };

        return await query.ToListAsync();
    }
    
    public async Task<List<CamionDTO>> GetAllCamionesConSinDespachadorAsync()
    {
        var query = from camion in _context.Tcamiones.AsNoTracking()
            // 1. Hacemos el Join y lo agrupamos en 'despachadorGroup'
            join despachador in _context.Tdespachores
                on camion.CamivIdidespachador equals despachador.DespvIddespachador into despachadorGroup
                
            // 2. DefaultIfEmpty() es la magia que lo convierte en un LEFT JOIN en SQL
            from despachadorLeft in despachadorGroup.DefaultIfEmpty() 
                
            select new CamionDTO
            {
                IdCamion = camion.CamivIdcamion,
                Descripcion = camion.CamivDescripcion,
                Placa = camion.CamivPlaca,
                Rif = camion.CamivRif,
                RazonSocial =  camion.CamivRazosoci,
                CapacidadVolumen = camion.CaminVolumen ?? 0m,
                // Si viene en Toneladas, lo multiplicamos por 1000 para tenerlo en Kilos
                CapacidadPesoKg = (camion.CaminToneladas ?? 0m), 
                IdDespachador = camion.CamivIdidespachador,
                    
                // 3. Evaluamos si despachadorLeft es null (cuando el camión no tiene uno)
                NombreDespachador = despachadorLeft != null && despachadorLeft.DespvNombre != null 
                    ? despachadorLeft.DespvNombre 
                    : "Sin Despachador Asignado"
            };

        return await query.ToListAsync();
    }
    
    public async Task<bool> UpdateAsync(CamionDTO camion)
    {
        var existingCamion = await _context.Tcamiones
            .FirstOrDefaultAsync(x => x.CamivIdcamion == camion.IdCamion);

        if (existingCamion == null)
            return false;

        existingCamion.CamivDescripcion = camion.Descripcion;
        existingCamion.CamivPlaca = camion.Placa;
        existingCamion.CamivRif = camion.Rif;
        existingCamion.CamivRazosoci = camion.RazonSocial;
        existingCamion.CaminVolumen = camion.CapacidadVolumen;
        existingCamion.CaminToneladas = camion.CapacidadPesoKg;

        await _context.SaveChangesAsync();

        return true;
    }
}