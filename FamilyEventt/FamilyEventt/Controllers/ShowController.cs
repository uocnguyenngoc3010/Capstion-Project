using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.AspNetCore.Mvc;

namespace FamilyEventt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowController : ControllerBase
    {
        private IShow _showService;
        public ShowController(IShow showService)
        {
            this._showService = showService;
        }
        [Route("get-all")]
        [HttpGet]
        public async Task <IActionResult> GetAll()
        {

            ResponseAPI<List<Show>> responseAPI = new ResponseAPI<List<Show>>();
            try
            {
                responseAPI.Data =await this._showService.GetAllShows();
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("insert-show/{show}")]
        [HttpPost]
        public async Task <IActionResult> InsertShow(ShowDto show)
        {
            ResponseAPI<List<Show>> responseAPI = new ResponseAPI<List<Show>>();
            try
            {
                responseAPI.Data =await this._showService.InsertShow(show);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = "false";
                return BadRequest(responseAPI);
            }
        }
        [Route("search-by-name-show/{name}")]
        [HttpGet]
        public async Task <IActionResult> SearchNameShows(string name)
        {
            ResponseAPI<List<Show>> responseAPI = new ResponseAPI<List<Show>>();
            try
            {
                responseAPI.Data =await this._showService.SearchByNameShows(name);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("update-show/{Show}")]
        [HttpPut]
        public async Task <IActionResult> UpdateShow(ShowDto upShow)
        {
            ResponseAPI<List<Show>> responseAPI = new ResponseAPI<List<Show>>();
            try
            {
                responseAPI.Data =await this._showService.UpdateShow(upShow);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("delete-show/{id}")]
        [HttpPut]
        public async Task <IActionResult> DeleteShow(int id)
        {
            ResponseAPI<List<Show>> responseAPI = new ResponseAPI<List<Show>>();
            try
            {
                responseAPI.Data =await this._showService.DeleteShow(id);
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
