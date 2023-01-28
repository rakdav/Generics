using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PersonString
    {
        public string Id { get; set; }
        public int Password { get; set; }
        public string Name { get; set; }
        public PersonString(string id, string name, int password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
    }
}
