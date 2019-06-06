using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GroceryDataAccess;

namespace GroceryService.Controllers
{
    public class CustomerController : ApiController
    {
        public IEnumerable<Customer> Get()
        {
            using ( GroceryStoreDBEntities entities = new GroceryStoreDBEntities())
            {
                return entities.Customer.ToList();
            }
        }
        public Customer Get(int id)
        {
            using (GroceryStoreDBEntities entities = new GroceryStoreDBEntities())
            {
                return entities.Customer.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
