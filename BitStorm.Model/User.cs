using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;

public class User
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(30)]
    [DisplayName("Name")]
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    [DisplayName("Email")]
    public string Email { get; set; }
    [Required]
    [MinLength(8)]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).+$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
    [DisplayName("Password")]
    public string Password { get; set; }
    public string Url { get; set;  }
    [ForeignKey("Role")]
    public int RoleId { get; set; }
    public Role Role { get; set; }


}
