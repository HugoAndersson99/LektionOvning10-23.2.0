using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flygplats_övning
{
    internal class Flygplan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Seats { get; set; }
        public static int nextId = 1;

        public Flygplan(string name, int seats) 
        { 
            Id = nextId++;
            Name = name;
            Seats = seats;

        }
    }
}
