using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.AspNetCore.Mvc;

namespace FamilyEventt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private IGame _gameService;
        public GameController(IGame gameService)
        {
            this._gameService = gameService;
        }
        [Route("get-all")]
        [HttpGet]
        public async Task <IActionResult> GetAll()
        {

            ResponseAPI<List<Game>> responseAPI = new ResponseAPI<List<Game>>();
            try
            {
                responseAPI.Data =await this._gameService.GetAllGames();
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("search-by-name-Game/{name}")]
        [HttpGet]
        public async Task <IActionResult> SearchByNameGames(string name)
        {
            ResponseAPI<List<Game>> responseAPI = new ResponseAPI<List<Game>>();
            try
            {
                responseAPI.Data =await this._gameService.SearchByNameGames(name);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("update-game/{Game}")]
        [HttpPut]
        public async Task <IActionResult> UpdateGame(GameDto upGame)
        {
            ResponseAPI<List<Game>> responseAPI = new ResponseAPI<List<Game>>();
            try
            {
                responseAPI.Data =await this._gameService.UpdateGame(upGame);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = ex.Message;
                return BadRequest(responseAPI);
            }
        }
        [Route("insert-game/{game}")]
        [HttpPost]
        public async Task <IActionResult> InsertDrink(GameDto game)
        {
            ResponseAPI<List<Game>> responseAPI = new ResponseAPI<List<Game>>();
            try
            {
                responseAPI.Data =await this._gameService.InsertGame(game);
                return Ok(responseAPI);
            }
            catch (Exception ex)
            {
                responseAPI.Message = "false";
                return BadRequest(responseAPI);
            }
        }
        [Route("delete-game/{id}")]
        [HttpPut]
        public async Task <IActionResult> DeleteGame(int id)
        {
            ResponseAPI<List<Game>> responseAPI = new ResponseAPI<List<Game>>();
            try
            {
                responseAPI.Data =await this._gameService.DeleteGame(id);
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
