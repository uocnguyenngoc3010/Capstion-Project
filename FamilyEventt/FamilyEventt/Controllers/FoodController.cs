using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.AspNetCore.Mvc;

namespace FamilyEventt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase {
        private IFood _foodService;
        public FoodController(IFood foodService)
        {
            this._foodService = foodService;
        }
        [Route("get-all")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            ResponseAPI<List<Food>> responseAPI = new ResponseAPI<List<Food>>();
            try
            {
                responseAPI.Data = await this._foodService.GetAllFoods();
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("get-food-by-id")]
        [HttpGet]
        public async Task<IActionResult> GetAllFoodById(int id)
        {

            ResponseAPI<Food> responseAPI = new ResponseAPI<Food>();
            try
            {
                responseAPI.Data = await this._foodService.GetAllFoodById(id);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }

        [Route("update-food/{Food-name}")]
        [HttpPut]
        public async Task<IActionResult> UpdateFood(FoodDto upFood)
        {
            ResponseAPI<List<Food>> responseAPI = new ResponseAPI<List<Food>>();
            try
            {
                responseAPI.Data = await this._foodService.UpdateFood(upFood);
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
