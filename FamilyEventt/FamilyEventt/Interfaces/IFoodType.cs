using FamilyEventt.Dto;
using FamilyEventt.Models;

namespace FamilyEventt.Interfaces
{
    public interface IFoodType
    {
        Task<List<FoodType>> GetAllFoodTypes();
        Task<List<FoodType>> SearchByNameFoodTypes(string name);
        Task<bool> UpdateFoodType(FoodTypeDto upFoodType);
        Task<bool> DeleteFoodType(int id);
        Task<bool> InsertFoodType(FoodTypeDto foodType);
    }
}
