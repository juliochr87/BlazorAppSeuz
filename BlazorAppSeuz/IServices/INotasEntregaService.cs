
using BlazorAppSeuz.Models;
using BlazorAppZeuz.Dto.NotasEntrega;
using BlazorAppZeuz.Models.Zeuz;
using MudBlazor;

namespace BlazorAppSeuz.IServices
{
    public interface INotasEntregaService
    {
        Task<List<TnotasentReg>> GetDetalleByNota(string documento);
        Task<List<DetalleNotaDTO>> GetDetalleByNotaPesoVolumen(string documento);
        Task<List<TnotasentEnc>> GetNotasEntregaByDateRange(DateRange range);
        Task<List<TnotasentEnc>> GetNotasEntregaByDate(DateTime day);
        Task<List<NotaEntregaDto>> GetNotasEntregaByDatePesoVolumen(DateTime day);
    }
}
