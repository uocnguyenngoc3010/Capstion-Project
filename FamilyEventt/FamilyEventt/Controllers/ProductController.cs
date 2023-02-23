using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FamilyEventt.Controllers
{
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }
        [Route("get-all")]
        [HttpGet]
        public async Task  <IActionResult> GetAll()
        {

            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data =await this._productService.GetAllProducts();
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("search-by-name-product/{name}")]
        [HttpGet]
        public async Task <IActionResult> SearchNameProduct(string name)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data =await this._productService.SearchByNameProducts(name);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("insert-product")]
        [HttpPost]
        public async Task <IActionResult> InsertProduct(ProductDto iProduct)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._productService.InsertProduct(iProduct);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = "false";
                return BadRequest(responseAPI);
            }
        }
        [Route("delete-product")]
        [HttpPut]
        public async Task <IActionResult> DeleteProduct([FromQuery]List<int> id)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                    responseAPI.Data = await this._productService.DeleteProduct(id);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("update-product")]
        [HttpPut]
        public async Task <IActionResult> UpdateProduct(ProductDto upProduct)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data =await this._productService.UpdateProduct(upProduct);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("filter-product")]
        [HttpGet]
        public async Task<IActionResult> FilterProduct(string? name, decimal? minPrice, decimal? maxPrice, string? supplier, int? qty, bool? qtyOption = true)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._productService.FilterProductByManyOption(name, minPrice, maxPrice, supplier, qty, qtyOption);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

    }

}
