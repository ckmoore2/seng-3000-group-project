using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Car_Whisperer.Entities;

[Table("Oil")]

public class Oil
{
    [Key]

    [MaxLength(50)]
    public int OilCategoryId { get; set; }

    [MaxLength(50)]
    public int OilId { get; set; }

    [MaxLength(50)]
    public string? OilName { get; set; }
    public float OilPrice { get; set; }
        
}