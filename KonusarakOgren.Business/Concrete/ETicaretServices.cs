using KonusarakOgren.Business.Abstract;
using KonusarakOgren.DataAccess.Abstract;
using KonusarakOgren.DataAccess.Concrete;
using KonusarakOgren.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Business.Concrete
{
    public class ETicaretServices : IETicaretServices
    {
        private IETicaretRepository _service;
        public ETicaretServices()
        {
            _service = new ETicaretRepository();
        }
        
        public Products CreateProduct(Products product)
        {
            return _service.CreateProduct(product);
        }

        public Users CreateUser(Users user)
        {
            return _service.CreateUser(user);
        }

        public void DeleteProductById(int id)
        {
            _service.DeleteProductById(id);
        }

        public void DeleteUserById(int id)
        {
            _service.DeleteUserById(id);
        }

        public List<Users> GetAllUsers()
        {
            return _service.GetAllUsers();
        }

        public Users GetById(int id)
        {
            return _service.GetById(id);
        }

        public List<Category> GetCategories()
        {
            return _service.GetCategories();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _service.GetCategoryById(categoryId);
        }

        public List<Products> GetProducts()
        {
            return _service.GetProducts();
        }

        public Products GetProductsById(int productId)
        {
            return _service.GetProductsById(productId);
        }

        public List<UserInfo> GetUserInfo()
        {
            return _service.GetUserInfo();
        }

        public UserInfo GetUserInfoById(int userId)
        {
            return _service.GetUserInfoById(userId); 
        }
    }
}
