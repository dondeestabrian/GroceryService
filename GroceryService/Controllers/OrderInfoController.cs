using GroceryDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GroceryService.Controllers
{
    public class OrderInfoController : ApiController
    {
        public IEnumerable<OrderInfo> Get()
        {
            using (GroceryStoreDBEntities entities = new GroceryStoreDBEntities())
            {
                return entities.OrderInfo.ToList();
            }
        }
        public OrderInfo Get(int id)
        {
            using (GroceryStoreDBEntities entities = new GroceryStoreDBEntities())
            {
                return entities.OrderInfo.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
