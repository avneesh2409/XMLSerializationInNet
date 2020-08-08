using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication.Models
{
    public class UserModel
    {
        private int _id;
        private string _name;
        private string _email;
        private string _password;
        
        public int Id { get => _id; set => _id = value; }
        [Required]
        public string Email { get => _email; set => _email = value; }
        [Required]
        public string Password { get => _password; set => _password = value; }
        [Required]
        public string Name { get => _name; set => _name = value; }
    }
}
