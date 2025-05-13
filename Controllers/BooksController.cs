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
    public class BooksController : Controller
    {
        private readonly ApplicationContext _context;

        public BooksController(ApplicationContext context)
        {
            _context = context;
        }



        // GET: Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Books>>> GetAll() => await _context.Books.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Books>> GetById(int id)
        {
            var somebook = await _context.Books.FindAsync(id);
            return somebook is null ? NotFound() : somebook;
        }


        [HttpPost]
        public async Task<ActionResult<Books>> Create(Books somebook)
        {
            _context.Books.Add(somebook);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { Id = somebook.id }, somebook);
        }




    }
}
