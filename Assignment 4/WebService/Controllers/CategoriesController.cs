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

        public HttpStatusCode Post([FromBody] string value)
        {
            Category c = JsonConvert.DeserializeObject<Category>(value);
            Category categories = _dataService.CreateCategory(c.Name,c.Description);
           // if (categories == null);
            return HttpStatusCode.Created;
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
             //Category c = JsonConvert.DeserializeObject<Category>(value);
             var categories = _dataService.UpdateCategory(-1, "12", "12");
             if (!categories) return NotFound();
             return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var categories = _dataService.DeleteCategory(id);
            if (categories == false) return NotFound();
            return Ok(categories);
        }
    }
}