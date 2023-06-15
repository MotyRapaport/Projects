using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SuperHeroesAPI;
using System.Net.Http;
using SuperHeroesAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace SuperHeroesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroesController : ControllerBase
    {
        public readonly DataContext _context;
        public SuperHeroesController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<SuperHeroes>>> GetSuperHeroes()
        {
           return  Ok(await _context.SuperHeroes.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<SuperHeroes>>> CreatSuperHeroes(SuperHeroes hero)
        {
            _context.SuperHeroes.Add(hero);
            await _context.SaveChangesAsync();
            return Ok(await _context.SuperHeroes.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<SuperHeroes>>> UpdateSuperHeroes(SuperHeroes hero)
        {
            var dbHero = await _context.SuperHeroes.FindAsync(hero.Id);
            if(dbHero == null)
            {
                return BadRequest("Hero Not Found!");
            }
            dbHero.Name = hero.Name;
            dbHero.FirstName = hero.FirstName;
            dbHero.LastName = hero.LastName;
            dbHero.Place = hero.Place;
            await _context.SaveChangesAsync();
            return Ok(await _context.SuperHeroes.ToListAsync());
        }
        [HttpDelete]
        public async Task<ActionResult<List<SuperHeroes>>> DeleteSuperHeroes(int id)
        {
            var dbHero = await _context.SuperHeroes.FindAsync(id);
            if (dbHero == null)
            {
                return BadRequest("Hero Not Found!");
            }
            _context.SuperHeroes.Remove(dbHero);
            await _context.SaveChangesAsync();
            return Ok(await _context.SuperHeroes.ToListAsync());
        }


    }
}

