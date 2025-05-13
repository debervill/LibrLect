using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibrLect.Model;

namespace LibrLect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly ApplicationContext _context;

        public UsersController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        // GET: Users
        public async Task<ActionResult<IEnumerable<Users>>> GetAll() => await _context.User.ToListAsync();


        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetById(int id)
        {
            var user = await _context.User.FindAsync(id);
            return user is null ? NotFound() : user;
        }

        [HttpPost]
        public async Task<ActionResult<Users>> Create(Users user)
        {
            _context.User.Add(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id =user.Id }, user);
        }


    }
}