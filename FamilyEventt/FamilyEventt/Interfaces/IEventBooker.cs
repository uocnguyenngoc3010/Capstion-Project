using FamilyEventt.Dto;
using FamilyEventt.Models;

namespace FamilyEventt.Interfaces
{
    public interface IEventBooker
    {
        Task<List<EventBooker>> GetAllEventBookers();
        Task<List<EventBooker>> SearchByNameEventBooker(string name);
        Task<bool> UpdateEventBooker(EventBookerDto upEventBooker);
        Task<bool> DeleteEventBooker(int id);
        Task<bool> InsertEventBooker(EventBookerDto eventBooker);
    }
}
