using System.Collections.Generic;
using TalentExchange.Data.Models;

namespace TalentExchange.Services.PostService
{
    public interface IPostService
    {
        List<Post> GetAllPosts();
        Post GetPostById(int id);
        ServiceResponse<Post> CreatePost(Post post);
        ServiceResponse<Post> ArchivePost(int id);
        ServiceResponse<Post> DeletePost(Post post);
    }
}
