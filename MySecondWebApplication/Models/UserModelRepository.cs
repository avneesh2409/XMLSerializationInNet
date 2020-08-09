using MySecondWebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication.Models
{
    public class UserModelRepository : IUserModel
    {
        private readonly AppDbContext _context;

        public UserModelRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool AddUser(UserModel user)
        {
            try {
                _context.users.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
           
        }

        public UserViewModel GetUser(string email, string password)
        {
            try
            {
                var res = _context.users.Where(s =>(s.Email == email && s.Password == password))
                           .FirstOrDefault();
                UserViewModel user = new UserViewModel();
                user.Email = res.Email;
                user.Name = res.Name;
                user.Id = res.Id;
                return user;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }

        public IEnumerable<UserModel> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
