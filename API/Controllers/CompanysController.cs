using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanysController : ControllerBase
    {
        [HttpGet]
        public string GetCompanies()
        {
            return "list of all companies";
        }

        [HttpGet("{id}")]
        public string GetCompany(int id)
        {
            return "single company";
        }

        
        
    }
}