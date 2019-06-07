using GroceryDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GroceryService.Controllers
{
    public class OrderItemController : ApiController
    {
        public IEnumerable<OrderItem> Get()
        {
            using (GroceryStoreDBEntities entities = new GroceryStoreDBEntities())
            {
                return entities.OrderItem.ToList();
            }
        }
        public OrderItem Get(int id)
        {
            using (GroceryStoreDBEntities entities = new GroceryStoreDBEntities())
            {
                return entities.OrderItem.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
