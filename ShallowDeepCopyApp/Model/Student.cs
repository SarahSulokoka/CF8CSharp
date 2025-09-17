using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowDeepCopyApp.Model
{
    internal class Student
    {
        public  int Id  { get; set; }
        public string? Firstname { get; set; }
        public  string? Lastname { get; set; }
        public Address? Address { get; set; }
        public Student ShallowCopy()
        {
            return (Student)this.MemberwiseClone();
        }

       public Student GetShallowCopy()
        {
            return this;
        }

        public Student DeepCopy()
        {
            Student student = (Student)this.MemberwiseClone();
            student.Address = new Address()
            {
                Street = this.Address?.Street,
                Number = this.Address?.Number,
                ZipCode = this.Address?.ZipCode
            };
            return student;
        }
    }
}
