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

        public async Task<List<Food>> GetAllFoods()
        {
            return await this.context.Food.Where(x => x.Status).ToListAsync();
        }
        public async Task<Food> GetAllFoodById(int id)
        {
           
             Food food = await this.context.Food.Where(x => x.Status && x.ProductId == id).Select(x => new Food() {
                 ProductId = x.ProductId,
                 Name = x.Name,
                 Dish = x.Dish,
                 Price = x.Price,
                 ComboFood = x.ComboFood,
                 Description = x.Description,
                 Ingredient = x.Ingredient,
                 Origin = x.Origin,
                 CookingRecipe = x.CookingRecipe,
                 Image = x.Image,
                 FoodTypeId = x.FoodTypeId,
                 Status = x.Status,
                 FoodType = this.context.FoodType.Where(y => y.FoodTypeId == x.FoodTypeId).Select(y => new FoodType()
                 {
                     FoodTypeId = y.FoodTypeId,
                     Name = y.Name,
                     Detail = y.Detail,
                 }).FirstOrDefault(),
             }).FirstOrDefaultAsync();
            return food;

        }

        public Task<bool> InsertFood(FoodDto food)
        {
            throw new NotImplementedException();
        }

        public Task<List<Food>> SearchByNameFoods(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateFood(FoodDto upFood)
        {
            try
            {
                Food food = await this.context.Food.FirstOrDefaultAsync(x => x.ProductId == upFood.ProductId);
                if (food != null)
                {
                   food.Name= upFood.Name;
                    food.Price= upFood.Price;
                    food.Dish = upFood.Dish;
                    food.ComboFood = upFood.ComboFood;
                    food.Description = upFood.Description;
                    food.Ingredient= upFood.Ingredient;
                    food.Origin = upFood.Origin;
                    food.CookingRecipe= upFood.CookingRecipe;
                    food.Image= upFood.Image;
                    food.FoodTypeId= upFood.FoodTypeId;
                    food.Status= upFood.Status;
                    this.context.SaveChanges();
                    return true;
                }
                else
                {
                    throw new Exception("Not Found Food!");
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
