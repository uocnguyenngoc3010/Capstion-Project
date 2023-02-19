using FamilyEventt.Dto;
using FamilyEventt.Models;

namespace FamilyEventt.Interfaces
{
    public interface IProduct
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> SearchByNameProducts(string name);
        Task<bool> UpdateProduct(ProductDto upProduct);
        Task<bool> DeleteProduct(int id);
        Task<bool> InsertProduct(ProductDto iProduct);
    }
}
