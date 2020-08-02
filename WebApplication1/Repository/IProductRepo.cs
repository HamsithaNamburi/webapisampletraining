using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductApp.Models;

namespace ProductApp.Repository
{
    public interface IProductRepo
    {
        public void AddItems(Products obj);
        List<Products> ViewItems();
        void DeleteItem(int productid);
        void UpdateItem(Products obj);
        Products GetItem(int productid);
    }
}
