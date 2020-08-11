using Microsoft.AspNetCore.Server.IIS.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication.Models
{
    public class School
    {
        private int _id;
        private string _name;
        private ICollection<Student> _students;
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public virtual ICollection<Student> Students
        {
            get {
                return _students;
            }
            set {
                _students = value;
            }
        }
    }
}
