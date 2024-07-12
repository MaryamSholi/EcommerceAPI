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
        public ApiResponse response;

        public OrdersController(IUnitOfWork<Orders> unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            response = new ApiResponse();

        }
        [HttpGet("Orders/{User_Id}")]
        public async Task<ActionResult<ApiResponse>> GetOrdersByUserId(int User_Id)
        {
            var orders = await unitOfWork.ordersRepository.GetAllOrdersByUserId(User_Id);
            return Ok(orders);
        }
    }
}
