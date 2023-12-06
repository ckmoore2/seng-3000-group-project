using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Whisperer.Entities;

[Table("Tires")]
public class Tire
{
    [Key]

    [MaxLength(50)]
    public int TireId { get; set; }
    
    [MaxLength(50)]
    public string? TireName { get; set; }
    public float TirePrice { get; set; }
    public int ProductCategoryId { get; set; }
}

