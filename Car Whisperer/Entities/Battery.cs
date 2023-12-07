using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Car_Whisperer.Entities;

[Table("Car Batteries")]
public class Battery
{
    [Key]

    [MaxLength(50)]
    public int BatteryCategoryId { get; set; }

    [MaxLength(50)]
    public int BatteryId { get; set; }

    [MaxLength(50)]
    public string? BatteryName { get; set; }
    public float BatteryPrice { get; set; }

    public virtual IEnumerable<Product>? Products { get; set; }

        
}