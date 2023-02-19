using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FamilyEventt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodTypeController : ControllerBase
    {
        private IFoodType _foodTypeService;
        public FoodTypeController(IFoodType foodTypeService)
        {
            this._foodTypeService = foodTypeService;
        }

        [Route("get-all")]
        [HttpGet]
        public async Task <IActionResult> GetAll()
        {

            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._foodTypeService.GetAllFoodTypes();
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("insert-foodType/{FoodType}")]
        [HttpPost]
        public async Task <IActionResult> InsertFoodType(FoodTypeDto foodType)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data =await this._foodTypeService.InsertFoodType(foodType);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = "false";
                return BadRequest(responseAPI);
            }
        }
        [Route("search-by-name-FoodType/{nameFoodType}")]
        [HttpGet]
        public async Task <IActionResult> SearchByNameFoodTypes(string name)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._foodTypeService.SearchByNameFoodTypes(name);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("update-FoodType/{FoodType}")]
        [HttpPut]
        public async Task <IActionResult> UpdateFoodType(FoodTypeDto upFoodType)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._foodTypeService.UpdateFoodType(upFoodType);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("delete-FoodType/{id}")]
        [HttpPut]
        public async Task <IActionResult> DeleteFoodType(int id)
        {
            ResponseAPI responseAPI = new ResponseAPI();
            try
            {
                responseAPI.Data = await this._foodTypeService.DeleteFoodType(id);
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
