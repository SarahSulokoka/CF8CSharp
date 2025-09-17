using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsApp.Model
{

    //sorting in Collections 
    internal class Product : IEquatable<Product> , IComparable<Product>

    {
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public int CompareTo(Product? other)
        {
            return Description.CompareTo(other!.Description);
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public bool Equals(Product? other)    // better performance, contains uses it . also in Dictionary
     
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
