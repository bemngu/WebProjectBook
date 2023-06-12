using WebProject.Models;

namespace WebProject.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
        
    }
}
