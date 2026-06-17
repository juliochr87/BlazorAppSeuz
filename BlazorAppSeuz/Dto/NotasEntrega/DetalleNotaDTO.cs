namespace BlazorAppZeuz.Dto.NotasEntrega;

public class DetalleNotaDTO
{
    public string IdArticulo { get; set; }
    public string Descripcion { get; set; }
    public decimal Cajas { get; set; }
    public decimal Unidades { get; set; }
    public string Status { get; set; }

    public decimal PesoUnitario { get; set; }
    public decimal VolumenUnitario { get; set; }

    public decimal PesoTotal => Unidades * PesoUnitario;
    public decimal VolumenTotal => Unidades * VolumenUnitario;
}