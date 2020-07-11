using AutoMapper;
using System;
using System.Collections.Generic;
using TalentExchange.Data.Models;
using TalentExchange.Web.ViewModels;

namespace TalentExchange.Web.Serialization
{
    public class PostMapper : Profile
    {
        public PostMapper()
        {
            CreateMap<Post, PostViewModel>().ReverseMap();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsProcess { get; set; }
        public bool IsComplete { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Category Category { get; set; }

        public virtual IEnumerable<PostReply> Replies { get; set; }
        public virtual IEnumerable<Tag> Tags { get; set; }
    }
}