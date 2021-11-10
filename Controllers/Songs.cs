using Eurosong.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eurosong.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SongsController : ControllerBase
    {
        private IEurosongDataContext _data;
        public SongsController(IEurosongDataContext data)
        {
            _data = data;
        }
        
        // Get all songs back or filter on word in title
        [HttpGet]
        public ActionResult<IEnumerable<Song>> Get(string word = "")
        {
            if (word != "") return Ok(_data.GetSongs(word).ToList());
            return Ok(_data.GetSongs());
        }

        // Get Song by {id}
        [HttpGet("{id}")]
        public ActionResult<Song> Get(int id)
        {
            Song s = _data.GetSong(id);
            if (s != null) return Ok(s);

            return NotFound("Song not found! Try another ID!");
        }

        // Get votes by song {id}
        [HttpGet("{id}/votes")]
        public ActionResult<IEnumerable<Vote>> GetVotesOfSong(int id)
        {
            List<Vote> v = _data.GetVotesBySongID(id).ToList();
            if (v != null && v.Count > 0) return Ok(v);
            return NotFound("No votes found for the song with ID '"+ id +"'! Try another ID!");
            
        }

        // Get points for song {id}
        [HttpGet("{id}/points")]
        public ActionResult<int> GetPointsOfSong(int id)
        {
            int points = _data.GetPointsBySongID(id);
            if (points > 0) return Ok(points);
            return NotFound("No points found for the song with ID '" + id + "'! Try another ID!");

        }

        // Add new song to database
        [HttpPost]
        [Authorize(Policy = "BasicAuthentication")]
        public ActionResult Post([FromBody] Song song)
        {
            _data.AddSong(song);
            return Ok("The song has been succesfully added!");
        }

        // Update song by {id}
        [HttpPut("{id}")]
        [Authorize(Policy = "BasicAuthentication", Roles = "admin")]
        public ActionResult<int> Put([FromBody] Song song, int id)
        {
            _data.UpdateSong(song, id);
            return Ok("The song with id '" + id + "' has been updated succesfully!");

        }

        // Delete song by {id}
        [HttpDelete("{id}")]
        [Authorize(Policy = "BasicAuthentication", Roles = "admin")]
        public ActionResult<int> Delete(int id)
        {
            _data.DeleteSong(id);
            return Ok("The song with id '" + id + "' has been deleted succesfully!");

        }


    }
}
