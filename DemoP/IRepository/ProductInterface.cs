using DemoP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoP.IRepository
{
   public interface ProductInterface
    {
        public IEnumerable<Productlist> GetProduct();
        public IEnumerable<CartViewModel> GetCart(string custId);
        public ResponsePara AddToCart(Cart model);

        public ResponsePara SetOrder(OrderTable model);
    }
}
