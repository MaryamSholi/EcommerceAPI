using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Entities.DTO
{
    public class OrdersDTO
    {
        public int Id { get; set; }
        public int LocalUserId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public string? User_Name { get; set; }
    }
}
