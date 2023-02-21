using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyEventt.Services
{
   
    public class ProductService : IProduct
    {
        protected readonly FamilyEventContext context;
        public ProductService(FamilyEventContext context)
        {
            this.context = context;
        }

        public async Task <bool> DeleteProduct(int id)
        {
            try
            {
                Product product =await this.context.Product.FirstOrDefaultAsync(x => x.ProductId == id);
                if (product != null)
                {

                    product.Status = false;
                    this.context.SaveChanges();
                    return true;

                }
                else
                {
                    throw new Exception("Not Product!");
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task <List<Product>> GetAllProducts()
        {
            try
            {
                var data =await this.context.Product.Where(x => x.Status).ToListAsync();
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
                _product.DecorationProductName = iProduct.DecorationProductName;
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
                return false;
            }

        }

        public async Task <List<Product>> SearchByNameProducts(string name)
        {
             try
             {
                var data =await this.context.Product.Where(x => x.Status && x.DecorationProductName.Contains(name)).ToListAsync();
                return data;
             }
            catch (Exception ex)
             {
                throw new Exception();
             }
        }

        public async Task <bool> UpdateProduct(ProductDto upProduct)
        {
            try
            {
                Product product =await this.context.Product.FirstOrDefaultAsync(x => x.ProductId == upProduct.ProductId);
                if (product != null)
                {
                    product.DecorationProductName = upProduct.DecorationProductName;
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
                    throw new Exception("Please enter product name");
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
