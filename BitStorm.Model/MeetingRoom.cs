using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;
public class MeetingRoom
{
    [Key]
    public int Id { get; set; }
    public DateTime DateStart { get; set; }

    [ForeignKey("User")]    
    public int UserId { get; set; }
    public User User { get; set; }
    [ForeignKey("Expert")]
    public int ExpertId { get; set; }
    public Expert Expert { get; set; }
}

