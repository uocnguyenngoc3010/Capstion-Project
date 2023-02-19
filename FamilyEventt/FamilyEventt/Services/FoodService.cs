using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyEventt.Services
{
    public class FoodService : IFood
    {
        protected readonly FamilyEventContext context;
        public FoodService(FamilyEventContext context)
        {
            this.context = context;
        }

        public async Task<bool> DeleteFood(int id)
        {
            try
            {
                Food food = await this.context.Food.FirstOrDefaultAsync(x => x.ProductId == id);
                if (food != null)
                {

                    food.Status = false;
                    this.context.SaveChanges();
                    return true;

                }
                else
                {
                    throw new Exception("Not Found Name Product!");
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Task<List<Food>> GetAllFoods()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertFood(FoodDto food)
        {
            throw new NotImplementedException();
        }

        public Task<List<Food>> SearchByNameFoods(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateFood(FoodDto upFood)
        {
            throw new NotImplementedException();
        }
    }
}
