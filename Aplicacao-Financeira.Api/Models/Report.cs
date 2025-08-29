using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacao_Financeira.Api.Models;

[Table("reports")]
public class Report
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int Month { get; set; }

    [Required]
    public int Year { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalExpenses { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalIncome { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Balance => TotalIncome - TotalExpenses;

    public DateTime GeneratedAt { get; set; } = DateTime.Now;
}
