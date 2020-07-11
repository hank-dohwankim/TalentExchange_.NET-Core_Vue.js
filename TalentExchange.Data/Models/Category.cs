using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TalentExchange.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string CategName { get; set; }

        public IEnumerable<Post> Posts { get; set; }
    }
}