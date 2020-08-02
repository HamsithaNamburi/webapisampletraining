using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApp.Repository
{
    public class ProductRepo : IProductRepo
    {
        private readonly ProductDBContext _context;

        public ProductRepo(ProductDBContext context)
        {
            _context = context;
        }
        public void AddItems(Products obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteItem(int productid)
        {
            Products i = _context.Products.Find(productid);
            _context.Remove(i);
            _context.SaveChanges();
        }

        public Products GetItem(int productid)
        {
            return _context.Products.Find(productid);
        }

        public void UpdateItem(Products obj)
        {
            _context.Products.Update(obj);
            _context.SaveChanges();
        }

        public List<Products> ViewItems()
        {
            List<Products> products= _context.Products.ToList();
            return products;
        }
    }
}
