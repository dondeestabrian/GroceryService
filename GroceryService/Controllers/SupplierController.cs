using GroceryDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GroceryService.Controllers
{
    public class SupplierController : ApiController
    {
        public IEnumerable<Supplier> Get()
        {
            using (GroceryStoreDBEntities entities = new GroceryStoreDBEntities())
            {
                return entities.Supplier.ToList();
            }
        }
        public Supplier Get(int id)
        {
            using (GroceryStoreDBEntities entities = new GroceryStoreDBEntities())
            {
                return entities.Supplier.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
