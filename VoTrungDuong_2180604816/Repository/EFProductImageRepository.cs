using Microsoft.EntityFrameworkCore;
using VoTrungDuong_2180604816.Models;
using VoTrungDuong_2180604816.Repository;

namespace TranDuyKhoa_2180605345.Repositories
{
    public class EFProductImageRepository : IProductImageRepository
    {
        private readonly ApplicationDbContext _context;

        public EFProductImageRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ProductImage>> GetAllAsync()
        {
            return await _context.ProductImages.ToListAsync();
        }
        public async Task<ProductImage> GetByIdAsync(int id)
        {
            return await _context.ProductImages.FindAsync(id);
        }
        public async Task<IEnumerable<ProductImage>> GetByProductIdAsync(int id)
        {
            return await _context.ProductImages.Where(x => x.ProductId == id).ToListAsync();
        }
        public async Task AddAsync(ProductImage productImage)
        {
            _context.ProductImages.Add(productImage);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(ProductImage productImage)
        {
            _context.ProductImages.Update(productImage);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var productImage = await _context.ProductImages.FindAsync(id);
            _context.ProductImages.Remove(productImage);
            await _context.SaveChangesAsync();
        }
    }
}
