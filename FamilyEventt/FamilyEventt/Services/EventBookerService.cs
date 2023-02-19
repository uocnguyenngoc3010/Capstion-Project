using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyEventt.Services
{
    public class EventBookerService : IEventBooker
    {
        protected readonly FamilyEventContext context;
        public EventBookerService(FamilyEventContext context)
        {
            this.context = context;
        }
        public async Task<bool> DeleteEventBooker(int id)
        {
            try
            {
                EventBooker eventBooker = await this.context.EventBooker.FirstOrDefaultAsync(x => x.Id == id);
                if (eventBooker != null)
                {

                    eventBooker.Status = false;
                    this.context.SaveChanges();
                    return true;

                }
                else
                {
                    throw new Exception("Not Found Event Booker!");
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<EventBooker>> GetAllEventBookers()
        {
            try
            {
                var data = await this.context.EventBooker.Where(x => x.Status).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("GetAllEventBookers" + ex.Message);
            }
        }

        public async Task<bool> InsertEventBooker(EventBookerDto eventBooker)
        {
            try
            {
                var _eventBooker = new EventBooker();
                _eventBooker.Id = eventBooker.Id;
                _eventBooker.Fullname = eventBooker.Fullname;
               /* _eventBooker.Email = eventBooker.Email;
                _eventBooker.Phone = eventBooker.Phone;
                _eventBooker.Password = eventBooker.Password;*/
                _eventBooker.Address = eventBooker.Address;
                _eventBooker.Gender= eventBooker.Gender;
                _eventBooker.DateOfBirth= eventBooker.DateOfBirth;
                _eventBooker.Image = eventBooker.Image;
                _eventBooker.Status= eventBooker.Status;
                await this.context.EventBooker.AddAsync(_eventBooker);
                this.context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<EventBooker>> SearchByNameEventBooker(string name)
        {
            try
            {
                var data = await this.context.EventBooker.Where(x => x.Status && x.Fullname.Contains(name)).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task<bool> UpdateEventBooker(EventBookerDto upEventBooker)
        {
            try
            {
                EventBooker eventBooker = await this.context.EventBooker.FirstOrDefaultAsync(x => x.Id == upEventBooker.Id);
                if (eventBooker != null)
                {
                    eventBooker.Id = upEventBooker.Id;
                    eventBooker.Fullname = upEventBooker.Fullname;
                    /*eventBooker.Email = upEventBooker.Email;
                    eventBooker.Phone = upEventBooker.Phone;
                    eventBooker.Password = upEventBooker.Password;*/
                    eventBooker.Address = upEventBooker.Address;
                    eventBooker.Gender = upEventBooker.Gender;
                    eventBooker.DateOfBirth = upEventBooker.DateOfBirth;
                    eventBooker.Image = upEventBooker.Image;
                    eventBooker.Status = upEventBooker.Status;
                    this.context.SaveChanges();
                    return true;
                }
                else
                {
                    throw new Exception("Not Found Event Booker!");
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
