using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Car_Whisperer.Entities;

[Table("Roles")]
public class Role
{
    public int RoleId { get; set; }
    [Required]
    [MaxLength(50)]
    public string RoleName { get; set; }
}