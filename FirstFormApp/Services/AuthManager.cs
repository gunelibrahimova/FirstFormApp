using FirstFormApp.Data;
using FirstFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstFormApp.Services
{
    public class AuthManager
    {
         AppDbContext context = new();

        public void Register(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public User Login(string email, string password )
        {
            var user = context.Users.FirstOrDefault(x=>x.Email == email);   

            if (user == null)
                return null;
            
            if (user.Password != password)
                return user;
            return user;
        }





    }
}
