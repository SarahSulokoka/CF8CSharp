using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{

    //POCO - Plain Old CLR Object   
    internal sealed class Student//like final in java
    {
        private int id;
        private string? firstname;
        private string? lastname;

        public int Id { get => id; private set => id = value; } // Added private setter
        public string? Firstname { get => firstname; private set => firstname = value; } // Added private setter
        public string? Lastname { get => lastname; private set => lastname = value; } // Added private setter

        public Student() //default constructor
        {

        }

        public Student(int id, string? firstname, string? lastname)
        {
            this.Id = id; // Now valid due to private setter
            this.Firstname = firstname; // Now valid due to private setter
            this.Lastname = lastname; // Now valid due to private setter
        }
    }
}
