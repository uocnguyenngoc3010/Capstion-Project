using FamilyEventt.Dto;
using FamilyEventt.Models;

namespace FamilyEventt.Interfaces
{
    public interface IDrink
    {
        Task<List<Drink>> GetAllDrinks();
        Task<List<Drink>> SearchByNameDrinks(string name);
       /* Task<List<Drink>> SearchByIDDrinks(int id);*/
        Task<bool> UpdateDrink(DrinkDto upDrink);
        Task<bool> DeleteDrink(int id);
        Task<bool> InsertDrink(DrinkDto drink);

    }
}
