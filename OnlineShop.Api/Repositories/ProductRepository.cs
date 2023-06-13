using Microsoft.EntityFrameworkCore;
using OnlineShop.Api.Data;
using OnlineShop.Api.Entities;
using OnlineShop.Api.Repositories.Contracts;

namespace OnlineShop.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly OnlineShopDbContext dbContext;
        public ProductRepository(OnlineShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.dbContext.Products.ToListAsync();

            return products;
        }

        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.dbContext.ProductCategories.ToListAsync();

            return categories;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
