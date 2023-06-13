using Microsoft.EntityFrameworkCore;
using OnlineShop.Api.Data;
using OnlineShop.Api.Entities;
using OnlineShop.Api.Repositories.Contracts;

namespace OnlineShop.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private OnlineShopDbContext _db;
        public ProductRepository(OnlineShopDbContext dbContext)
        {
            dbContext = _db;
        }
        public Task<IEnumerable<ProductCategory>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await _db.Products.ToListAsync();

            return products;
        }
    }
}
