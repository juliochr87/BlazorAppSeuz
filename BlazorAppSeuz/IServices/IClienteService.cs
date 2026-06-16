using BlazorAppZeuz.Models.Zeuz;

namespace BlazorAppSeuz.IServices;

public interface IClienteService
{
    Task<List<Tclientesb>> GetAllAsync();
    Task<bool> UpdateAsync(Tclientesb camion);
}