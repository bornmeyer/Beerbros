using AutoMapper;
using Beerbros.Models;
using Beerbros.Web.Models;
using Beerbros.Web.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Beerbros.Web.Controllers
{
    [Route("api/beers/{beerId}/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {

        // Fields

        private readonly DatabaseContext databaseContext = default!;
        private readonly IMapper mapper = default!;


        // Constructors

        public RatingsController(IMapper mapper, DatabaseContext databaseContext)
        {
            this.mapper = mapper;
            this.databaseContext = databaseContext;
        }

        // Methods

        // GET: api/beers/12345/<RatingsController>
        [HttpGet]
        public IActionResult Get(Int32 beerId)
        {
            var result = databaseContext.Ratings.Where(x => x.BeerId == beerId).ToList();
            return new JsonResult(result);
        }

        // GET api/beers/12345/<RatingsController>/5
        [HttpGet("{id}", Name = "GetRating")]
        public IActionResult Get(int id, int beerId)
        {
            return databaseContext.Ratings.FirstOrDefault(x => x.Id == id && x.BeerId == beerId) switch
            {
                null => NotFound(),
                var rating => new JsonResult(rating)
            };
        }

        // POST api/beers/12345/<RatingsController>
        [HttpPost]
        public IActionResult Post(Int32 beerId, [FromBody] RatingDTO rating)
        {
            Func<RatingDTO, IActionResult> createRanking = ratingDto =>
            {
                ratingDto.BeerId = beerId;
                var newRating = mapper.Map<Rating>(ratingDto);
                databaseContext.Ratings.Add(newRating);
                databaseContext.SaveChanges();
                return CreatedAtAction(nameof(Get), new { beerId = beerId, id = newRating.Id }, newRating);
            };

            return databaseContext.Beers.FirstOrDefault(x => x.Id == beerId) switch
            {
                null => NotFound(),
                _ => createRanking(rating)
            };
        }

        // PATCH api/beers/12345/<RatingsController>/5
        [HttpPatch("{id}")]
        public IActionResult Patch(Int32 beerId, Int32 id, [FromBody] RatingDTO rating)
        {
            Func<RatingDTO, Rating, IActionResult> patchRating = (ratingDto, entity) =>
            {
                var updatedEntity = mapper.Map<Rating>(rating);
                databaseContext.Update(updatedEntity);
                databaseContext.SaveChanges();
                return Ok(updatedEntity);
            };

            return databaseContext.Ratings.FirstOrDefault(x => x.Id == id && x.BeerId == beerId) switch
            {
                null => NotFound(),
                var loadedRating => patchRating(rating, loadedRating)
            };
        }

        // DELETE api/beers/12345/<RatingsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Int32 beerId, Int32 id)
        {
            var entity = databaseContext.Ratings.FirstOrDefault(x => x.BeerId == beerId && x.Id == id);
            databaseContext.Ratings.Remove(entity);
            databaseContext.SaveChanges();
            return Ok();
        }
    }
}
