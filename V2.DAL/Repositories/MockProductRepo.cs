using System;
using System.Collections.Generic;
using V2.DAL.Interfaces;
using V2.DAL.Models;

namespace V2.DAL.Repositories
{
    public class MockProductRepo : IRepository<Product>
    {
        public void Add(Product p)
        {
            throw new NotImplementedException();
        }

        public void Edit(Product p)
        {
            throw new NotImplementedException();
        }

        public Product FindById(int Id)
        {
            return new Product()
            {
                Id = 0,
                Name = "Basic Product",
                Category_Id = 0,
                SerialNumber = "002154632197546",
                ProductionDate = DateTime.Now
            };
        }

        public IEnumerable<Product> GetAllEntities()
        {
            var products = new List<Product>() {
                new Product(){ Id = 0 , Name = "P0" , Category_Id = 0 , SerialNumber = "021548796325" },
                new Product(){ Id = 1 , Name = "P1" , Category_Id = 1 , SerialNumber = "021548796325" },
                new Product(){ Id = 2 , Name = "P2" , Category_Id = 2 , SerialNumber = "021548796325" },
                new Product(){ Id = 3 , Name = "P3" , Category_Id = 3 , SerialNumber = "021548796325" },
                new Product(){ Id = 4 , Name = "P4" , Category_Id = 4 , SerialNumber = "021548796325" }
            };

            return products;
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
