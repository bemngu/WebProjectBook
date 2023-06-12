using WebProject.Models;

namespace WebProject.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
        
    }
}
