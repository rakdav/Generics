using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PersonInt
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public PersonInt(int id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
    }
}
