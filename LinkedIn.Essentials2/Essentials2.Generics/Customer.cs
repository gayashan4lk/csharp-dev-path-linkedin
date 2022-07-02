using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essentials2.Generics
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public DateTime CreatedDate { get; set; }

        public T Map<T>(IMapper<Customer, T> mapper)
        {
            return mapper.Map(this);
        }
    }
}
