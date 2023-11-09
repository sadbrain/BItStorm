using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;
public class Comment
{
    [Key]
    public int Id { get; set; }
    public DateTime CreateAt { get; set; }
    [Required]
    public string Content { get; set; }
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }
    [ForeignKey("Post")]
    public int PostId { get; set; }
    public Post Post { get; set; }
}
