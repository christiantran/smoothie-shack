using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using smoothie_shack.Models;
using smoothie_shack.Repositories;

namespace smoothie_shack.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SmoothiesController : Controller
  {
    private readonly SmoothieRepository db;
    public SmoothiesController(SmoothieRepository repo)
    {
      db = repo;
    }

    // GET api/smoothies
    [HttpGet]
    public IEnumerable<Smoothie> Get()
    {
      return db.GetAll();
    }

    // GET api/smoothies/5
    [HttpGet("{id}")]
    public Smoothie Get(int id)
    {
      return db.GetById(id);
    }

    // POST api/smoothies
    [HttpPost]
    public Smoothie Post([FromBody]Smoothie newSmoothie)
    {
      if (ModelState.IsValid)
      {
        return db.AddSmoothie(newSmoothie);
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
