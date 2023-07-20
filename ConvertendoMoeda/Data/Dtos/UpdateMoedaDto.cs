using System.ComponentModel.DataAnnotations;

namespace ConvertendoMoeda.Data.Dtos;

public class UpdateMoedaDto
{
    public int id { get; set; }

    [Required(ErrorMessage = "O nome da moeda é obrigatório.")]
    public string Moeda { get; set; }

    [Required(ErrorMessage = "O valor da moeda é obrigatório.")]
    public double Valor { get; set; }

}