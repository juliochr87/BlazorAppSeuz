namespace BlazorAppZeuz.Dto.NotasEntrega;

public class CamionDTO
{
    public string IdCamion { get; set; } = null!;
    public string? Descripcion { get; set; }
    public string? Placa { get; set; }
    public string? Rif { get; set; }
    public string? RazonSocial { get; set; }
    public decimal CapacidadVolumen { get; set; }
    public decimal CapacidadPesoKg { get; set; } // Transformado a KG si viene en Toneladas
    public string? IdDespachador { get; set; }
    public string? NombreDespachador { get; set; } 
    
    
    // Lista temporal de notas asignadas a este camión en la pantalla
    public List<NotaEntregaDto> NotasAsignadas { get; set; } = new();

    // Calcula el peso actual sumando las notas asignadas
    public decimal PesoActual => NotasAsignadas.Sum(n => n.PesoTotal);

    // Calcula el porcentaje de ocupación (evitando división por cero)
    public double PorcentajePeso => CapacidadPesoKg > 0 
        ? (double)(PesoActual / CapacidadPesoKg) * 100 
        : 0;
    public decimal TotalCajas => NotasAsignadas.Sum(n => n.CajasTotal);
    public decimal TotalArticulos => NotasAsignadas.Sum(n => n.LineasTotal);

    // --- NUEVAS PROPIEDADES: VOLUMEN ---
    public decimal VolumenActual => NotasAsignadas.Sum(n => n.VolumenTotal);
    
    // Calcula el porcentaje de volumen (evitando división por cero)
    public double PorcentajeVolumen => CapacidadVolumen > 0 
        ? (double)(VolumenActual / CapacidadVolumen) * 100 
        : 0;
}