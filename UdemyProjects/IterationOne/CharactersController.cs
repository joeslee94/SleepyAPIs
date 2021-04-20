using CharactersApi.Data;
using CharactersApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CharactersApi.Controllers
{
    public class CharactersController : ApiController
    {
        CharactersDbContext charactersDbContext = new CharactersDbContext();
        // GET: api/Characters
        public IEnumerable<Characters> Get()
        {
            return charactersDbContext.Characters;
        }



        // GET: api/Characters/5
        public Characters Get(int Id)
        {
            Characters aCharacter = charactersDbContext.Characters.Find(Id);
            return aCharacter;
        }

        // POST: api/Characters
        public IHttpActionResult Post([FromBody]Characters aCharacter)
        {
            charactersDbContext.Characters.Add(aCharacter);
            charactersDbContext.SaveChanges();
            return StatusCode(HttpStatusCode.Created);
        }

        // PUT: api/Characters/5
        public IHttpActionResult Put(int Id, [FromBody]Characters aCharacter)
        {
            var characterToBeUpdated = charactersDbContext.Characters.FirstOrDefault(x => x.Id == Id);
            
            if (characterToBeUpdated == null)
            {
                return BadRequest("There is no record with that id.");
            }

            characterToBeUpdated.Age = aCharacter.Age;
            characterToBeUpdated.Name = aCharacter.Name;
            charactersDbContext.SaveChanges();
            
            return Ok("Record updated successfully");
        }

        // DELETE: api/Characters/5
        public IHttpActionResult Delete(int Id)
        {
            Characters characterToBeRemoved = charactersDbContext.Characters.Find(Id);

            if (characterToBeRemoved == null)
            {
                return BadRequest($"There was no record found with the Id {Id}.");
            }
            charactersDbContext.Characters.Remove(characterToBeRemoved);
            charactersDbContext.SaveChanges();

            return Ok($"The record at {Id} has been deleted.");
        }
    }
}
