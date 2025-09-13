using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CustomerOrder.API.Controllers
{
    [ApiController]
    [Route("v1/api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
           
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> getAllUsers()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
