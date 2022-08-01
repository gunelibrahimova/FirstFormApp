using FirstFormApp.Data;
using FirstFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FirstFormApp.Services
{
    public class AuthManager
    {
         AppDbContext context = new();

        public void Register(User user, string pass)
        {
            user.Password= HashPassword(pass);
            context.Users.Add(user);
            context.SaveChanges();
        }

        public User Login(string email, string password )
        {
            var user = context.Users.FirstOrDefault(x=>x.Email == email);   

            if (user == null)
                return null;
            
            if (user.Password != HashPassword(password))
                return null;
            return user;
        }

        public string HashPassword(string password)
        {
            using HashAlgorithm hashAlgoritm = SHA256.Create();
            byte[] hashData = hashAlgoritm.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder stringBuilder = new();

            for (int i = 0; i < hashData.Length; i++)
            {
                stringBuilder.Append(hashData[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}
