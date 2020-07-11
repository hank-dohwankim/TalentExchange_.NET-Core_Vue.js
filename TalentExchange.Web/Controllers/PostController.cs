using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalentExchange.Services.PostService;
using TalentExchange.Web.Serialization;
using TalentExchange.Web.ViewModels;

namespace TalentExchange.Web.Controllers
{
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly ILogger<PostController> _logger;
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public PostController(ILogger<PostController> logger, IPostService productService, IMapper mapper)
        {
            _logger = logger;
            _postService = productService;
            _mapper = mapper;
        }

        [HttpGet("/api/post")]
        public ActionResult GetAllPost()
        {
            _logger.LogInformation("Getting all posts");
            var posts = _postService.GetAllPosts();
            var postDto = new List<PostViewModel>();
            foreach (var post in posts)
            {
                postDto.Add(_mapper.Map<PostViewModel>(post));
            }
            return Ok(postDto);
        }
    }
}