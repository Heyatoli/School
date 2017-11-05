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

namespace StackoverflowWebservice.Controllers
{
    [Route("/api/users")]
    public class UserController : Controller
    {

        private IDataServiceUser _dataService;

        public UserController(IDataServiceUser dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _dataService.getUser();
            if (users == null) return NotFound();
            return Ok(JsonConvert.SerializeObject(users));
        }

        [HttpGet("name")]
        public IActionResult GetUsersByName(string name)
        {
            var users = _dataService.getUsername(name);
            if (users == null) return NotFound();
            return Ok(JsonConvert.SerializeObject(users));
        }

        [HttpGet, Route("history/{userId}")]
        public IActionResult GetUserHistory(int userId)
        {
            var history = _dataService.getHistory(userId);
            if (history == null) return NotFound();
            return Ok(JsonConvert.SerializeObject(history));
        }

        [HttpGet, Route("markings/{userId}")]
        public IActionResult GetUserMarkings(int userId)
        {
            var markings = _dataService.getFavourites(userId);
            if (markings == null) return NotFound();
            return Ok(JsonConvert.SerializeObject(markings));
        }

        [HttpDelete, Route("history/{histId}")]
        public IActionResult DeleteUserHistory(int histId)
        {
            var delete = _dataService.deleteHistory(histId);
            if (delete == false) return NotFound();
            return Ok(histId);

        }

        [HttpDelete, Route("markings/{postId}/{userId}")]
        public IActionResult DeleteUserMarking(int postId, int userId)
        {
            var delete = _dataService.deleteFavourites(postId, userId);
            if (delete == false) return NotFound();
            return Ok(postId);

        }

        [HttpPost, Route("markings")]
        public IActionResult PostUserMarking([FromBody] Marking value)
        {
            var marking = _dataService.createMarking(value.userID, value.postId, value.note);
            var url = Url.Link("markings", new { postId = value.postId, userId = value.userID });
            return Created(url, value);
            return Json(JsonConvert.SerializeObject(value));
        }

        [HttpPut, Route("markings")]
        public IActionResult PutMarkings([FromBody] Marking value)
        {
            var update = _dataService.updateMarking(value.userID, value.postId, value.note);
            if (update == null) return NotFound();
            return Ok();
        }
    }
}
