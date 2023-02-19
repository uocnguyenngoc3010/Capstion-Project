using FamilyEventt.Dto;
using FamilyEventt.Models;

namespace FamilyEventt.Interfaces
{
    public interface IFood
    {
        Task<List<Food>> GetAllFoods();
        Task<List<Food>> SearchByNameFoods(string name);
        Task<bool> UpdateFood(FoodDto upFood);
        Task<bool> DeleteFood(int id);
        Task<bool> InsertFood(FoodDto food);
    }
}
