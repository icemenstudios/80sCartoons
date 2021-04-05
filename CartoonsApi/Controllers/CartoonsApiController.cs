using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CartoonsApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CartoonsApi.Controllers
{
    [Route("api/[controller]")]
    public class CartoonsApiController : Controller
    {
        private IData _data;

        public CartoonsApiController(IData data)
        {
            _data = data;
        }

        [HttpGet("/api/Cartoons")]
        public ActionResult<List<Cartoons>> GetAll()
        {
            return _data.CartoonsInitializeData();
        }

        [HttpGet("/api/Cartoons/{id}", Name = "GetCartoon")]
        public ActionResult<Cartoons> GetById(int? id)
        {
            var item = _data.GetCartoonsId(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);

        }


        //// GET: api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
