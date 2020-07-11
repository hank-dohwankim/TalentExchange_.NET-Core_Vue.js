using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TalentExchange.Data.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TagName { get; set; }
        public virtual Post Post { get; set; }
    }
}