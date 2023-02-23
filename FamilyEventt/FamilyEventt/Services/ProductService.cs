using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.EntityFrameworkCore;

namespace FamilyEventt.Services
{
   
    public class ProductService : IProductService
    {
        protected readonly FamilyEventContext context;
        public ProductService(FamilyEventContext context)
        {
            this.context = context;
        }

        public async Task <bool> DeleteProduct(List<int> id)
        {
            try
            {
                List<Product> products = await this.context.Product.Where(x => id.Contains(x.ProductId)).ToListAsync();
                if (products != null && products.Count>0)
                {

                    for(int i = 0; i < products.Count; i++)
                    {
                        products[i].Status = false;
                    }
                    await this.context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    throw new ArgumentException("No Product found");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Process went wrong");
            }
        }

        public async Task<List<ProductDto>> FilterProductByManyOption(string? name, decimal? minPrice, decimal? maxPrice, string? supplier, int? qty, bool? qtyOption = true)
        {
            try
            {

                var data = await this.context.Product
                    .Where(x => name == null || x.ProductName.Normalize().Contains(name.Normalize()))
                    .Where(x => supplier == null || x.ProductSupplier.Normalize().Contains(supplier.Normalize()))
                    .Where(x => minPrice == null || x.ProductPrice>= minPrice)
                    .Where(x => maxPrice == null || x.ProductPrice<= maxPrice)
                    .Where(x => qty == null || ( qtyOption== true? x.ProductQuantity>= qty : x.ProductQuantity<= qty))
                    .Select(x => new ProductDto
                    {
                        ProductId = x.ProductId,
                        ProductName = x.ProductName,
                        ProductQuantity = x.ProductQuantity,
                        ProductDetails = x.ProductDetails,
                        ProductImage = x.ProductImage,
                        ProductPrice = x.ProductPrice,
                        ProductSupplier = x.ProductSupplier,
                        Status = x.Status,
                    })
                    .ToListAsync();
                return data;
            }
            catch(Exception ex)
            {
                throw new ArgumentException("Process went wrong");
            }
        }

        public async Task <List<ProductDto>> GetAllProducts()
        {
            try
            {
                var data =await this.context.Product.Where(x => x.Status)
                    .Select(x=> new ProductDto
                    {
                        ProductId = x.ProductId,
                        ProductName = x.ProductName,
                        ProductDetails = x.ProductDetails,
                        Status = x.Status,
                        ProductImage = x.ProductImage,
                        ProductPrice = x.ProductPrice,
                        ProductQuantity = x.ProductQuantity,
                        ProductSupplier = x.ProductSupplier,
                    })
                    .ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task <bool> InsertProduct(ProductDto iProduct)
        {
            try
            {
                var _product = new Product();
                _product.ProductId = iProduct.ProductId;
                _product.Status = iProduct.Status;
                _product.ProductName = iProduct.ProductName;
                _product.ProductPrice = iProduct.ProductPrice;
                _product.ProductQuantity = iProduct.ProductQuantity;
                _product.ProductDetails = iProduct.ProductDetails;
                _product.ProductImage = iProduct.ProductImage;
                _product.ProductSupplier = iProduct.ProductSupplier;
                _product.Status = iProduct.Status;
                await this.context.Product.AddAsync(_product);
                this.context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Process went wrong");
            }

        }

        public async Task <List<ProductDto>> SearchByNameProducts(string name)
        {
             try
             {
                var data =await this.context.Product.Where(x => x.Status && x.ProductName.Contains(name)).
                    Select(x =>  new ProductDto
                    {
                        ProductDetails = x.ProductDetails,
                        ProductId = x.ProductId,
                        ProductImage = x.ProductImage,
                        ProductName = x.ProductName,
                        ProductPrice = x.ProductPrice,
                        ProductQuantity = x.ProductQuantity,
                        ProductSupplier = x.ProductSupplier,
                        Status = x.Status,
                    }).ToListAsync();
                if (data.Count > 0 && data != null)
                    return data;
                else throw new ArgumentException();
             }
            catch (Exception ex)
             {
                throw new ArgumentException("Process went wrong");
            }
        }

        public async Task <bool> UpdateProduct(ProductDto upProduct)
        {
            try
            {
                Product product = await this.context.Product.FirstAsync(x => x.ProductId == upProduct.ProductId);
                if (product != null)
                {
                    product.ProductName = upProduct.ProductName;
                    product.ProductPrice = upProduct.ProductPrice;
                    product.ProductQuantity = upProduct.ProductQuantity;
                    product.ProductDetails = upProduct.ProductDetails;
                    product.ProductImage = upProduct.ProductImage;
                    product.ProductSupplier = upProduct.ProductSupplier;
                    product.Status = upProduct.Status;
                    this.context.SaveChanges();
                    return true;

                }
                else
                {
                    throw new ArgumentException("Product not found");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Process went wrong");
            }
        }
    }
}
