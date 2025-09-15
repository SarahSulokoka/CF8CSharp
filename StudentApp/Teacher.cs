using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Teacher
    {
        public int Id { get; set; } // Added private setter auto implemented property
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public override string ToString()
        {
            return $"{Id} {Firstname} {Lastname}";
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //public override string ToString() => return $"{Id} {Firstname} {Lastname}";

        //Do we need a constructor for the override?
        //No, we don't need a constructor for the override.
        //When do we need a constructor?
        //We need a constructor when we want to initialize the object with specific values.

        public Teacher() //default constructor
        {
        }



    }

}
