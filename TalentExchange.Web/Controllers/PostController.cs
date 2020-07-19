using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using TalentExchange.Data.Models;
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
            var postDto = _mapper.Map<Post>(post);
            return Ok(postDto);
        }

        [HttpPost("/api/post")]
        public ActionResult CreatePost([FromBody]PostViewModel postViewModel)
        {
            if(postViewModel == null)
            {
                return BadRequest(ModelState);
            }

            var postDto = _mapper.Map<Post>(postViewModel);
            var result = _postService.CreatePost(postDto);

            if(result == null)
            {
                ModelState.AddModelError("", $"Somting went wrong while creating {postDto.Title}");
                return StatusCode(500, ModelState);
            }

            return Ok(result);
        }

        [HttpPatch("/api/post/{id}")]
        public ActionResult ArchivePost(int id)
        {
            _logger.LogInformation($"Archiving post number : {id}");
            var archiveResult = _postService.ArchivePost(id);
            return Ok(archiveResult);
        }

        [HttpDelete("/api/post/{id}")]
        public ActionResult DeletePost(int id)
        {
            _logger.LogInformation($"Deleting post number : {id}");
            var postObj = _postService.GetPostById(id);
            if (postObj == null)
            {
                return NotFound();
            }

            if (_postService.DeletePost(postObj) == null)
            {
                ModelState.AddModelError("", $"Somting went wrong while updating {postObj.Title}");
                return StatusCode(500, ModelState);
            }

            return Ok("Post deleted");
        }
    }
}