using MySecondWebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication.Models
{
    public interface IUserModel
    {
        IEnumerable<UserModel> GetUsers();
        bool AddUser(UserModel user);
        UserViewModel GetUser(string email, string password);
    }
}
