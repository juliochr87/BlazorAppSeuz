using BlazorAppZeuz.Dto.NotasEntrega;
using BlazorAppZeuz.Models.Zeuz;

namespace BlazorAppSeuz.IServices;

public interface ICamionService
{
    Task<List<Tcamiones>> GetAllAsync();
    Task<List<CamionDTO>> GetAllCamionesConSinDespachadorAsync();
    Task<List<CamionDTO>> GetAllCamionesConDespachadorAsync();
    Task<bool> UpdateAsync(CamionDTO camion);
}