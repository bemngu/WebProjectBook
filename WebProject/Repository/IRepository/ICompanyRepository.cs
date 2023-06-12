using WebProject.Models;

namespace WebProject.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company obj);
        
    }
}
