using FamilyEventt.Dto;
using FamilyEventt.Models;

namespace FamilyEventt.Interfaces
{
    public interface IProductService
    {
        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        Task<List<ProductDto>> GetAllProducts();
        /// <summary>
        /// Get product by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<List<ProductDto>> SearchByNameProducts(string name);
        /// <summary>
        /// Filter product by many options
        /// </summary>
        /// <param name="name"></param>
        /// <param name="MinPrice"></param>
        /// <param name="maxPrice"></param>
        /// <param name="supplier"></param>
        /// <param name="quantity"></param>
        /// <param name="qtyOption"> true is >= and false is <= </param>
        /// <returns></returns>
        Task<List<ProductDto>> FilterProductByManyOption(string? name, decimal? MinPrice, decimal? maxPrice, string? supplier, int? quantity, bool? qtyOption = true);
        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="upProduct"></param>
        /// <returns></returns>
        Task<bool> UpdateProduct(ProductDto upProduct);
        /// <summary>
        /// Delete a range of products
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteProduct(List<int> id);
        /// <summary>
        /// Insert product
        /// </summary>
        /// <param name="iProduct"></param>
        /// <returns></returns>
        Task<bool> InsertProduct(ProductDto iProduct);
    }
}
