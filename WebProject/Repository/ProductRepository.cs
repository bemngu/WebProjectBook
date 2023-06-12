﻿using WebProject.Data;
using WebProject.Models;
using WebProject.Repository.IRepository;

namespace WebProject.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) :base(db) 
        {
            _db = db;
        }

      

        public void Update(Product  obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u=> u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title= obj.Title;
                objFromDb.ISBN= obj.ISBN;
                objFromDb.Price = obj.Price;
                objFromDb.Price50 = obj.Price50;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Price100 = obj.Price100;
                objFromDb.Description= obj.Description;
                obj.CategoryId= obj.CategoryId;
                objFromDb.Author= obj.Author;
                objFromDb.CoverTypeId= obj.CoverTypeId;
                if(obj.ImageURL!=null) { 
                    objFromDb.ImageURL= obj.ImageURL;
                }

            }
        }
    }
}