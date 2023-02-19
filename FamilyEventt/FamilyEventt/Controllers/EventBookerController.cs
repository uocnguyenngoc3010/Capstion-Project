using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FamilyEventt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventBookerController : ControllerBase
    {
        private IEventBooker _eventBookerService;
        public EventBookerController(IEventBooker eventBookerService)
        {
            this._eventBookerService = eventBookerService;
        }
        [Route("get-all")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._eventBookerService.GetAllEventBookers();
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("insert-eventBooker/EventBooker")]
        [HttpPost]
        public async Task<IActionResult> InsertEventBooker([FromBody] EventBookerDto eventBooker)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._eventBookerService.InsertEventBooker(eventBooker);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = "false";
                return BadRequest(responseAPI);
            }
        }
        [Route("search-by-name-EventBooker/{name}")]
        [HttpGet]
        public async Task<IActionResult> SearchNameEventBooker(string name)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._eventBookerService.SearchByNameEventBooker(name);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("update-event-booker/{EventBooker}")]
        [HttpPut]
        public async Task<IActionResult> UpdateEventBooker(EventBookerDto upEventBooker)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._eventBookerService.UpdateEventBooker(upEventBooker);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("delete-event-booker/{id}")]
        [HttpPut]
        public async Task<IActionResult> DeleteEventBooker(int id)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._eventBookerService.DeleteEventBooker(id);
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
