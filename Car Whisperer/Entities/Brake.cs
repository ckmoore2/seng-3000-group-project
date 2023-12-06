using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Car_Whisperer.Entities;

[Table("Brakes")]
public class Brake
{
    [Key]

    [MaxLength(50)]
    public int BrakeCategoryId { get; set; }

    [MaxLength(50)]
    public int BrakeId { get; set; }

    [MaxLength(50)]
    public string? BrakeName { get; set; }
    public float BrakePrice { get; set; }

    public virtual IEnumerable<Product> Products { get; set; }

        
}
