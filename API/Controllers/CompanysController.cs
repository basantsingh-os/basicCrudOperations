using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanysController : ControllerBase
    {

        private readonly ICompanyRepository _repo;

        public CompanysController(ICompanyRepository repo)
        {
            _repo = repo;
            

        }

        [HttpGet]
        public async Task<ActionResult<List<Company>>> GetCompanies()
        {
            var companys = await _repo.GetCompanysAsync();
            return Ok(companys);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Company>>> GetGetCompany(int id)
        {
            return Ok(await _repo.GetCompanyByIdAsync(id));
        }

    }
}