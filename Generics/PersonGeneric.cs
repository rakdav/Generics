using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PersonGeneric<T,K>
    {
        public T Id { get; set; }
        public K Password { get; set; }
        public string Name { get; set; }
        public PersonGeneric(T id, string name, K password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
    }
}
