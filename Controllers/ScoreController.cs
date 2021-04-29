using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Models.Score> Get()
        {
            using (var db = new Models.roverApiContext())
            {
                IEnumerable<Models.Score> scores = db.Scores.ToList();
                return scores;
            }
        }
    }
}
