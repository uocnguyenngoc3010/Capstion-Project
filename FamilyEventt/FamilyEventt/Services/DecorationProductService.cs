using FamilyEventt.Dto;
using FamilyEventt.Interfaces;
using FamilyEventt.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyEventt.Services
{
    public class DecorationProductService : IDecorationProductService
    {
        protected readonly FamilyEventContext context;
        public DecorationProductService(FamilyEventContext context)
        {
            this.context = context;
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
                        ProductName = x.Product.ProductName,
                        ProductImage = x.Product.ProductImage,
                        ProductDetails = x.Product.ProductDetails,
                        ProductPrice = x.Product.ProductPrice,
                        ProductQuantity = x.Product.ProductQuantity,
                        ProductSupplier = x.Product.ProductSupplier,
                    },
                }).ToListAsync();
                return decorationProduct;

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Process went wrong");
            }
        }
        public async Task<List<DecorationProductDto>> GetDecorationProductById(int? decorationId, int? productId)
        {
            try
            {
                var data = await this.context.DecorationProduct
                    .Where(x => decorationId == null || x.DecorationId == decorationId)
                    .Where(x => productId == null || x.ProductId == productId)
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
                            ProductName = x.Product.ProductName,
                            ProductImage = x.Product.ProductImage,
                            ProductDetails = x.Product.ProductDetails,
                            ProductPrice = x.Product.ProductPrice,
                            ProductQuantity = x.Product.ProductQuantity,
                            ProductSupplier = x.Product.ProductSupplier,
                        },
                    }).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Process went wrong");
            }
        }
        public async Task<List<DecorationProductDto>> FilterDecorationProducts(int? decorationId, int? productId, decimal? minPrice, decimal? maxPrice, int? quantity, bool? quantityOption)
        {
            try
            {
                bool isFilterQuantity;
                if (quantity == null && quantityOption == null) isFilterQuantity = false;
                else isFilterQuantity = true;
                var data = await this.context.DecorationProduct
                    .Where(x => decorationId == null || x.DecorationId == decorationId)
                    .Where(x => productId == null || x.ProductId == productId)
                    .Where(x => minPrice == null || x.Price >= minPrice)
                    .Where(x => maxPrice == null || x.Price <= maxPrice)
                    .Where(x => !isFilterQuantity || (quantityOption == true ? x.Quantity>= quantity: x.Quantity<= quantity))
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
                            ProductName = x.Product.ProductName,
                            ProductImage = x.Product.ProductImage,
                            ProductDetails = x.Product.ProductDetails,
                            ProductPrice = x.Product.ProductPrice,
                            ProductQuantity = x.Product.ProductQuantity,
                            ProductSupplier = x.Product.ProductSupplier,
                        },
                    }).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Process went wrong");
            }
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
                newDecorationProduct.Price = decorationProduct.Price;

                this.context.DecorationProduct.Add(newDecorationProduct);
                await this.context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Process went wrong");
            }
        }
        public async Task<bool> UpdateDecorationProduct(DecorationProductDto decorationProduct)
        {
            try
            {
                var existData = await this.context.DecorationProduct
                    .FirstAsync(x => x.ProductId == decorationProduct.ProductId
                                    && x.DecorationId == decorationProduct.DecorationId);
                if (existData == null)
                {
                    throw new ArgumentException("DecorationProductId not found");
                }
                existData.ProductId = decorationProduct.ProductId;
                existData.DecorationId = decorationProduct.DecorationId;
                existData.Price = decorationProduct.Price;
                existData.Quantity = decorationProduct.Quantity;

                await this.context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("This DecorationPorduct doesn't exist or Process went wrong");
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

    }
}
