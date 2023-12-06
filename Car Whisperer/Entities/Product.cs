using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Whisperer.Entities;

[Table("Products")]
public class Product
{
    [Key]

    [MaxLength(50)]
    public int ProductId { get; set; }
        
    [MaxLength(50)]
    public string? ProductName { get; set; }
    public float ProductPrice { get; set; }
    public int ProductCategoryId { get; set; }
}
