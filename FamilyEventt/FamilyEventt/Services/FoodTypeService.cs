using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyEventt.Services
{
    public class FoodTypeService : IFoodType
    {
        protected readonly FamilyEventContext context;
        public FoodTypeService(FamilyEventContext context)
        {
            this.context = context;
        }
        public async Task <bool>  DeleteFoodType(int id)
        {
            try
            {
                FoodType foodType = await this.context.FoodType.SingleOrDefaultAsync(x => x.FoodTypeId == id);
                if (foodType != null)
                {
                    context.FoodType.Remove(foodType);
                    this.context.SaveChanges();
                    return true;

                }
                else
                {
                    throw new Exception("Not Found Food Type!");
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<FoodType>>  GetAllFoodTypes()
        {
            try
            {
                var data = await this.context.FoodType.ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task<bool>  InsertFoodType(FoodTypeDto foodType)
        {
            try
            {
                var _foodType = new FoodType();
                _foodType.FoodTypeId = foodType.FoodTypeId;
                _foodType.Name = foodType.Name;
                _foodType.Detail= foodType.Detail;
                await this.context.FoodType.AddAsync(_foodType);
                this.context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<FoodType>> SearchByNameFoodTypes(string name)
        {
            try
            {
                var data = await this.context.FoodType.Where(x => x.Name.Contains(name)).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task<bool>  UpdateFoodType(FoodTypeDto upFoodType)
        {
            try
            {
                FoodType foodType = await this.context.FoodType.FirstOrDefaultAsync(x => x.FoodTypeId == upFoodType.FoodTypeId);
                if (foodType != null)
                {
                   foodType.Name = upFoodType.Name;
                   foodType.Detail = upFoodType.Detail;
                   this.context.SaveChanges(); 
                   return true;

                }
                else
                {
                    throw new Exception("Not Found Food Type!");
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
