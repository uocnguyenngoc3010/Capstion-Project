using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FamilyEventt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecorationController: ControllerBase
    {
        IDecorationService _decorationService;
        public DecorationController(IDecorationService decorationService)
        {
            this._decorationService = decorationService;
        }
        [Route("get-all-decoration")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._decorationService.GetAllDecoration();
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Data = false;
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("get-decoration-by-id")]
        [HttpGet]
        public async Task<IActionResult> GetDecorationById(int decorationId)
        {

            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._decorationService.GetDecorationById(decorationId);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Data = false;
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("filter-decoration")]
        [HttpGet]
        public async Task<IActionResult> FilterDecoration(string? name, decimal? minPrice, decimal? maxPrice)
        {

            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._decorationService.FilterDecorationBy(name, minPrice, maxPrice);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Data = false;
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("add-decoration")]
        [HttpPost]
        public async Task<IActionResult> AddDecoration(DecorationDto decorationDto)
        {

            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._decorationService.AddDecoration(decorationDto);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Data = false;
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("update-decoration")]
        [HttpPut]
        public async Task<IActionResult> UpdateDecoration(DecorationDto decoration)
        {

            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._decorationService.UpdateDecoration(decoration);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Data = false;
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("delete-decoration")]
        [HttpDelete]
        public async Task<IActionResult> DeleteDecoration(int[] id)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._decorationService.DeleteDecorationById(id);
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
