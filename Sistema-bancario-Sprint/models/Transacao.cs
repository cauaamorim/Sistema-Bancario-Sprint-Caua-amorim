using System.ComponentModel.DataAnnotations;

namespace Sistema_bancario_Sprint.models;

public enum TipoTransacao
{
    Deposito,
    Saque
}

public class Transacao
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int ContaId { get; set; }

    [Required]
    public double Valor { get; set; }

    [Required]
    public TipoTransacao Tipo { get; set; }

    public double TaxaAplicada { get; set; }

    public DateTime Data { get; set; } = DateTime.UtcNow;

    // Navigation property
    public Conta? Conta { get; set; }
}
