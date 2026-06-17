namespace BlazorAppZeuz.Dto.NotasEntrega;

public class NotaEntregaDto
{
    public string Documento { get; set; }
    public string Rif { get; set; }
    public string RazonSocial { get; set; }
    public string Status { get; set; }
    
    public string Comentarios { get; set; }
    public DateTime FechaEmision { get; set; }

    public decimal PesoTotal { get; set; }
    public decimal VolumenTotal { get; set; }
}