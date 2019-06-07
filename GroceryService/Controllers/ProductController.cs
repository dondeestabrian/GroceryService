using GroceryDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GroceryService.Controllers
{
    public class ProductController : ApiController
    {
        public IEnumerable<Product> Get()
        {
            using (GroceryStoreDBEntities entities = new GroceryStoreDBEntities())
            {
                return entities.Product.ToList();
            }
        }
        public Product Get(int id)
        {
            using (GroceryStoreDBEntities entities = new GroceryStoreDBEntities())
            {
                return entities.Product.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
