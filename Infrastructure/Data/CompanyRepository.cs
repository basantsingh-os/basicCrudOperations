using System.Collections.Generic;
using System.Threading.Tasks;
using Core;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly StoreContext _context;
        public CompanyRepository(StoreContext context)
        {
            _context = context;

        }
        public async Task<Company> GetCompanyByIdAsync(int id)
        {
            return await _context.Companys.FindAsync(id);
        }

        public async Task<IReadOnlyList<Company>> GetCompanysAsync()
        {
            return await _context.Companys.ToListAsync();
        }
    }
}