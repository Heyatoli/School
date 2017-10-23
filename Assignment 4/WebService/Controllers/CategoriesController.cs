using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityMapping;        //Our own dataservice as a library
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.CodeGeneration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;

namespace WebService.Controllers
{
    [Route("/api/categories")]
    public class CategoriesController : Controller
    {
        private IDataService _dataService;

        public CategoriesController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var categories = _dataService.GetCategories();
            if (categories == null) return NotFound();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategories(int id)
        {
            var categories = _dataService.GetCategory(id);
            if (categories == null) return NotFound();
            return Ok(categories);
        }

        [HttpPost]
        //This doesn't work, we believe the problem is the return value, because the tests aren't able to read it.
        public IActionResult Post([FromBody] Category value)
        {
           Category categories = _dataService.CreateCategory(value.Name,value.Description);
           string Uri = Url.Link("/api/categories", new { id = categories.Id });
           return Created(Uri,value);
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Category value)
        {
             var categories = _dataService.UpdateCategory(id, value.Name, value.Description);
             if (!categories) return NotFound();
             return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Category value)
        {
            var categories = _dataService.DeleteCategory(value.Id);
            if (categories == false) return NotFound();
            return Ok(value.Id);
        }
    }
}