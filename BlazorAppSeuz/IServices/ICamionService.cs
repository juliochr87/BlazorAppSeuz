using BlazorAppZeuz.Models.Zeuz;

namespace BlazorAppSeuz.IServices;

public interface ICamionService
{
    Task<List<Tcamiones>> GetAllAsync();
    Task<bool> UpdateAsync(Tcamiones camion);
}