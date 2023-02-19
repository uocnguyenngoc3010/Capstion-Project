using FamilyEventt.Dto;
using FamilyEventt.Models;

namespace FamilyEventt.Interfaces
{
    public interface IGame
    {
        Task<List<Game>> GetAllGames();
        Task<List<Game>> SearchByNameGames(string name);
        Task<bool> UpdateGame(GameDto upGame);
        Task<bool> InsertGame(GameDto game);
        Task<bool> DeleteGame(int id);
    }
}
