using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICompanyRepository
    {
        Task<Company> GetCompanyByIdAsync(int id);
        Task<IReadOnlyList<Company>> GetCompanysAsync();
    }
}