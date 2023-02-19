using FamilyEventt.Dto;
using FamilyEventt.Models;

namespace FamilyEventt.Interfaces
{
    public interface ILocation
    {
        Task<List<Location>> GetAllLocations();
        Task<List<Location>> SearchByNameLocations(string name);
        Task<bool> UpdateLocation(LocationDto upLocation);
        Task<bool> DeleteLocation(int id);
        Task<bool> InsertLocation(LocationDto location);
    }
}
