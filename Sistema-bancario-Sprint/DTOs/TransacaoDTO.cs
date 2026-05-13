using Sistema_bancario_Sprint.models;
using System.ComponentModel.DataAnnotations;

namespace Sistema_bancario_Sprint.DTOs;

public class TransacaoDTO
{
    [Required]
    public int ContaId { get; set; }

    [Required]
    public double Valor { get; set; }

    [Required]
    public TipoTransacao Tipo { get; set; }
}
