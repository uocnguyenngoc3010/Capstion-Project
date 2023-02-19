using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FamilyEventt.Controllers
{
    public class ProductController : ControllerBase
    {
        private IProduct _productService;
        public ProductController(IProduct productService)
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
        [Route("insert-product/{product}")]
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
        [Route("delete-product/{id}")]
        [HttpPut]
        public async Task <IActionResult> DeleteProduct(int id)
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
        [Route("update-product/{Product}")]
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

    }

}
