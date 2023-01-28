using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Person
    {
        public object Id { get; set; }
        public object Password { get; set; }
        public string Name { get; set; }
        public Person(object id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
