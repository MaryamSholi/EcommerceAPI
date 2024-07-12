using AutoMapper;
using Ecommerce.Core.Entities;
using Ecommerce.Core.Entities.DTO;
using Ecommerce.Core.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IUnitOfWork<Orders> unitOfWork;
        private readonly IMapper mapper;
        public ApiResponse response;

        public OrdersController(IUnitOfWork<Orders> unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            response = new ApiResponse();

        }
        [HttpGet("Orders/{User_Id}")]
        public async Task<ActionResult<ApiResponse>> GetOrdersByUserId(int User_Id)
        {
            var orders = await unitOfWork.ordersRepository.GetAllOrdersByUserId(User_Id);
            var mappedOrders = mapper.Map<IEnumerable<Orders>, IEnumerable<OrdersDTO>>(orders);
            return Ok(mappedOrders);
        }
    }
}
