using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Subproject_2;        //Our own dataservice as a library
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.CodeGeneration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace WebService.Controllers
{
    [Route("/api/posts")]
    public class PostController : Controller
    {
        private IDataServicePost _dataService;

        public PostController(IDataServicePost dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult GetPost()
        {
            var posts = _dataService.getPost();
            if (posts == null) return NotFound();
            return Ok(JsonConvert.SerializeObject(posts));
        }

        [HttpGet, Route("tag/{tagName}")]
        public IActionResult GetPostByTag(string tagName)
        {
            var post = _dataService.getPostByTag(tagName);
            if (post == null) return NotFound();
            return Ok(JsonConvert.SerializeObject(post));
        }

        [HttpGet, Route("comments/{postId}")]
        public IActionResult GetCommentsByPost(int postId)
        {
            var comments = _dataService.getCommments(postId);
            if (comments == null) return NotFound();
            return Ok(JsonConvert.SerializeObject(comments));
        }

        [HttpGet, Route("user/{userId}")]
        public IActionResult GetPostsByUserId(int userId)
        {
            var posts = _dataService.getPostByUser(userId);
            if (posts == null) return NotFound();
            return Ok(JsonConvert.SerializeObject(posts));
        }

        [HttpGet, Route("title/{substring}")]
        public IActionResult GetPostsByName(string substring)
        {
            var posts = _dataService.getPostWord(substring);
            if (posts == null) return NotFound();
            return Ok(JsonConvert.SerializeObject(posts));
        }
    }
}