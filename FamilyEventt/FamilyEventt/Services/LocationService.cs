using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyEventt.Services
{
    public class LocationService : ILocation
    {
        protected readonly FamilyEventContext context;
        public LocationService(FamilyEventContext context)
        {
            this.context = context;
        }
        public async Task<bool> DeleteLocation(int id)
        {
            try
            {
                Location location = await this.context.Location.FirstOrDefaultAsync(x => x.LocationId == id);
                if (location != null)
                {

                    location.Status = false;
                    this.context.SaveChanges();
                    return true;

                }
                else
                {
                    throw new Exception("Not Found Location!");
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<Location>> GetAllLocations()
        {
            try
            {
                var data = await this.context.Location.Where(x => x.Status).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task<bool> InsertLocation(LocationDto location)
        {

            try
            {
                var _location = new Location();
                _location.LocationId = location.LocationId;
                _location.RoomId = location.RoomId;
                _location.Type = location.Type;
                _location.Name = location.Name;
                _location.Description = location.Description;
                _location.Image = location.Image;
                _location.QuantityParticipants = location.QuantityParticipants;
                _location.Status = location.Status;
                
                await this.context.Location.AddAsync(_location);
                this.context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<Location>> SearchByNameLocations(string name)
        {
            try
            {
                var data = await this.context.Location.Where(x => x.Status && x.Name.Contains(name)).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task<bool> UpdateLocation(LocationDto upLocation)
        {
            try
            {
                Location location = await this.context.Location.FirstOrDefaultAsync(x => x.LocationId == upLocation.LocationId);
                if (location != null)
                {
                    location.RoomId = upLocation.RoomId;
                    location.Type= upLocation.Type;
                    location.Name = upLocation.Name;
                    location.Description = upLocation.Description;
                    location.Image = upLocation.Image;
                    location.QuantityParticipants = upLocation.QuantityParticipants;
                    location.Status = upLocation.Status;
                    
                    this.context.SaveChanges();
                    return true;
                }
                else
                {
                    throw new Exception("Not Found Location!");
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
