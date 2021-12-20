using DemoP.IRepository;
using DemoP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoP.Repository
{
    public class ProductTable : ProductInterface
    {
        private readonly DemoProjectContext context;
        public ProductTable(DemoProjectContext _context)
        {
            context = _context;
        }



        public IEnumerable<Productlist> GetProduct()
        {
            var response = (from prod in context.Product
                            join pv in context.ProductVariation on prod.ProductId equals pv.ProductId
                            select new Productlist
                            {
                                ProductId = prod.ProductId,
                                PName = prod.PName,
                                PDescription = prod.PDescription,
                                IsCancelable = prod.IsCancelable,
                                IsReturnable = prod.IsReturnable,
                                Brand = prod.Brand,
                                ProductVariationId = pv.ProductVariationId,
                                QunatityAvailable = pv.QunatityAvailable,
                                Price = pv.Price,
                                VariationMetadata = pv.VariationMetadata,
                                PrimaryImageName = pv.PrimaryImageName,
                            }).ToList();



            return response;
        }


     




        public ResponsePara AddToCart(Cart model)
        {
            ResponsePara responsePara = new ResponsePara();
            try
            {
                var isExistingProd = (from c in context.Cart
                                      where c.ProductId == model.ProductId
                                      select c).FirstOrDefault();
                if (isExistingProd == null)
                {
                    context.Cart.Add(model);
                    context.SaveChanges();
                    responsePara.SuccessMessage = "Prod added to cart successfully.";
                    //responsePara.id = model.Id;
                }
                else
                {
                    responsePara.SuccessMessage = "Prod already added to cart.";
                }

            }
            catch (Exception ex)
            {
                responsePara.ErrorMessage = "Insertion Failed due to=" + ex.Message + ".";
            }

            return responsePara;
        }


        public IEnumerable<CartViewModel> GetCart(string custId)
        {
            Guid guid = new Guid();
            guid = Guid.Parse(custId);
            var response = (from c in context.Cart
                            join p in context.Product on c.ProductId equals p.ProductId
                            join pv in context.ProductVariation on c.ProductVariationId equals pv.ProductVariationId
                            where c.CustomerId == guid
                            select new CartViewModel
                            {
                                CustomerId = c.CustomerId,
                                Quantity = c.Quantity,
                                ProductId = c.ProductId,
                                ProductVariationId = c.ProductVariationId,
                                PName = p.PName,
                                Brand = p.Brand,
                                Price = pv.Price,
                                PrimaryImageName = pv.PrimaryImageName
                            }).ToList();


            return response;
        }

        public ResponsePara SetOrder(OrderTable model)
        {
            Cart cart = new Cart();
            cart.ProductId = model.ProductId;
            ResponsePara responsePara = new ResponsePara();
            try
            {

                context.OrderTable.Add(model);
                context.SaveChanges();

                var isExistingRecord = (from c in context.Cart
                                        where c.ProductId == cart.ProductId
                                        select c).FirstOrDefault();
                if (isExistingRecord != null)
                {
                    context.Cart.Remove(isExistingRecord);
                    context.SaveChanges();

                }
                responsePara.SuccessMessage = "Order placed successfully.";

            }
            catch (Exception ex)
            {
                var isExistingRecord = (from c in context.OrderTable
                                        where c.ProductId == model.ProductId
                                        select c).FirstOrDefault();
                if (isExistingRecord != null)
                {
                    context.OrderTable.Remove(model);
                    context.SaveChanges();
                }
                responsePara.ErrorMessage = "Order Failed due to=" + ex.Message + ".";
            }

            return responsePara;
        }


    }
}

