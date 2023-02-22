﻿using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.AspNetCore.Mvc;

namespace FamilyEventt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecorationProductController :ControllerBase
    {
        private IDecorationProductService _decorationProduct;
        public DecorationProductController(IDecorationProductService decorationProduct)
        {
            this._decorationProduct = decorationProduct;
        }
        
        [Route("get-all-decoration-product")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._decorationProduct.GetAllDecorationProduct();
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Data = false;
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        
        [Route("get-decoration-product-by-id")]
        [HttpGet]
        public async Task<IActionResult> GetDecorationProductById(int? decorationId, int? productId)
        {

            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._decorationProduct.GetDecorationProductById(decorationId, productId);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Data = false;
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        
        [Route("filter-decoration-product")]
        [HttpGet]
        public async Task<IActionResult> FilterDecorationProduct(int? decorationId, int? productId, decimal? minPrice, decimal? maxPrice, int? quantity, bool? quantityOption)
        {

            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._decorationProduct.FilterDecorationProducts(decorationId, productId, minPrice, maxPrice, quantity, quantityOption);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Data = false;
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("add-decoration-product")]
        [HttpPost]
        public async Task<IActionResult> AddDecorationProduct(DecorationProductDto decorationProductDto)
        {

            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._decorationProduct.AddDecorationProduct(decorationProductDto);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Data = false;
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("update-decoration-product")]
        [HttpPut]
        public async Task<IActionResult> UpdateDecorationProduct(DecorationProductDto decorationProduct)
        {

            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._decorationProduct.UpdateDecorationProduct(decorationProduct);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Data = false;
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("delete-decoration-product")]
        [HttpDelete]
        public async Task<IActionResult> DeleteDecorationProduct(int[] id)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._decorationProduct.DeleteDecorationProductById(id);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Data = false;
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
    }
}
