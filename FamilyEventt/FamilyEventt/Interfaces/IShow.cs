using FamilyEventt.Dto;
using FamilyEventt.Models;

namespace FamilyEventt.Interfaces
{
    public interface IShow
    {
        Task<List<Show>> GetAllShows();
        Task<List<Show>> SearchByNameShows(string name);
        Task<bool> UpdateShow(ShowDto upShow);
        Task<bool> DeleteShow(int id);
        Task<bool> InsertShow(ShowDto show);
    }
}
