using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanysController : ControllerBase
    {
        private readonly StoreContext _context;
        public CompanysController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Company>>> GetCompanies()
        {
            var companys = await _context.Companys.ToListAsync();
            return Ok(companys);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Company>>> GetGetCompany(int id)
        {
            return Ok(await _context.Companys.FindAsync(id));
        }



    }
}