using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TalentExchange.Data.Models
{
    public class PostReply
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Post Post { get; set; }
    }
}
