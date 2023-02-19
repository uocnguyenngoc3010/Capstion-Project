using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace FamilyEventt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinkController : ControllerBase
    {
        private IDrink _drinkService;
        public DrinkController(IDrink drinkService)
        {
            this._drinkService = drinkService;
        }
        [Route("get-all")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
             
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._drinkService.GetAllDrinks();
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("insert-drink/{drink}")]
        [HttpPost]
        public async Task <IActionResult>  InsertDrink(DrinkDto drink)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._drinkService.InsertDrink(drink);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = "false";
                return BadRequest(responseAPI);
            }
        }
        [Route("search-by-name-drink/{name}")]
        [HttpGet]
        public async Task <IActionResult>  SearchNameDrink(string name)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._drinkService.SearchByNameDrinks(name);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("update-drink/{Drink}")]
        [HttpPut]
        public async Task <IActionResult>  UpdateDrink(DrinkDto upDrink)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._drinkService.UpdateDrink(upDrink);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("delete-drink/{id}")]
        [HttpDelete]
        public async Task <IActionResult>  DeleteDrink(int id)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._drinkService.DeleteDrink(id);
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
