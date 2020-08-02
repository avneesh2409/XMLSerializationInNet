using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication.Models
{
    public class Student
    {
        private int _id;
        private string _name;
        private School _school;
        private string _address;
        public int Id {
            get {
                return this._id;
            }
            set {
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
        public School School
        {
            get
            {
                return this._school;
            }
            set
            {
                this._school = value;
            }
        }
        public string Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
    }
}
