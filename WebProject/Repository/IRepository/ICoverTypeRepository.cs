using WebProject.Models;

namespace WebProject.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType obj);
        
    }
}
