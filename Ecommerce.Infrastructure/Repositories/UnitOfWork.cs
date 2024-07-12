using Ecommerce.Core.IRepositories;
using Ecommerce.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Repositories
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly ApplicationDbContext dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            productRepository = new ProductRepository(dbContext);
            ordersRepository = new OrdersRepository(dbContext);
        }
        public IProductRepository productRepository { get; set; }
        public ICategoryRepository categoryRepository { get; set; }
        public IOrdersRepository ordersRepository { get; set; }

        public async Task<int> save() => await dbContext.SaveChangesAsync();
        
    }
}
