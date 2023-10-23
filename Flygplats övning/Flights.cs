using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flygplats_övning
{
    internal class Flights
    {
        
        
        public int FlightNumber { get; set; }
        public static int NewFlightNumber = 1000;
        public Flygplan Flygplan;
        public Passagerare Passagerare;
        
        public Flights (Passagerare passagerare)
        {
            Passagerare = passagerare;
        }
        public Flights(Flygplan flygplan)
        {
            Flygplan = flygplan;
            FlightNumber = NewFlightNumber++;
        }
        
        
    }
}
