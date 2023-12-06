using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Car_Whisperer.Entities;
public class LineItem
{
    public int OrderId { get; set; }
    public int LineItemId { get; set; }

    public int LineNumber { get; set; }

    public int ProductId {get; set; }

    public int Quantity { get;set; }

    public float LineTotal { get; set; }
}
