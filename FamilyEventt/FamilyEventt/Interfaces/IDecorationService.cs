using FamilyEventt.Dto;

namespace FamilyEventt.Interfaces
{
    public interface IDecorationService
    {
        /// <summary>
        /// Get all decoration
        /// </summary>
        /// <returns></returns>
        Task<List<DecorationDto>> GetAllDecoration();
        /// <summary>
        /// Get decoration by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<DecorationDto> GetDecorationById(int id);
        /// <summary>
        /// Filter decoration by many options
        /// </summary>
        /// <param name="name"></param>
        /// <param name="minPrice"></param>
        /// <param name="maxPrice"></param>
        /// <returns></returns>
        Task<List<DecorationDto>> FilterDecorationBy(string? name, decimal? minPrice, decimal? maxPrice);
        /// <summary>
        /// Add a decoration
        /// </summary>
        /// <param name="decoration"></param>
        /// <returns></returns>
        Task<bool> AddDecoration(DecorationDto decoration);
        /// <summary>
        /// Update a decoration
        /// </summary>
        /// <param name="decorationDto"></param>
        /// <returns></returns>
        Task<bool> UpdateDecoration(DecorationDto decorationDto);
        /// <summary>
        /// Deleted a range of decoration
        /// </summary>
        /// <param name="decorationIds"></param>
        /// <returns></returns>
        Task<bool> DeleteDecorationById(List<int> decorationIds);

    }
}
