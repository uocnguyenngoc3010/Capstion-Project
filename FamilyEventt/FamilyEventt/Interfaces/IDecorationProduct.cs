using FamilyEventt.Dto;
using FamilyEventt.Models;

namespace FamilyEventt.Interfaces
{
    public interface IDecorationProduct
    {
        Task<List<DecorationProductDto>> GetDecorationProductById(int? decorationId, int? productId);
        Task<List<DecorationProductDto>> GetAllDecorationProduct();
        Task<bool> AddDecorationProduct(DecorationProductDto decorationProduct);
        Task<bool> UpdateDecorationProduct(DecorationProductDto decorationProduct);
        Task<bool> DeleteDecorationProductById(int[] decorationProductId);


    }
}
