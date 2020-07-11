using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TalentExchange.Data.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public string Location { get; set; }
        public bool IsComplete { get; set; }
        public List<Tag> Tags { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Category Category { get; set; }
        //public virtual IEnumerable<Tag> Tags { get; set; }
        public virtual IEnumerable<PostReply> Replies { get; set; }
    }
}