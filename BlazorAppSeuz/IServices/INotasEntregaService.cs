
using BlazorAppSeuz.Models;
using BlazorAppZeuz.Models.Zeuz;
using MudBlazor;

namespace BlazorAppSeuz.IServices
{
    public interface INotasEntregaService
    {
        Task<List<TnotasentReg>> GetDetalleByNota(string documento);
        Task<List<TnotasentEnc>> GetNotasEntregaByDateRange(DateRange range);
    }
}
