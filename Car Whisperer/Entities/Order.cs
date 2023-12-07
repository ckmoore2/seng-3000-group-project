using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using Car_Whisperer;
using Microsoft.EntityFrameworkCore;

namespace Car_Whisperer.Entities;

[Table("Orders")]
public class Order
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public virtual IEnumerable<LineItem>? LineItems { get; set; }
}
