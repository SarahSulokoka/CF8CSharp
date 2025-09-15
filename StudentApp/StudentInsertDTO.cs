using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal record StudentInsertDTO(string? Firstname, string? Lastname);
    //immutable class with positional parameters, init-only properties
    //No need for a constructor, properties are init-only by default, ToString, Equals, GetHashCode are overridden by default
    //Do we need a constructor for the record?
    //No, we don't need a constructor for the record.
    //When do we need a constructor?
    //We need a constructor when we want to initialize the object with specific values.
    //Why do we need a record?
    //We need a record when we want to create an immutable object with value-based equality.

}
