using KonusarakOgren.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Business.Abstract
{
    public interface IETicaretServices
    {
        List<Users> GetAllUsers();
        Users GetById(int id);
        void DeleteUserById(int id);
        Users CreateUser(Users user);
        List<Products> GetProducts();
        void DeleteProductById(int id);
        Products GetProductsById(int productId);
        Products CreateProduct(Products product);

        List<UserInfo> GetUserInfo();
        UserInfo GetUserInfoById(int userId);
        Category GetCategoryById(int categoryId);
        List<Category> GetCategories();
    }
}
