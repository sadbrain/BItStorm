using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CategoryVideo
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [ForeignKey("Video")]
        public int VideoId { get; set; }
        public Video Video { get; set; }
    }
}
