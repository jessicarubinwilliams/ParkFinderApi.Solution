using ParkFinder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkFinder.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParkFinderContext _db;

    public ParksController(ParkFinderContext db)
    {
      _db = db;
    }

    //GET api/parks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>>Get(string name, string location, bool isNationalPark, bool isOtherFederalLand, bool isStatePark, bool isCountyPark, bool isCityOrMunicipalPark, bool isPrivatePark, bool isFree, string rating)
    {
      var query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }

      if (isNationalPark == true)
      {
        query = query.Where(entry => entry.IsNationalPark == true);
      }

      if (isOtherFederalLand == true)
      {
        query = query.Where(entry => entry.IsOtherFederalLand == true);
      }

      if (isStatePark == true)
      {
        query = query.Where(entry => entry.IsStatePark == true);
      }

      if (isCountyPark == true)
      {
        query = query.Where(entry => entry.IsCountyPark == true);
      }

      if (isCityOrMunicipalPark == true)
      {
        query = query.Where(entry => entry.IsCityOrMunicipalPark == true);
      }
      
      if (isPrivatePark == true)
      {
        query = query.Where(entry => entry.IsPrivatePark == true);
      }
      
      if (isFree == true)
      {
        query = query.Where(entry => entry.IsFree == true);
      }

      if (rating != null)
      {
        query = query.Where(entry => entry.Rating == rating);
      }
      if (isFree == true)
      {
        query = query.Where(entry => entry.IsFree == true);
      }

      return await query.ToListAsync();
    }

    //POST api/parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    //GET api/Parks/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      var park = await _db.Parks.FindAsync(id);

      if (park == null)
      {
        return NotFound();
      }

      return park;
    }

    //PUT api/Parks/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Entry(park).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }
    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }

    //DELETE api/Parks/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}