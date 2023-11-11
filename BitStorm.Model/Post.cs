using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Models;
public class Post
{
    [Key]
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int LikeCount { get; set; }
    public int CommentCount { get; set; }

    public bool IsAnonymous { get ; set; }
    [Required]
    [DisplayName("Content")]
    public string Content { get; set; }
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }
}

