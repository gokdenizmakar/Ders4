using Ders4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ders4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly TDbContext _dbContext;

        public OrderController()
        {
            _dbContext =new TDbContext();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var orders = _dbContext.Orders.Include(x=>x.WebUsers).ToList();
            return Ok(orders);
        }
    }
}
