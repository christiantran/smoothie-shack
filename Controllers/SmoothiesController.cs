using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using smoothie_shack.Models;

namespace smoothie_shack.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SmoothiesController : ControllerBase
  {
    List<Smoothie> Smoothies = Program.Smoothies;

    // GET api/smoothies
    [HttpGet]
    public ActionResult<IEnumerable<Smoothie>> Get()
    {
      return Smoothies;
    }

    // GET api/smoothies/5
    [HttpGet("{id}")]
    public ActionResult<Smoothie> Get(int id)
    {
      if (id > -1 && id < Smoothies.Count)
      {
        return Smoothies[id];
      }
      return null;
    }

    // POST api/smoothies
    [HttpPost]
    public ActionResult<List<Smoothie>> Post([FromBody]Smoothie newSmoothie)
    {
      if (ModelState.IsValid)
      {
        Smoothies.Add(newSmoothie);
        return Smoothies;
      }
      return null;
    }

    // PUT api/smoothies/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/smoothies/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
