using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Car_Whisperer.Entities;

[Table("Wipers")]

public class Wiper
{
    [Key]

    [MaxLength(50)]
    public int WiperCategoryId { get; set; }

    [MaxLength(50)]
    public int WiperId { get; set; }

    [MaxLength(50)]
    public string? WiperName { get; set; }
    public float WiperPrice { get; set; }

    public virtual IEnumerable<Product>? Products { get; set; }
        
}