﻿using Ecommerce.Core.Entities;
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
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Products>> GetAllProductsByCategoryId(int cat_Id)
        {
            //Eager Loading

            //var products = (IEnumerable<Products>)await dbContext.Products.Include(x => x.Category)
            //    .Where(c => c.CategoryId == cat_Id)
            //    .ToListAsync();
            //return products; 

            //Explicit Loading

            //var products = await dbContext.Products
            //    .Where(c => c.CategoryId == cat_Id)
            //    .ToListAsync();
            //foreach (var product in products)
            //{
            //    await dbContext.Entry(product).Reference(r => r.Category).LoadAsync();
            //}
            //return products;

            //Lazy Loading

            var products = await dbContext.Products
                .Where(c => c.CategoryId == cat_Id)
                .ToListAsync();
            return products;
        }


    }
}
