using AutoMapper;
using Ecommerce.Core.Entities;
using Ecommerce.Core.Entities.DTO;
using Ecommerce.Core.IRepositories;
using Ecommerce.Infrastructure.Data;
using Ecommerce.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork<Products> unitOfWork;
        private readonly IMapper mapper;
        public ApiResponse response;

        public ProductController(IUnitOfWork<Products> unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            response = new ApiResponse();
        }
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetAll()
        {
            var product = await unitOfWork.productRepository.GetAll();
            var check = product.Any();
            if (check) 
            {
                response.StatusCode = System.Net.HttpStatusCode.OK;
                response.IsSuccess = check;
                var mappedProducts = mapper.Map<IEnumerable<Products>, IEnumerable<ProductDTO>>(product);
                response.Result = mappedProducts;
                return response;
            }
            else
            {
                response.ErrorMessages = "No Products Founds";
                response.StatusCode = System.Net.HttpStatusCode.OK;
                response.IsSuccess = false;
                return response;
            }
            return Ok(product);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var product = await unitOfWork.productRepository.GetById(id);
            return Ok(product);
        }
        [HttpPost]
        public async Task<ActionResult> CreateProduct(ProductFormDTO product)
        {
            var pro = mapper.Map<Products>(product);// post using mapper
            await unitOfWork.productRepository.Create(pro);
            unitOfWork.save();
            return Ok(pro);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateProduct(int id, Products product) 
        {
            unitOfWork.productRepository.Update(product);
            await unitOfWork.save();
            return Ok(product);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            unitOfWork.productRepository.Delete(id);
            await unitOfWork.save();
            return Ok();
        }
        [HttpGet("Product/{cat_Id}")]
        public async Task<ActionResult<ApiResponse>> GetProductByCatId(int cat_Id)
        {
            var products =await unitOfWork.productRepository.GetAllProductsByCategoryId(cat_Id);
            var mappedProducts = mapper.Map<IEnumerable<Products>, IEnumerable<ProductDTO>>(products);
             return Ok(mappedProducts);
        }



    }
}
