using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FamilyEventt.Services
{
    public class DrinkService : IDrink
    {
        protected readonly FamilyEventContext context;
        public DrinkService(FamilyEventContext context)
        {
            this.context = context;
        }

        public async Task <bool> DeleteDrink(int id)
        {
            try
            {
                Drink drink = await this.context.Drink.FirstOrDefaultAsync(x => x.ProductId == id);
                if (drink != null)
                {
                   
                    drink.Status = false;
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

        public async Task <List<Drink>> GetAllDrinks()
        {
            try
            {
                var data = await this.context.Drink.Where(x => x.Status).ToListAsync();
                return data;
            }
            catch (Exception ex) {
                throw new Exception();
            }
           
        }

        public async Task <bool> InsertDrink(DrinkDto drink)
        {
            try
            {
                var _drink = new Drink();
                _drink.ProductId = drink.ProductId;
                _drink.Status = drink.Status;
                _drink.Name = drink.Name;
                _drink.Detail = drink.Detail;
                _drink.Quantity= drink.Quantity;
                _drink.Price = drink.Price;
                _drink.Image = drink.Image;
                await this.context.Drink.AddAsync(_drink);
                this.context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }

        public async Task <List<Drink>> SearchByNameDrinks(string name)
        {
            try
            {
                var data = await this.context.Drink.Where(x => x.Status && x.Name.Contains(name)).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

       /* public async Task<List<Drink>> SearchByIDDrinks(int id)
        {
            try
            {
                var data = await this.context.Drink.SingleOrDefaultAsync(x =>x.Status && x.ProductId == id);
                if (data != null)
                {
                    
                    return data;
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }*/

        public async Task <bool>  UpdateDrink(DrinkDto upDrink)
        {
            try
            {
                Drink drink = await this.context.Drink.FirstOrDefaultAsync(x => x.ProductId == upDrink.ProductId);
                if (drink != null) 
                {   
                    drink.Name = upDrink.Name;
                    drink.Quantity= upDrink.Quantity;
                    drink.Price = upDrink.Price;
                    drink.Detail = upDrink.Detail;
                    drink.Image= upDrink.Image;
                    drink.Status = upDrink.Status;  
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
    }
}
