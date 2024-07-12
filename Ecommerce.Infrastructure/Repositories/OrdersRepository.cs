using Ecommerce.Core.Entities;
using Ecommerce.Core.IRepositories;
using Ecommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Repositories
{
    public class OrdersRepository : GenericRepository<Orders>, IOrdersRepository
    {
        private readonly ApplicationDbContext dbContext;

        public OrdersRepository (ApplicationDbContext dbContext) : base (dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Orders>> GetAllOrdersByUserId(int User_Id)
        {

            var orders = await dbContext.Orders
                .Where(c => c.LocalUserId == User_Id)
                .ToListAsync();
            return orders;

        }
    }
}
