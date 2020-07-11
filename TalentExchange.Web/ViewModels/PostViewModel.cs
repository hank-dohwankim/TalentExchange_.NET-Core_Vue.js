using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalentExchange.Data.Models;

namespace TalentExchange.Web.ViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public string Location { get; set; }
        public bool IsComplete { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Category Category { get; set; }
        public virtual IEnumerable<Tag> Tags { get; set; }
        public virtual IEnumerable<PostReply> Replies { get; set; }
    }
}
