using System.Collections.Generic;
using System.Linq;
using API.Data;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult<List<Company>> GetCompanies()
        {
            var companys = _context.Companys.ToList();
            return Ok(companys);
        }

        [HttpGet("{id}")]
        public string GetCompany(int id)
        {
            return "single company";
        }



    }
}