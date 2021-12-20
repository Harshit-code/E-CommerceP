using DemoP.IRepository;
using DemoP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoP.Repository
{
    public class SellerTable : SellerInterface
    {
        string str = string.Empty;
       
        private readonly DemoProjectContext context;


        public SellerTable(DemoProjectContext _context)
        {
            context = _context;
        }

        public string Insert(Seller model)
        {
            try
            {
                
                context.Seller.Add(model);
                
                context.SaveChanges();
                
                str = "User saved successfully.";
            }
           
            catch (Exception ex)
            {
                str = "Deletion Failed due to=" + ex.Message + ".";
            }
            return str;

            
        }
        public IEnumerable<Seller> GetSeller()
        {
            var response = context.Seller.ToList();
            return response;
        }
        public Seller GetBySellerGuid(Guid id)
        {
            return context.Seller.FirstOrDefault(x => x.Sellerid == id);
        }

        public ResponsePara SetProduct(ProductUploadViewModel model)
        {
           
                Guid ProductIdFromProduct = new Guid();
                String custId = string.Empty;
                Product product = new Product();
                product.PName = model.Name;
                product.PDescription = model.Description;
                product.IsCancelable = model.IsCancelable;
                product.IsReturnable = model.IsReturnable;
                product.Brand = model.Brand;
                product.Sellerid = model.Sellerid;
                ResponsePara responsePara = new ResponsePara();
                try
                {
                    context.Product.Add(product);
                    context.SaveChanges();
                    ProductIdFromProduct = product.ProductId;
                    responsePara.SuccessMessage = "Product added successfuly in Product Table";

                }
                catch (Exception ex)
                {
                    //context.Product.Remove(product);
                    //context.SaveChanges();
                    responsePara.ErrorMessage = "Data not added in Product table due to " + ex.Message;
                }
                if (responsePara.SuccessMessage == "Product added successfuly in Product Table")
                {
                    ProductVariation prodV = new ProductVariation();
                    prodV.ProductId = ProductIdFromProduct;
                    prodV.QunatityAvailable = model.QunatityAvailable;
                    prodV.Price = model.Price;
                    prodV.VariationMetadata = model.VariationMetadata;
                    prodV.PrimaryImageName = model.ImagePath;
                    try
                    {
                        context.ProductVariation.Add(prodV);
                        context.SaveChanges();
                        responsePara.SuccessMessage = "Product added successfuly in Product variation Table";
                    }
                    catch (Exception ex)
                    {
                        context.Product.Remove(product);
                        context.SaveChanges();
                        responsePara.ErrorMessage = "Data not added in Product variation table due to " + ex.Message;
                    }
                }

                return responsePara;
            }
    }
}
