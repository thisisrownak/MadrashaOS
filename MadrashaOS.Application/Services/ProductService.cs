using MadrashaOS.Application.Interfaces;
using MadrashaOS.Domain.Entities;

namespace MadrashaOS.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Product>> GetAllAsync() => await _repo.GetAllAsync();

        public async Task<Product?> GetByIdAsync(int id) => await _repo.GetByIdAsync(id);

        public async Task AddAsync(Product product)
        {
            // business rules here
            await _repo.AddAsync(product);
        }
    }
}
