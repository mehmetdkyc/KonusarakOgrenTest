using KonusarakOgren.DataAccess.Abstract;
using KonusarakOgren.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.DataAccess.Concrete
{
    public class ETicaretRepository : IETicaretRepository
    {
        public List<Users> GetAllUsers()
        {
            using (var dbContext  = new EntitiesDb())
            {
                return dbContext.User.ToList();
            }
        }
        public void DeleteUserById(int id)
        {
            using (var dbContext = new EntitiesDb())
            {
                var user = dbContext.User.FirstOrDefault(c => c.Id == id);
                dbContext.User.Remove(user);
                dbContext.SaveChanges();
            }
        }

        public Users GetById(int id)
        {
            using (var dbContext = new EntitiesDb())
            {
                return dbContext.User.FirstOrDefault(c => c.Id == id);
            }
        }

        public List<Category> GetCategories()
        {
            using (var dbContext = new EntitiesDb())
            {
                return dbContext.Categories.ToList();
            }
        }

        public Category GetCategoryById(int categoryId)
        {
            using (var dbContext = new EntitiesDb())
            {
                return dbContext.Categories.FirstOrDefault(c => c.Id == categoryId);
            }
        }

        public List<Products> GetProducts()
        {
            using (var dbContext = new EntitiesDb())
            {
                return dbContext.Product.ToList();
            }
        }

        public Products GetProductsById(int productId)
        {
            using (var dbContext = new EntitiesDb())
            {
                return dbContext.Product.FirstOrDefault(c => c.Id == productId);
            }
        }

        public List<UserInfo> GetUserInfo()
        {
            using (var dbContext = new EntitiesDb())
            {
                return dbContext.UserInfos.ToList();
            }
        }

        public UserInfo GetUserInfoById(int userId)
        {
            using (var dbContext = new EntitiesDb())
            {
                return dbContext.UserInfos.Find(userId);
            }
        }

        public void DeleteProductById(int id)
        {
            using (var dbContext = new EntitiesDb())
            {
                var product = dbContext.Product.FirstOrDefault(c=>c.Id==id);
                dbContext.Product.Remove(product);
                dbContext.SaveChanges();
            }
        }

        public Users CreateUser(Users user)
        {
            using (var dbContext = new EntitiesDb())
            {
                dbContext.User.Add(user);
                dbContext.SaveChanges();
                return user;
            }
        }

        public Products CreateProduct(Products product)
        {
            using (var dbContext = new EntitiesDb())
            {
                dbContext.Product.Add(product);
                dbContext.SaveChanges();
                return product;
            }
        }
    }
}
