using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyEventt.Services
{
    public class DecorationProductService : IDecorationProduct
    {
        protected readonly FamilyEventContext context;
        public DecorationProductService(FamilyEventContext context)
        {
            this.context = context;
        }

        public async Task<bool> AddDecorationProduct(DecorationProductDto decorationProduct)
        {
            try
            {
                //var existedObject = await this.context.DecorationProduct
                //    .FirstOrDefaultAsync(x => x.ProductId == decorationProduct.ProductId
                //            && x.DecorationId== decorationProduct.DecorationId);
                //if ( existedObject != null)
                //    return false;

                DecorationProduct newDecorationProduct = new DecorationProduct();
                newDecorationProduct.ProductId = decorationProduct.ProductId;
                newDecorationProduct.DecorationId = decorationProduct.DecorationId;
                newDecorationProduct.Quantity = decorationProduct.Quantity;
                newDecorationProduct.Price =  decorationProduct.Price;

                this.context.DecorationProduct.Add(newDecorationProduct);
                await this.context.SaveChangesAsync();
                return true;
            }catch(Exception ex)
            {
                throw new Exception("Process went wrong");
            }
        }

        public async Task<bool> DeleteDecorationProductById(int[] decorationProductId)
        {
            //try
            //{
            //    var decorationProducts = await this.context.DecorationProduct
            //        .Where(x => decorationProductId.Contains(x.DecorationId)).ToListAsync();
            //    if (decorationProducts != null && decorationProducts.Count() >= 1)
            //    {
            //        this.context.RemoveRange(decorationProducts);
            //        await this.context.SaveChangesAsync();
            //    }
            //    else return false;
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}
            throw new NotImplementedException();

        }

        public async Task<List<DecorationProductDto>> GetAllDecorationProduct()
        {
            try
            {
                var decorationProduct = await this.context.DecorationProduct.Select(x => new DecorationProductDto
                {
                    DecorationId = x.DecorationId,
                    ProductId = x.ProductId,
                    Price = x.Price,
                    Quantity = x.Quantity,
                    Decoration = new DecorationDto 
                    { 
                        DecorationId = x.Decoration.DecorationId,
                        DecorationName = x.Decoration.DecorationName,
                        DecorationPrice = x.Decoration.DecorationPrice,
                        DecorationImage = x.Decoration.DecorationImage,
                    },
                    Product = new ProductDto 
                    {
                        ProductId = x.Product.ProductId,
                        DecorationProductName = x.Product.DecorationProductName,
                        ProductImage = x.Product.ProductImage,
                        ProductDetails = x.Product.ProductDetails,
                        ProductPrice = x.Product.ProductPrice,
                        ProductQuantity = x.Product.ProductQuantity,
                        ProductSupplier = x.Product.ProductSupplier,
                    },
                }).ToListAsync();
                return decorationProduct;

            }catch(Exception ex)
            {
                throw new Exception("Process went wrong");
            }
        }

        public async Task<List<DecorationProductDto>> GetDecorationProductById(int? decorationId, int? productId)
        {
            try
            {
                var data = await this.context.DecorationProduct
                    .Where(x => decorationId == null|| x.DecorationId == decorationId)
                    .Where(x => productId ==null || x.ProductId == productId)
                    .Select(x => new DecorationProductDto
                    {
                        DecorationId = x.DecorationId,
                        ProductId = x.ProductId,
                        Price = x.Price,
                        Quantity = x.Quantity,
                        Decoration = new DecorationDto
                        {
                            DecorationId = x.Decoration.DecorationId,
                            DecorationName = x.Decoration.DecorationName,
                            DecorationPrice = x.Decoration.DecorationPrice,
                            DecorationImage = x.Decoration.DecorationImage,
                        },
                        Product = new ProductDto
                        {
                            ProductId = x.Product.ProductId,
                            DecorationProductName = x.Product.DecorationProductName,
                            ProductImage = x.Product.ProductImage,
                            ProductDetails = x.Product.ProductDetails,
                            ProductPrice = x.Product.ProductPrice,
                            ProductQuantity = x.Product.ProductQuantity,
                            ProductSupplier = x.Product.ProductSupplier,
                        },
                    }).ToListAsync();
                return data;
            }catch(Exception ex)
            {
                throw new Exception("Process went wrong");
            }
        }

        public async Task<bool> UpdateDecorationProduct(DecorationProductDto decorationProduct)
        {
            try 
            {
                var existData = await this.context.DecorationProduct
                    .FirstOrDefaultAsync(x => x.ProductId == decorationProduct.ProductId
                                    && x.DecorationId == decorationProduct.DecorationId);
                if (existData == null)
                {
                    throw new Exception();
                }
                existData.ProductId = decorationProduct.ProductId;
                existData.DecorationId = decorationProduct.DecorationId;
                existData.Price = decorationProduct.Price;
                existData.Quantity = decorationProduct.Quantity;

                await this.context.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {

                throw new Exception("This DecorationPorduct doesn't exist or Process went wrong");
            }
        }
    }
}
