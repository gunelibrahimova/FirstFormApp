using FirstFormApp.Data;
using FirstFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstFormApp.Services
{
    public class CategoryManager
    {
        AppDbContext _context = new();
        
        public void Add(Categoryy category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
    }
}
