using System.ComponentModel.DataAnnotations;

namespace APImoeda.Models;

public class MoedasModel
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "Digite o valor da Moeda.")]
    public string Moeda { get; set; }

    public double Valor { get; set; }
}

