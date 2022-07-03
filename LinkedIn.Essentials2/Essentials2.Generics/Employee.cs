using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essentials2.Generics
{
    public class Employee
    {
        //public Employee(string Fname) => FirstName = Fname;

        private string f_name;
        public int Id { get; set; }
        public string FirstName
        {
            get => f_name;
            init => f_name = value;
        }
        public string LastName { get; set; }
        public DateOnly? JoinedDate { get; set; }

        public override string ToString() => $"{FirstName}_{LastName}";
    }
}
