using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essentials2.Generics
{
    public class CustomerToPersonMapper : IMapper<Customer, Person>
    {
        public Person Map(Customer Source)
        {
            return new Person 
            { 
                Id = Source.Id, 
                FirstName = Source.FirstName, 
                LastName = Source.LastName 
            };
        }
    }
}
