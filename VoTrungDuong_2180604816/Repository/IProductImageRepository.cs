using VoTrungDuong_2180604816.Models;

namespace VoTrungDuong_2180604816.Repository
{
    public interface IProductImageRepository
    {
        Task<IEnumerable<ProductImage>> GetAllAsync();
        Task<ProductImage> GetByIdAsync(int id);
        Task<IEnumerable<ProductImage>> GetByProductIdAsync(int id);

        Task AddAsync(ProductImage productImage);
        Task UpdateAsync(ProductImage productImage);
        Task DeleteAsync(int id);
    }
}
