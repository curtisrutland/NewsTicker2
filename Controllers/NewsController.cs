using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsTicker.Entities;

namespace NewsTicker.Controllers
{
    [Route("api/[controller]")]
    public class NewsController : Controller
    {
        private NewsTickerContext _db;

        public NewsController(NewsTickerContext db) => _db = db;

        [HttpGet("all")]
        public async Task<IEnumerable<NewsItem>> GetAllNews() => await _db.Items.ToArrayAsync();

        [HttpGet("{category}/{count}")]
        public async Task<IEnumerable<NewsItem>> GetGroup(string category, int count) =>
            await _db.Items.Where(i => i.Category == category).OrderByDescending(i => i.CreatedOn).Take(count).ToArrayAsync();

        [HttpPost]
        public async Task<IActionResult> Post(NewsItem model)
        {
            try
            {
                _db.Items.Add(model);
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
            return Ok();
        }
    }
}