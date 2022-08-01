using FirstFormApp.Data;
using FirstFormApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FirstFormApp.Services
{
    public class ProductManager
    {
        AppDbContext _context = new();

        public List<Product> GetAllProducts(Expression<Func<Product, bool>> filter = null)
        {
             return filter == null
                ? _context.Products.Include(x=>x.Category).ToList()
                : _context.Products.Include(x=>x.Category).Where(filter).ToList();
            return _context.Products.ToList();
        }

        public Product GetProduct(int id) =>  _context.Products.FirstOrDefault(x=>x.Id ==id);
        

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}
