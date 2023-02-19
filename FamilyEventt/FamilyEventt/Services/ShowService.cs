using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FamilyEventt.Services
{
    public class ShowService : IShow
    {
        protected readonly FamilyEventContext context;
        public ShowService(FamilyEventContext context)
        {
            this.context = context;
        }
        public async Task <bool> DeleteShow(int id)
        {
            try
            {
                Show show =await this.context.Show.FirstOrDefaultAsync(x => x.ShowId == id);
                if (show != null)
                {

                    show.Status = false;
                    this.context.SaveChanges();
                    return true;

                }
                else
                {
                    throw new Exception("Not Found Name Show!");
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task <List<Show>> GetAllShows()
        {
            try
            {
                var data =await this.context.Show.Where(x => x.Status).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task <bool> InsertShow(ShowDto show)
        {
            try
            {
                var _show = new Show();
                _show.ShowId = show.ShowId;
                _show.Price = show.Price;
                _show.Name = show.Name;
                _show.Light = show.Light;
                _show.Sound = show.Sound;
                _show.Singer = show.Singer;
               _show.Description = show.Description;
                _show.Image = show.Image;
                _show.Status = show.Status;
                await this.context.Show.AddAsync(_show);
                this.context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task <List<Show>> SearchByNameShows(string name)
        {
            try
            {
                var data =await this.context.Show.Where(x => x.Status && x.Name.Contains(name)).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task <bool> UpdateShow(ShowDto upShow)
        {
            try
            {
                Show show =await this.context.Show.FirstOrDefaultAsync(x => x.ShowId == upShow.ShowId);
                if (show != null)
                {
                        show.Price = show.Price;
                        show.Name = upShow.Name; 
                        show.Light = show.Light;
                        show.Sound = show.Sound;
                        show.Singer = show.Singer;
                        show.Description = show.Description;
                        show.Image = show.Image;
                        show.Status = show.Status;
                        this.context.SaveChanges();
                        return true;

                }
                else
                {
                    throw new Exception("Not Found Show!");
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
