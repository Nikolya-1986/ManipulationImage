using ManipulationImage.Models;

namespace ManipulationImage.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> AddProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product);
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product?> FindProductByIdAsync(int id);
        Task DeleteProductAsync(Product product);   
    }
}