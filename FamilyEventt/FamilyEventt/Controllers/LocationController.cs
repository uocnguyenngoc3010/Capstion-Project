using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FamilyEventt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private ILocation _locationService;
        public LocationController(ILocation locationService)
        {
            this._locationService = locationService;
        }
        [Route("get-all")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._locationService.GetAllLocations();
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("insert-location/{location}")]
        [HttpPost]
        public async Task<IActionResult> InsertLocation(LocationDto location)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._locationService.InsertLocation(location);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = "false";
                return BadRequest(responseAPI);
            }
        }
        [Route("search-by-name-location/{name}")]
        [HttpGet]
        public async Task<IActionResult> SearchNameLocation(string name)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._locationService.SearchByNameLocations(name);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("update-location/{Location}")]
        [HttpPut]
        public async Task<IActionResult> UpdateLocation(LocationDto upLocation)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._locationService.UpdateLocation(upLocation);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("delete-location/{id}")]
        [HttpPut]
        public async Task<IActionResult> DeleteLocation(int id)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._locationService.DeleteLocation(id);
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
