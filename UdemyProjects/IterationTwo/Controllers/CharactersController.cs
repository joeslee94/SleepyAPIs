using CharactersApiTwo.Data;
using CharactersApiTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CharactersApiTwo.Controllers
{
    public class CharactersController : ApiController
    {
        CharactersDbContext charactersDbContext = new CharactersDbContext();
        // GET: api/Characters
        
        //[HttpGet]
        //public IEnumerable<Characters> Get()
        //{
        //    return charactersDbContext.Characters;
        //}
        
        [HttpGet]
        public IHttpActionResult Get()
        {
            var characters = charactersDbContext.Characters;
            return Ok(characters);
        }

        [HttpGet]
        public IHttpActionResult GetCharacters(string sort)
        {
            IQueryable<Characters> characters;
            switch (sort)
            {
                case "desc":
                    characters = charactersDbContext.Characters.OrderByDescending(x => x.Age);
                    break;
                case "asc":
                    characters = charactersDbContext.Characters.OrderBy(x => x.Age);
                    break;
                case "name":
                    characters = charactersDbContext.Characters.OrderBy(x => x.Name);
                    break;
                default:
                    characters = charactersDbContext.Characters.OrderBy(x => x.Id);
                    break;
            }
            return Ok(characters);
        }
        [HttpGet]
        [Route("api/Characters/SearchCharacter/{type=}")]
        public IHttpActionResult SearchCharacter(string type)
        {
            var searchedCharacter = charactersDbContext.Characters.Where(x => x.Name.StartsWith(type));
            return Ok(searchedCharacter);
        }

        // GET: api/Characters/5
        [HttpGet]
        public Characters GetCharacter(int id)
        {
            var getCharacter = charactersDbContext.Characters.Find(id);
            return getCharacter;
        }

        // POST: api/Characters
        public IHttpActionResult Post([FromBody]Characters aCharacter)
        {
            charactersDbContext.Characters.Add(aCharacter);
            charactersDbContext.SaveChanges();
            
            if (aCharacter == null || !ModelState.IsValid)
            {
                return BadRequest("We cannot accept a null entity into our database");
            }
            
            return Ok("Entity added to database");
        }

        // PUT: api/Characters/5
        public IHttpActionResult Put(int id, [FromBody]Characters aCharacter)
        {
            var putCharacter = charactersDbContext.Characters.FirstOrDefault(x => x.Id == id); //NEED LAMBDA EXPRESSION

            if (putCharacter == null)
            {
                return BadRequest($"There is not a valid entity at {id} ID.");
            }
            else
            {
                putCharacter.Age = aCharacter.Age;
                putCharacter.Name = aCharacter.Name;
                putCharacter.FavFood = aCharacter.FavFood;
                putCharacter.PlotImportance = aCharacter.PlotImportance;
                charactersDbContext.SaveChanges();
            }
            return Ok($"The entity at {id} ID has been updated.");
        }

        // DELETE: api/Characters/5
        public IHttpActionResult Delete(int id)
        {
            var deleteCharacter = charactersDbContext.Characters.Find(id);

            if (deleteCharacter == null)
            {
                return BadRequest($"There is no valid identity at ID {id}");
            }
            else
            {
                charactersDbContext.Characters.Remove(deleteCharacter);
                charactersDbContext.SaveChanges();
            }
            return Ok($"The entity at {id} ID has been removed.");
        }
    }
}
