using Eurosong.Data;
using Eurosong.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eurosong.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtistsController : ControllerBase
    {
        private IEurosongDataContext _data;

        public ArtistsController(IEurosongDataContext data)
        {
            _data = data;
        }

        // Get all Artists
        [HttpGet]
        public ActionResult<IEnumerable<Artist>> Get()
        {
            return Ok(_data.GetArtists());
        }

        // Get Artist by {id}
        [HttpGet("{id}")]
        public ActionResult<Artist> Get(int id)
        {
            Artist a = _data.GetArtist(id);
            if (a != null) return Ok(a);

            return NotFound("Artist not found! Try another ID!");
        }

        // Get the songs of the artist by {id}
        [HttpGet("{id}/songs")]
        public ActionResult<IEnumerable<Artist>> GetSongsOfArtist(int id)
        {
            List<Song> ss = _data.GetSongsByArtistID(id).ToList();
            if (ss != null && ss.Count > 0) return Ok(ss);
            return NotFound("No songs found for the artist with id '"+ id +"'! Try another ID!");
        }

        // Get the songs of the artist by {id}
        [HttpGet("{id}/picture")]
        public ActionResult<string> GetArtistPicture(int id)
        {
            string picture = _data.GetArtistPicture(id);
            if (picture != null) return Ok(picture);
            return NotFound("There is no picture found of Artist with id '" + id + "'");
        }

        // Add new Artist to database
        [HttpPost]
        [Authorize(Policy = "BasicAuthentication")]
        public ActionResult Post([FromBody] Artist artist)
        {
            _data.AddArtist(artist);
            return Ok("Success");
        }

        // Update artist by {id}
        [HttpPut("{id}")]
        [Authorize(Policy = "BasicAuthentication", Roles = "admin")]
        public ActionResult<int> Put([FromBody] Artist artist, int id)
        {
            _data.UpdateArtist(artist, id);
            return Ok("The artist with id '" + id + "' has been updated succesfully!");

        }

        // Delete artist by {id}
        [HttpDelete("{id}")]
        [Authorize(Policy = "BasicAuthentication", Roles = "admin")]
        public ActionResult<int> Delete(int id)
        {
            _data.DeleteArtist(id);
            return Ok("The artist with id '" + id + "' has been deleted succesfully!");

        }
    }
}
