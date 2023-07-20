namespace ConvertendoMoeda.Data.Dtos;

public class ReadMoedaDto
{
    public string Moeda { get; set; }
    public double Valor { get; set; }

    public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
}