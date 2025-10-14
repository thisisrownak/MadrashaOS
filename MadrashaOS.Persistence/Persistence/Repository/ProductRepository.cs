using MadrashaOS.Application.Interfaces;
using MadrashaOS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MadrashaOS.Infrastructure.Persistence.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync() => await _context.Products.ToListAsync();
        public async Task<Product?> GetByIdAsync(int id) => await _context.Products.FindAsync(id);
        public async Task AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Products.FindAsync(id);
            if (entity is null) return;
            _context.Products.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
