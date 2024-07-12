using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.IRepositories
{
    public interface IOrdersRepository : IGenericRepository<Orders>
    {
        public Task<IEnumerable<Orders>> GetAllOrdersByUserId(int User_Id);

    }
}
