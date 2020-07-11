using System;
using System.Collections.Generic;
using System.Linq;
using TalentExchange.Data;
using TalentExchange.Data.Models;

namespace TalentExchange.Services.PostService
{
    public class PostService : IPostService
    {
        private readonly ApplicationDbContext _db;

        public PostService(ApplicationDbContext db)
        {
            _db = db;
        }

        public ServiceResponse<Post> ArchivePost(int id)
        {
            try
            {
                var post = _db.Posts.Find(id);
                post.IsComplete = true;
                _db.SaveChanges();

                return new ServiceResponse<Post>
                {
                    Data = post,
                    Time = DateTime.UtcNow,
                    Message = "Archived post",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Post>
                {
                    Data = null,
                    Time = DateTime.UtcNow,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }

        public ServiceResponse<Post> CreatePost(Post post)
        {
            try
            {
                var newPost = new Post
                {
                    CategoryId = post.Category.Id,
                    Location = post.Location,
                    Tags = post.Tags,
                    CreatedOn = post.CreatedOn,
                    Content = post.Content,
                    Title = post.Title,
                    User = post.User
                };

                _db.Posts.Add(newPost);
                _db.SaveChanges();

                return new ServiceResponse<Post>
                {
                    Data = post,
                    Time = DateTime.UtcNow,
                    Message = "Post created.",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Post>
                {
                    Data = post,
                    Time = DateTime.UtcNow,
                    Message = "Error creating new post",
                    IsSuccess = false
                };
            }
        }

        public List<Post> GetAllPosts()
        {
            return _db.Posts.ToList();
        }

        public Post GetPostById(int id)
        {
            return _db.Posts.Find(id);
        }
    }
}
