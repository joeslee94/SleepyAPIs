using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WaterBottlesApi.Data;
using WaterBottlesApi.Models;
using WebApi.OutputCache.V2;

namespace WaterBottlesApi.Controllers
{
    public class WaterBottlesController : ApiController
    {
        // GET: api/WaterBottles
        WaterBottlesDbContext WaterBottlesDbContext = new WaterBottlesDbContext();
        
        [HttpGet]
        [CacheOutput(ClientTimeSpan = 60)]
        public IHttpActionResult GetAllWaterBottles()
        {
            var allWaterBottles = WaterBottlesDbContext.waterBottles;
            return Ok(allWaterBottles);
        }

        // GET: api/WaterBottles/5
        [HttpGet]
        public IHttpActionResult GetOneWaterBottle(int id)
        {
            var specificWaterBottle = WaterBottlesDbContext.waterBottles.Where(x => x.Id == id);
            if (specificWaterBottle != null)
            {
                return Ok(specificWaterBottle);
            }
            else
            {
                return BadRequest("There is not a valid entity with that Id.");
            }
        }
        
        [HttpGet]
        public IHttpActionResult GetWaterBottleSorted(string sort)
        {
            IQueryable<WaterBottles> sortedWaterBottles;
            switch (sort)
            {
                case "asc":
                    sortedWaterBottles = WaterBottlesDbContext.waterBottles.OrderBy(x => x.Price);
                    break;
                case "desc":
                    sortedWaterBottles = WaterBottlesDbContext.waterBottles.OrderByDescending(x => x.Price);
                    break;
                case "brand":
                    sortedWaterBottles = WaterBottlesDbContext.waterBottles.OrderBy(x => x.Brand);
                    break;
                case "color":
                    sortedWaterBottles = WaterBottlesDbContext.waterBottles.OrderBy(x => x.Color);
                    break;
                default:
                    sortedWaterBottles = WaterBottlesDbContext.waterBottles.OrderBy(x => x.CurrentDrink);
                    break;
            }
            return Ok(sortedWaterBottles);
        }

        [HttpGet]
        [Route("api/WaterBottles/SearchWaterBottles/{type=}")]
        public IHttpActionResult SearchWaterBottles(string type)
        {
            var foundWaterBottles = WaterBottlesDbContext.waterBottles.Where(x => x.Color.Contains(type));
            return Ok(foundWaterBottles);
        }

        // POST: api/WaterBottles
        public IHttpActionResult Post([FromBody]WaterBottles aWaterBottle)
        {
            if (ModelState.IsValid)
            {
                WaterBottlesDbContext.waterBottles.Add(aWaterBottle);
                WaterBottlesDbContext.SaveChanges();
                return Ok("Your water bottle was added to the database");
            }
            else
                return BadRequest("You did not enter in valid values for the water bottle.");
        }

        // PUT: api/WaterBottles/5
        public IHttpActionResult Put(int id, [FromBody]WaterBottles aWaterBottle)
        {
            var changeWaterBottle = WaterBottlesDbContext.waterBottles.Find(id);

            if (changeWaterBottle == null)
            {
                return BadRequest("There is no water bottle entity with that ID");
            }
            else
            {
                changeWaterBottle.Brand = aWaterBottle.Brand;
                changeWaterBottle.Color = aWaterBottle.Color;
                changeWaterBottle.CurrentDrink = aWaterBottle.CurrentDrink;
                changeWaterBottle.Size = aWaterBottle.Size;
                WaterBottlesDbContext.SaveChanges();
                return Ok($"The water bottle at {id} ID has been updated.");
            }
        }

        // DELETE: api/WaterBottles/5
        public IHttpActionResult Delete(int id)
        {
            var deleteWaterBottle = WaterBottlesDbContext.waterBottles.Find(id);

            if(deleteWaterBottle == null)
            {
                return BadRequest("There is no water bottle entity with that ID");
            }
            else
            {
                WaterBottlesDbContext.waterBottles.Remove(deleteWaterBottle);
                WaterBottlesDbContext.SaveChanges();
                return Ok($"The water bottle with {id} ID has been deleted.");
            }
        }
    }
}
