using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FamilyEventt.Services
{
    public class GameService : IGame
    {
        protected readonly FamilyEventContext context;
        public GameService(FamilyEventContext context)
        {
            this.context = context;
        }

        public async Task <bool> DeleteGame(int id)
        {
            try
            {
                Game game = await this.context.Game.FirstOrDefaultAsync(x => x.GameId == id);
                if (game != null)
                {

                    game.Status = false;
                    this.context.SaveChanges();
                    return true;

                }
                else
                {
                    throw new Exception("Not Found Game!");
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task <List<Game>> GetAllGames()
        {
            try
            {
                var data =await this.context.Game.Where(x => x.Status).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task <bool> InsertGame(GameDto game)
        {
            try
            {
                var _game = new Game();
                _game.GameId = game.GameId;
                _game.Name = game.Name;
                _game.Price = game.Price;
                _game.Details = game.Details;
                _game.Rules = game.Rules;
                _game.Reward = game.Reward;
                _game.Supplies = game.Supplies;
                _game.Image = game.Image;
                _game.Status = game.Status;
                await this.context.Game.AddAsync(_game);
                this.context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task <List<Game>> SearchByNameGames(string name)
        {
            try
            {
                var data = await this.context.Game.Where(x => x.Status && x.Name.Contains(name)).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task <bool> UpdateGame(GameDto upGame)
        {
            try
            {
                Game game = await this.context.Game.FirstOrDefaultAsync(x => x.GameId == upGame.GameId);
                if (game != null)
                {
                    game.Name = upGame.Name;
                    game.Price = upGame.Price;
                    game.Details = upGame.Details;
                    game.Rules = upGame.Rules;
                    game.Reward = upGame.Reward;
                    game.Supplies = upGame.Supplies;
                    game.Image = upGame.Image;
                    game.Status = upGame.Status;
                    this.context.SaveChanges();
                    return true;

                }
                else
                {
                    throw new Exception("Not Found Name Game!");
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
