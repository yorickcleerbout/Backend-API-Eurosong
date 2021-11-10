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
    public class VotesController : ControllerBase
    {
        private IEurosongDataContext _data;
        public VotesController(IEurosongDataContext data)
        {
            _data = data;
        }

        // Get all Votes
        [HttpGet]
        public ActionResult<IEnumerable<Vote>> Get()
        {
            return Ok(_data.GetVotes());
        }

        // Get Vote by {id}
        [HttpGet("{id}")]
        public ActionResult<Vote> Get(int id)
        {
            Vote v = _data.GetVote(id);
            if (v != null) return Ok(v);

            return NotFound("Vote not found! Try another ID!");
        }


        // Add new vote to database
        [HttpPost]
        [Authorize(Policy = "BasicAuthentication")]
        public ActionResult Post([FromBody] Vote vote)
        {
            _data.AddVote(vote);
            return Ok("The Vote has been succesfully added!");
        }

        // Update vote by {id}
        [HttpPut("{id}")]
        [Authorize(Policy = "BasicAuthentication", Roles = "admin")]
        public ActionResult<int> Put([FromBody] Vote vote, int id)
        {
            Vote v = _data.GetVote(id);
            if (v != null)
            {
                _data.UpdateVote(vote, id);
                return Ok("The vote with id '" + id + "' has been updated succesfully!");
            }
            else
            {
                return NotFound("Vote not found! Try another ID!");
            }
            

        }

        // Delete vote by {id}
        [HttpDelete("{id}")]
        [Authorize(Policy = "BasicAuthentication", Roles = "admin")]
        public ActionResult<int> Delete(int id)
        {
            Vote v = _data.GetVote(id);
            if (v != null)
            {
                _data.DeleteVote(id);
                return Ok("The vote with id '" + id + "' has been deleted succesfully!");
            }
            else
            {
                return NotFound("Vote not found! Try another ID!");
            }
            

        }
    }
}
