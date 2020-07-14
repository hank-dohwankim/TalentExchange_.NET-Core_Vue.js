using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using TalentExchange.Services.PostService;
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
        public ActionResult GetAllPosts()
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

        [HttpGet("/api/post/{id}")]
        public ActionResult GetPostById(int id)
        {
            _logger.LogInformation($"Getting post {id}");
            var post = _postService.GetPostById(id);
            var postDto = new PostViewModel();
            return Ok(postDto);
        }

        [HttpPatch("/api/post/{id}")]
        public ActionResult ArchivePost(int id)
        {
            _logger.LogInformation($"Archiving post number : {id}");
            var archiveResult= _postService.ArchivePost(id);
            return Ok(archiveResult);
        }
    }
}