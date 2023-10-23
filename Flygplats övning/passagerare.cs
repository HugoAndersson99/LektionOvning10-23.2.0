using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flygplats_övning
{
    internal class Passagerare
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public static int nextId = 1;
        
        public Passagerare(string name) 
        {
            Name = name;
            Id = nextId++;
        }
    }
}
